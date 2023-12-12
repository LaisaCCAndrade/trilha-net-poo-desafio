using System;
using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criar instância de Nokia
        Nokia nokia = new Nokia("123456789");
        nokia.Marca = "Nokia";
        nokia.Modelo = "Lumia";
        nokia.TamanhoTela = 5.0m;

        // Testar métodos da classe Nokia
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Criar instância de iPhone
        Iphone iphone = new Iphone("987654321");
        iphone.Marca = "iPhone";
        iphone.Modelo = "12 Pro";
        iphone.TamanhoTela = 6.1m;

        // Testar métodos da classe iPhone
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
