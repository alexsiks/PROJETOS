//Instalação do 'npm install --save express-handlebars'
const express = require('express')
const app = express()
porta = 8085
const handlebars = require('express-handlebars')
const bodyParser = require('body-parser')
    // body-parser
app.use(bodyParser.urlencoded({ defaultLayout: false }))
app.use(bodyParser.json())


//handlebars congiguração

app.engine('handlebars', handlebars({ defaultLayout: 'main' }))
app.set('view engine', 'handlebars')


//Rotas


app.get('/formulario', function(req, res) {
    res.render('formulario')

})

app.get('/index', function(req, res) {
    res.render('saudacao')

})

//cadastro por get
app.get('/formulario-cadastrar', function(req, res) {
    console.log(req.query)
    res.send(req.query)
    res.end()
        //Ter informações separadas console.log(req.query['nome'])
})



// conexão servidor
app.listen(porta, function(err) {
    if (err) {
        console.log('Erro de conexão.')
    } else {
        console.log('Servidor ativo na porta ' + porta)
    }

})