import requests

http = requests.get('''https://api.thingspeak.com/channels/1221660/fields/1.json''')

print(http.text)
