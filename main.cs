using System;

class Program {
  public static void Main (string[] args) {
  string produto;
  Int16 qtdadquirida;
  Double preco, total, desconto;

  Console.WriteLine("Digite o nome do produto");
  produto = Console.ReadLine();

  Console.WriteLine("Digite a quantidade adquirida");
  qtdadquirida = Int16.Parse (Console.ReadLine());

  Console.WriteLine("Digite o preço unitário");
  preco = Double.Parse (Console.ReadLine());

  total = (qtdadquirida * preco);

  if (qtdadquirida < 5)
  {
    desconto = 2;
  }


 if (qtdadquirida > 5 && qtdadquirida <= 10)
 {
   desconto = 3;
}

  else { desconto = 5;
}

    {
      total = (total*(desconto/100));
    }
    
  Console.WriteLine("O valor total a pagar é : " + total + " reais ");

  }
}
