//Instalação do 'npm install --save express-handlebars'
const express = require('./node_modules/express')
const app = express()
const porta = 8086
const handlebars = require('express-handlebars')
const bodyParser = require('./node_modules/body-parser')

//funções mysql
const cad = require('./modulos/cadastrar')
const inserir = require('./modulos/cadastrar')
const { response } = require('./node_modules/express')

// body-parser

app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser.json())



//handlebars congiguração

app.engine('handlebars', handlebars({ defaultLayout: 'main' }))
app.set('view engine', 'handlebars')


//Rotas


app.get('/formulario', function(req, res) {
    res.render('formulario')



})

app.post('/cadastrar', function(req, res, err) {

    var dado = [req.body.nome, req.body.telefone, req.body.sexo, req.body.idade]

    console.log(dado)
    inserir(dado, resposta)


    console.log(resposta)

    console.log('dados enviados com sucesso.')



    res.end()



})



// conexão servidor
app.listen(porta, function(err) {
    if (err) {
        console.log('Erro de conexão.')
    } else {
        console.log('Servidor ativo na porta ' + porta)
    }

})