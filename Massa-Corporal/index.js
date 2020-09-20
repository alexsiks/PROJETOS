function caucular() {
    //Variaveis.
    var nome = document.getElementById('txb_nome').value;
    var altura = document.getElementById('txb_altura').value;
    var peso = document.getElementById('txb_peso').value;

    var massacorporal = parseFloat(peso) / (parseFloat(altura)* 2 );

    //Impressao de resultado mediante a massa corporal.


    document.getElementById('txb_resposta2').innerHTML =
   "Indice de Massa Corporal:"+ massacorporal;


    if (massacorporal < 17) {
        document.getElementById('txb_resposta').style.backgroundColor = 'blue';

        document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta Muito abaixo do Peso.';
    }  else if(massacorporal > 16.00 && massacorporal < 18.50) {
        document.getElementById('txb_resposta').style.backgroundColor = 'green';

                document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta Abaixo do peso.';
    } else if (massacorporal > 18.49 && massacorporal < 25.00) {
        
        document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta com o Peso normal.';
    } else if (massacorporal > 24.99 && massacorporal < 30.00) {
        document.getElementById('txb_resposta').style.backgroundColor = 'pink';
        

        document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta Acima do Peso.';
    } else if (massacorporal > 29.99 && massacorporal < 35.00) {
        document.getElementById('txb_resposta').style.backgroundColor = 'yellow';
        
        document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta com Obesidade Nivel 1.';
    } else if (massacorporal > 34.99 && massacorporal < 40.00) {
        document.getElementById('txb_resposta').style.backgroundColor = 'orange';
        
        document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta com Obesidade II (severa).';
    } else  {
        document.getElementById('txb_resposta').style.backgroundColor = 'red';
        
        document.getElementById('txb_resposta').innerHTML =
            nome + ', Voce esta  com Obesidade III (mórbida).';
    }

if(massacorporal > 25){
    massacorporal-=25;

    document.getElementById('txb_resposta2').innerHTML =
    nome + ', Voce precisa perder ' + massacorporal + " de massa corporal." ;

}

}
