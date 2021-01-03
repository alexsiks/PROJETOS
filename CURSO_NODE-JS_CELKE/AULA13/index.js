//Instalação do 'npm install --save express-handlebars'
const express = require('/Users/alexb/OneDrive/Documentos/GitHub/CURSO_NODE-JS_CELKE/node_modules/express')
const app = express()
porta = 8085
const handlebars = require('express-handlebars')
const bodyParser = require('/Users/alexb/OneDrive/Documentos/GitHub/CURSO_NODE-JS_CELKE/node_modules/body-parser')
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
        //console.log(req.params['nome'], req.params['telefone'], req.params['sexo'], req.params['idade'])
})



// conexão servidor
app.listen(porta, fu / function(err) {
    if (err) {
        console.log('Erro de conexão.')
    } else {
        console.log('Servidor ativo')
    }

})