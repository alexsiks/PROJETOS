import requests


def requisicao():
    r = requests.get("https://api.thingspeak.com/channels/1221525/feeds.json?api_key=QSGOH3HLXO0W7MGB")
    dados=r.json()

