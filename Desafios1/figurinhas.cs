using System;

class Figurinhas {
  
  static void Main(string[] args) {
    int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
    int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
    int totalDeFigurinhas = 0;

    int[] albumDeFigurinha = new int[numeroDeFigurinhas + 1];
    
    for(int i = 0; i < numeroDeFigurinhasCompradas; i++) {
      
      int num = Int32.Parse(Console.ReadLine());
      albumDeFigurinha[num] = 1;
      
    }
    
    for(int i = 1; i < albumDeFigurinha.Length; i++) {
      if(albumDeFigurinha[i] == 0) {
        totalDeFigurinhas++;
      }
    }

    Console.WriteLine(totalDeFigurinhas);
  }

}