const Sequelize = require('sequelize')
const sequelize = new Sequelize('una', 'node', '1q2w3e4r5t6y7u8i9o0p', {
    host: 'localhost',
    dialect: 'mysql'
})

sequelize.authenticate().then(function() {
    console.log('conectado com sucesso.')
}).catch(function(err) {
    console.log('Não foi possivel conectar: ' + err)

})


// criação de tabela
const User = sequelize.define('CONTATOS', {
    nome: {
        type: Sequelize.TEXT,
    },
    telefone: {
        type: Sequelize.TEXT,
    },
    sexo: {
        type: Sequelize.TEXT,
    },
    sexo: {
        type: Sequelize.TEXT,
    },
    idade: {
        type: Sequelize.TEXT,
    }

})


User.create({
    nome: 'Luiza de medeiros',
    telefone: '31985457585',
    sexo: 'feminino',
    idade: '23'
})

//User.sync({ force: true });