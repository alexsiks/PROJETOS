/* Expose esta função para o Python
eel.expose(say_hello_js); // Expose da função para o Python
function say_hello_js(x) {

}



//Função para o envio de mensagem para o python//
function enviar_python(info) {
    var mensagem = document.getElementById('mensagem-py').value;


    var info = say_hello_js("javascript");
    eel.say_hello_py(mensagem); // Chamada da função do Python 

    var datarequisicao = 'Horario de envio de Dados:' + new Date();
    console.log(datarequisicao.toString())

}



/*----------------------------Chart.js  flamwework de graficos-------------------------------------------------------------------------------*/
/*
$("#chamar-py").css(function() {
    alert('')



})



/*_______________________________________________________________________________*/


var temp = [2, 4, 23, 35, 46, 24, 7, 14, 12, 40]
for (var i = 0; i < temp.length; i++) {
    temp[i]

    document.getElementById('dado1').innerHTML = (temp)

}


var umid = [2, 10, 25, 3, 70, 33, 34, 2, 15, 24]
for (var i = 0; i < umid.length; i++) {
    umid[i]
    document.getElementById('dado2').innerHTML = (umid)

}


var ctx = document.getElementsByClassName("line-chart");
var chartGraph = new Chart(ctx, {
    type: 'line',


    data: {
        /*loop para a repetição */

        labels: ["1° MEDIÇÃO", "2° MEDIÇÃO", "3° MEDIÇÃO", "4° MEDICAO", "5° MEDIÇÃO", "6° MEDIÇÃO", "7° MEDIÇÃO", "8° MEDIÇÃO", "9° MEDIÇÃO", "10° MEDIÇÃO"],
        datasets: [{


            label: 'TEMPERATURA',
            data: [temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6], temp[7], temp[8], temp[9]],
            borderColor: 'rgba(300, 30, 20,18)',
            borderwidth: 6,
            backgroundColor: 'transparent',


        }, {
            label: 'UMIDADE',
            data: [umid[0], umid[1], umid[2], umid[3], umid[4], umid[5], umid[6], umid[7], umid[8], umid[9]],
            borderColor: 'rgba(77, 166, 253,0.85)',
            borderwidth: 6,
            backgroundColor: 'transparent',


        }]



    },



})