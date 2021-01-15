import java.io.IOException;
import java.util.Scanner;

public class Prova{
	
    public static void main(String[] args) throws IOException {
        Scanner leitor = new Scanner(System.in);
        int nota = leitor.nextInt();
        
        String m = "E";
        
        if( nota >= 86 && nota <= 100) {
          m = "A";
        } else if ( nota >= 61 && nota <= 85) {
          m = "B";
        } else if ( nota >= 36 && nota <= 60) {
          m = "C";
        } else if ( nota >= 1 && nota <= 35) {
          m = "D";
        }
        
        System.out.println(m);
    }
	
}