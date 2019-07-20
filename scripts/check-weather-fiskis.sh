#!/bin/bash
SET_AGENT="Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:60.0) Gecko/20100101 Firefox/60.0"
SET_URL="https://www.accuweather.com/en/se/fisksatra/310043/minute-weather-forecast/310043"

weather_alert () {

curl -A "$SET_AGENT" -s $SET_URL | \
                        sed -n '/<!-- Summary -->/{n;p;n;p;n}' | \
                        tail -1 | sed  's/<p>/ /' | sed  's/<\/p>/ /' | grep -oE "[A-Z].*"
}

weather_alert