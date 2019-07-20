from base import Base
import queue
import threading
import time


"""
Class TTManager handles sending text to speech messages to media players

Following features are implemented:

- Speak text to choosen media_player
- Speak text with greeting to choosen media_player
- Full queue support to manage async multiple TTS commands
- Full wait to tts to finish to be able to supply a callback method

"""
class TTSManager(Base):

    def initialize(self) -> None:
        """Initialize."""
        super().initialize() # Always call base class
        self._queue = queue.Queue()
        self._when_tts_done_callback_queue = queue.Queue()

        # Init the worker thread
        self._worker = threading.Thread(target=self.__worker)
        self._worker.daemon = True
        self._worker.start()

    def speak(self, text: str, media_player:str = 'media_player.living_room_sonos') -> None:
        """Speak the provided text through the media player"""

        # queues the message to be handled async, use when_tts_done_do method to supply callback when tts is done
        self._queue.put({'text': text, 'media_player': media_player})

    def speak_greeting(self, person:str, message:str, media_player:str = 'media_player.living_room_sonos')->None:
        """Speak the provided greeting through the media player"""
        self.speak(self.notification_manager.greeting_text(person, message), media_player)

    def set_volume_level(self, volume_level:str, media_player:str = 'media_player.living_room_sonos')->None:
        """Put command for setting volume on the queue"""
        self._queue.put({'text': '_SET_VOLUME', 'media_player': media_player, 'volume_level':volume_level})
    
    def when_tts_done_do(self, callback:callable)->None:
        """Callback when the queue of tts messages are done"""
        self._when_tts_done_callback_queue.put(callback)

    # Worker thread that take all in queue and TTS the content
    def __worker(self)->None:
        while(True):
            # Get the messages   
            media = self._queue.get()
            media_player = media['media_player']
            text = media['text']

            if text.startswith('_'):
                # We have a command
                if text == '_SET_VOLUME':
                    self.log("SET VOLUME!!")
                    volume_level = media['volume_level']
                    self.call_service(
                        'media_player/volume_set',
                        entity_id=media_player,
                        volume_level=volume_level) #'0.6'
                    time.sleep(2)
            else:
                # TTS the message
                self.log("GET TTS {} message: {}".format(text, media_player))
                self.call_service(
                    'tts/google_say',
                    entity_id=media_player,
                    message=text)
                time.sleep(2)
                duration = self.get_state(
                    media_player, attribute='media_duration')

                if not duration:
                    #The TTS already played, set a small duration
                    duration = 2

                #Sleep and wait for the tts to finish    
                time.sleep(duration)

            self._queue.task_done()
            
            if self._queue.qsize() == 0:
                # It is empty, make callbacks
                try:
                    while(self._when_tts_done_callback_queue.qsize() > 0):
                        callback_func = self._when_tts_done_callback_queue.get_nowait()
                        callback_func() # Call the callback
                        self._when_tts_done_callback_queue.task_done()
                except:
                    pass # Nothing in queue
    
    def snapshot(self, media_player:str = 'media_player.living_room_sonos') -> None:
        self.log("Taking snapshot")
        self.call_service(
            'sonos/snapshot',
            entity_id=media_player)

    def restore(self, media_player:str = 'media_player.living_room_sonos') -> None:
        self.log("Restoring snapshot")
        self.call_service(
            'sonos/restore',
            entity_id=media_player)