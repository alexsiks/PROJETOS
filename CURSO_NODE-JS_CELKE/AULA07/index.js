// instale o 'npm install express --save'
var express = require('express')
var app = express()
var porta = 8084

//Conexão com mysql
const mysql = require('mysql')

var connection = mysql.createConnection({
    host: 'localhost',
    user: 'node',
    password: '1q2w3e4r5t6y7u8i9o0p',
    database: 'UNA'
});

connection.query('select 1', function(err, results, fields) {
    if (err) {
        console.error('erro: ' + err.stack)
        return
    }
    console.log('Conectado com sucesso ' + connection.threadId)

})

//select no banco de dados

connection.query('select * from contatos', function(err, rows) {
    if (err) {
        console.error('erro: ' + err.stack)
        return
    }

    console.log(rows)

})

//Rotas
app.get('/formulario', function(req, res) {
    res.sendFile(__dirname + '/html/index.html')

})

app.listen(porta, function() {
    console.log(`servidor esta rodando na porta ${porta}`)
})

//detalhes https://www.youtube.com/watch?v=5JnPd_YckQw&list=PLmY5AEiqDWwBHJ3i_8MDSszXXRTcFdkSu&index=7
/*
****observação******
 
caso haver erros verifique o pacote do mysql 
 
*/