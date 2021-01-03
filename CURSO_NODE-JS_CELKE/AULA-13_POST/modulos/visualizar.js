var ver = function() {
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



    //SELECIONANDO DADOS.
    var sql = 'select * from contatos'
    connection.query(sql, function(err, rows) {

        if (err) {
            throw err
        }

        var usuarios = '';
        for (var i = 0; i < rows.length; i++) {
            usuarios += `  
            NOME: ${rows[i].nome}
            SEXO: ${rows[i].sexo}
            IDADE:${rows[i].idade}
            TELEFONE:${rows[i].telefone}
            \n--------------------\n`

        }


        console.log(usuarios)

    })
}

module.exports = ver