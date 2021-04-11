public class Jogador {

    private int registro = 0;
    private String nome = " ";
    private int idade = 0;
    private char sexo = ' ';

    public Jogador(int registro, String nome, int idade, char sexo) {

        this.registro = registro;
        this.nome = nome;
        this.sexo = sexo;
        this.idade = idade;

        System.out.printf("%n Registro do Jogador: %d %n ", registro);
        System.out.printf("%n Nome do Jogador: %s %n ", nome);
        System.out.printf("%n Idade do Jogador: %d %n  ", idade);
        System.out.printf("%nSexo do Jogador: %c %n  ", sexo);

    }

}
