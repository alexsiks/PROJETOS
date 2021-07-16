package aplicacao;

import java.util.Scanner;
public class Cauculadora {

	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
    Scanner scan = new Scanner(System.in);
   
   Numero n1 = new Numero();
   Numero n2 = new Numero();
   Numero resultado = new Numero();
   
   
   System.out.println("Informe o primeiro numero: ");
   n1.setValor(scan.nextDouble());
   
   System.out.println("Informe o Segundo numero: ");
   n2.setValor(scan.nextDouble());
   
   resultado.setValor(n1.getValor()+n2.getValor());
   
   System.out.print("A soma de "+n1.getValor()+" + "+n2.getValor()+" é igual a "+resultado.getValor());
		
	}

}
