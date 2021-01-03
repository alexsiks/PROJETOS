create Database BIGDATA_TEMPO_2020

use bigdata_tempo_2020 

/* drop table climatempo 
use o script acima somente para apagar quando necessario fazer um retorno do id
*/


create table climatempo(
IDREGISTRO int identity primary key,
TEMPERATURA FLOAT,
UMIDADE FLOAT,
REGISTRO_HORARIO as getdate() 
)

create table media_temperatura(
IDREGISTRO int identity primary key,
TEMPERATURA_MEDIA FLOAT,
REGISTRO_HORARIO as getdate() 
)
/* 
No momento de inser��o do algoritmo de dados, verificar se o mesmo esta cauculando a media
para o banco de dados das determinadas temperaturas, pois as fun��es usadas direto no banco de dados
s�o as de atualiza��es de informa��es.
*/

/*
comando ilustrativo de inser��o de dados.

insert into climatempo (temperatura,umidade) values (25.9,12.3)
*/

/*


script para selecionar os dados referente da tabela.

delete from climatempo

select*from climatempo
*/

select * from climatempo