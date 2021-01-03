var http = require('http')
var porta = 8084









http.createServer(function(req, res) {
    res.end('Servidor rodando') // saida de mensagem para o navegador


}).listen(porta)

// Link do curso https://www.youtube.com/watch?v=7Oem0XPdTbg&list=PLmY5AEiqDWwBHJ3i_8MDSszXXRTcFdkSu&index=3