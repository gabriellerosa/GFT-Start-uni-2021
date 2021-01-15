import java.util.Scanner;

public class Main
{

  public static void main (String[]args)
  {

    Scanner leitor = new Scanner (System.in);

    int dias, meses, anos;

      dias = leitor.nextInt ();

      anos = dias / 365;
      dias %= 365;
      meses = dias / 30;
      dias %= 30;

      System.out.println (anos + " ano(s)");
      System.out.println (meses + " mes(es)");
      System.out.println (dias + " dia(s)");

      leitor.close ();

  }

}