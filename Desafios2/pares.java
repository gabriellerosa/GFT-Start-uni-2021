import java.io.IOException;
import java.util.Scanner;

public class Main {
	 
    public static void main(String[] args) throws IOException {
      
      Scanner scanner = new Scanner(System.in);
      int n = scanner.nextInt();
	    int i = 1;
      
    	for (i = 1; i <= n; i++) {
    		if (i % 2 == 0) 
    		  System.out.println(i);
    	}
    }
}