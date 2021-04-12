import java.util.Scanner;

public class App {

    private static int registro = 0;
    private static String nomeCompleto = " ";
    private static int idade = 0;
    private static char sexo = ' ';

    public static void main(String[] args) throws Exception {
        Scanner scan = new Scanner(System.in);

        InformarDados(scan);

    }

    private static void InformarDados(Scanner scan) {
        confirmarDados(scan);

        cadastrar(registro, nomeCompleto, sexo, idade);

    }

    private static void confirmarDados(Scanner scan) {
        System.out.println("Informe o Registro do do jogador: ");
        registro = scan.nextInt();
        System.out.println("Informe o Nome Completo: ");
        nomeCompleto = scan.nextLine();
        System.out.println("Informe o Sexo : ");
        sexo = scan.next().charAt(0);
        System.out.println("Informe a Idade: ");
        idade = scan.nextInt();

    }

    private static void cadastrar(int registro, String nomeCompleto, char sexo, int idade) {

        Jogador jogador = new Jogador(registro, nomeCompleto, idade, sexo);
    }

}
