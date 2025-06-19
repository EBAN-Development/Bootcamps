package BancoPan;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintWriter;

public class Dragao {
    static InputStreamReader read = new InputStreamReader(System.in);
    static BufferedReader scan = new BufferedReader(read);
    public static void main(String[] args) throws IOException {
        PrintWriter out = new PrintWriter(System.out);
        int casos, poderDeLuta;
        casos = Integer.parseInt(scan.readLine());

        for(int i = 0; i < casos; i++){
            poderDeLuta = Integer.parseInt(scan.readLine());
            System.out.println((poderDeLuta > 8000) ? "Mais de 8000!" : "Inseto!");
        }
        out.flush();
    }
}
