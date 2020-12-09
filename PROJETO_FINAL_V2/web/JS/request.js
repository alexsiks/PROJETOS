const http = new XMLHttpRequest()

function requisicao() {

    http.open("GET", "https://api.thingspeak.com/channels/1221525/feeds.json?api_key=QSGOH3HLXO0W7MGB")
    http.send()

    var data = new Date()

    http.onload = () => console.log(http.responseText)

    http.onload = () => document.getElementById('mensagem-py').innerHTML = (
        `DATA DE REQUISIÇÃO: ${data} \n\n
        ----------------------------------------------------${http.responseText}`
    )
}