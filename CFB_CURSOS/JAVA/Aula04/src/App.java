
import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        Scanner scan = new Scanner(System.in);
        String nome = " ";
        int n1 = 0, n2 = 0, res = 0;

        System.out.println("Informe o Nome: ");
        nome = scan.nextLine();

        System.out.println("Informe o 1° numero: ");
        n1 = scan.nextInt();

        System.out.println("Informe o 2° numero: ");
        n2 = scan.nextInt();

        res = n1 + n2;

        System.out.printf("%s a soma de %d + %d é igual a %d. ", nome, n1, n2, res);
    }
}
