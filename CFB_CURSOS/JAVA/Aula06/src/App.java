public class App {
    public static void main(String[] args) throws Exception {

        int tam = 12;

        int[] num = new int[tam];

        inserirValoresArray(num);

        imprimirArray(num);

    }

    private static void imprimirArray(int[] num) {
        for (int i = 0; i < num.length; i++) {
            System.out.printf("%d , ", num[i]);

        }
    }

    private static void inserirValoresArray(int[] num) {
        num[0] = 2;
        num[8] = 12;
    }
}
