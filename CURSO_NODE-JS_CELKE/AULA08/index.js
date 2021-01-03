//Conexão com mysql
const { json, text } = require('body-parser');
const express = require('express')
var app = express()
const porta = 8085

const visualizar = require('./modulos_app/select');



app.get('/inicial', function(req, res) {

    app.sendFile("index")

})





app.listen(porta, function(err) {

    if (err) {
        console.log('Erro em ligar servidor')
    }
    console.log('servidor ligado com sucesso.')
})

//Rotas



//detalhes https://www.youtube.com/watch?v=5JnPd_YckQw&list=PLmY5AEiqDWwBHJ3i_8MDSszXXRTcFdkSu&index=7
/*
****observação******
 
caso haver erros verifique o pacote do mysql 
 
*/