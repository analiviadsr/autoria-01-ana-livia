// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola, as opçoes de comida de hoje são:\n 1- pizza: 8,00\n 2-pastel: 5,00 \n 3- pao: 2,00"); 
Console.WriteLine("Digite o numero do seu lanche de hoje");
string lanche =  (Console.ReadLine());
Console.WriteLine("Quantos lanches voce deseja?");
int quantidade = int.Parse(Console.ReadLine());
if (lanche == "1")
{
    double total = 8 * quantidade;
    Console.WriteLine($"Voce deve pagar {total} reais");
}
 else if (lanche== "2")
{
    double total = 5 * quantidade;
    Console.WriteLine($"Voce deve pagar {total} reais");
}
else if (lanche== "3")
{
    double total = 2 * quantidade;
    Console.WriteLine($"Voce deve pagar {total} reais");
}

 


