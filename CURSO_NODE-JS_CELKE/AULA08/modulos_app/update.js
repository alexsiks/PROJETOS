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
id = '1'
nome = 'Luiza havilar'
telefone = '31998754425'
sexo = 'feminino'
idade = '32'


// atualizar  dados.
connection.query(`update contatos set nome = '${nome}',telefone = '${telefone}', sexo = '${sexo}', idade = '${idade}' where id = ${id}`, function(err, rows) {
    if (err) {
        console.log('Erro ao atualizar os dados.')
    } else {

        console.log(rows)
        console.log('Atualização realizada com sucesso.\n\n\n')
    }
})


//Rotas



//detalhes https://www.youtube.com/watch?v=5JnPd_YckQw&list=PLmY5AEiqDWwBHJ3i_8MDSszXXRTcFdkSu&index=7
/*
****observação******
 
caso haver erros verifique o pacote do mysql 
 
*/