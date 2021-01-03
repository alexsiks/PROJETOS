//Instalação do 'npm install --save express-handlebars'
const express = require('express')
const app = express()
porta = 8085
const handlebars = require('express-handlebars')


//handlebars congiguração

app.engine('handlebars', handlebars({ defaultLayout: 'main' }))
app.set('view engine', 'handlebars')


//Rotas


app.get('/formulario-cadastrar', function(req, res) {
    res.render('formulario')

})

app.get('/index', function(req, res) {
    res.render('saudacao')

})



// conexão servidor
app.listen(porta, function(err) {
    if (err) {
        console.log('Erro de conexão.')
    } else {
        console.log('Servidor ativo')
    }

})