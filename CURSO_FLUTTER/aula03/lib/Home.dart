import 'package:flutter/material.dart';

class Home extends StatefulWidget {
  @override
  _HomeState createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    //Barra de Titulo
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.deepPurple,
        title: Text('Quebrando a maldição do ola mundo.'),
      ),

      //Corpo da aplicação

      backgroundColor: Colors.purple[90],
      body: Container(
        child: Text('Meu Corpo'),
      ),
    );
  }
}
