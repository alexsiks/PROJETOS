// instale o 'npm install express --save'
var express = require('express')
var app = express()
var porta = 8084

app.get('/formulario', function(req, res) {
    res.sendFile(__dirname + '/html/index.html')
})

app.listen(porta, function() {
    console.log(`servidor esta rodando na porta ${porta}`)
})