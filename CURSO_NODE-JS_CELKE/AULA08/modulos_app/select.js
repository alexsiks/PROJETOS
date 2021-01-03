var visualizar = function() {



    //Conexão com mysql
    const mysql = require('mysql')

    var connection = mysql.createConnection({
        host: 'localhost',
        user: 'node',
        password: '1q2w3e4r5t6y7u8i9o0p',
        database: 'UNA'
    });



    connection.connect(function(err) {
        if (err) {
            console.error('Erro ao conectar ao banco  de dados.\n\ntipode erro:\t\t' + err.stack)
            return
        } else {
            console.log('Conectado com sucesso ao banco de dados.\n\n')

        }


    })


    connection.query('select *  from contatos', function(err, rows) {

        console.log(rows)

    })

}

module.exports = visualizar