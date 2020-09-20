/*
    Aula sobre Metodo construtor.

*O "METODO CONSTRUTOR" Tem o mesmo nome da Classe. 
 
https://www.youtube.com/watch?v=8mYnRrUuLj4&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=28
*/

using System;
//   ESPECIFICADOR DE ACESSO CHAMADO TAMBEM MODIFICADOR DE ACESSO "PUBLIC".     
public class Jogador//CLASSE "JOGADOR". 
{
    public int energia;//PROPRIEDADE DA CLASSE  "INT".
    public bool vivo;//PROPRIEDADE DA CLASSE  "BOOL".

    public Jogador()
    {
        energia = 100;
        vivo = true;

    }


}
public class Programa
{
    static void Main()// Metodo Principal.
    {
        Jogador j1 = new Jogador();//Operador "new" reserva um espaço na memoria, Objeto "j1".
        Jogador j2 = new Jogador();//Operador "new" reserva um espaço na memoria, Objeto "j2".
        Jogador j3 = new Jogador();//Operador "new" reserva um espaço na memoria, Objeto "j3".
        Jogador j4 = new Jogador();//Operador "new" reserva um espaço na memoria, Objeto "j4".

        j3.energia += int.Parse(Console.ReadLine());
        //Objeto "J1" com propriedade "energia".
        Console.WriteLine("Jogador {0},{1},{2},{3}", j1.energia, j2.vivo, j3.energia, j4.energia);

    }
}
