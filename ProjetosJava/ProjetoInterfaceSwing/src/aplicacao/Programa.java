package aplicacao;

import aritmetica.Cauculo;

public class Programa {
	
	public static void main(String[] args) {
		
		Cauculo cauc = new Cauculo();
		
		cauc.setSoma(3, 7);
		cauc.setSoma(2, 6);
		cauc.setSoma(1, 4);
		
		System.out.print(Cauculo.somaTotal);
	}

}
