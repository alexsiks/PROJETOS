var inserir = function(dados) {

    console.log('dadoss do formulario na funçã inserir' + dados)
    var nome = dados[0];
    var telefone = dados[1];
    var sexo = dados[2];
    var idade = dados[3];



    //Conexão com mysql
    const mysql = require('mysql')


    var connection = mysql.createConnection({
        host: 'localhost',
        user: 'node',
        password: '1q2w3e4r5t6y7u8i9o0p',
        database: 'UNA'
    });

    //testar conexão
    connection.connect(function(err) {
        if (err) {
            console.error('Erro ao conectar ao banco  de dadosss.\n\ntipode erro:\t\t' + err.stack)

        } else {
            console.log('Conectado com sucesso ao banco de dadosss.\n\n')


        }


    })




    //INSERINDO dadossS.
    var sql = `insert into contatos(nome,telefone,sexo,idade) values ('${dados[0]}',${dados[1]},'${dados[2]}',${dados[3]});`;
    connection.query(sql, function(err, rows) {


        if (err) {
            throw err
        } else {
            console.log('Dados Inseridos com Sucesso')
            console.log(rows)
        }


    })



}

module.exports = inserir