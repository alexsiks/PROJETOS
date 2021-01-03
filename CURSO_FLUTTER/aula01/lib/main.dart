/*
O link da aula esta em: 
https://www.youtube.com/watch?v=2ZMjAPROhtg&list=PL69eBMqNvxhVTQ9XcnG-21BnOqWZDdCVt
*/
import 'package:flutter/material.dart';

void main() {
  runApp(Principal());
}

class Principal extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        home: Scaffold(
      appBar: AppBar(
        title: Text('Aula 01: Usando MaterialApp'),
      ),
      body: Center(
        child: Text(''' 
      Conteudo da Aula:

      Nesta parte estamos vendo sobre como fazer
      a construção do Corpo na mesma tela.  
      '''),
      ),
    ));
  }
}
