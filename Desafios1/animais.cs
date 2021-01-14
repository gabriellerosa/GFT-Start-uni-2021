using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
      String  tipo; //declare as suas variaveis
        String  classe;
        String  alimento;

        tipo = Console.ReadLine(); //insira suas variaveis
        classe = Console.ReadLine();
        alimento = Console.ReadLine();

        if(tipo == "vertebrado") {
          
          if(classe == "ave") {
            if(alimento == "carnivoro") {
              Console.WriteLine("aguia\n");
            } else {
              Console.WriteLine("pomba\n");
            }
          } else {
            if(alimento == "onivoro") {
              Console.WriteLine("homem\n");
            } else {
              Console.WriteLine("vaca\n");
            }
          }
        } else {
          
          if(classe == "inseto") {
            if(alimento == "hematofago") {
              Console.WriteLine("pulga\n");
            } else {
              Console.WriteLine("lagarta\n");
            }
          } else {
            if(alimento == "hematofago") {
              Console.WriteLine("sanguessuga\n");
            } else {
              Console.WriteLine("minhoca\n");
            }
          }
          
        }
  }
}