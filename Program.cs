using System;

// Classe abstrata Smartphone
public abstract class Smartphone
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    // Método abstrato que deve ser implementado nas classes filhas
    public abstract void Ligar();
    
    // Método abstrato que deve ser implementado nas classes filhas
    public abstract void Desligar();

    // Método virtual que pode ser substituído nas classes filhas
    public virtual void FazerChamada(string numero)
    {
        Console.WriteLine($"Realizando chamada para {numero}...");
    }

    // Método abstrato que deve ser implementado nas classes filhas
    public abstract void InstalarAplicativo(string aplicativo);
}

// Classe Nokia que herda de Smartphone
public class Nokia : Smartphone
{
    public Nokia(string modelo)
    {
        Marca = "Nokia";
        Modelo = modelo;
    }

    // Implementação do método abstrato Ligar
    public override void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} ligando...");
    }

    // Implementação do método abstrato Desligar
    public override void Desligar()
    {
        Console.WriteLine($"{Marca} {Modelo} desligando...");
    }

    // Implementação do método abstrato InstalarAplicativo
    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando {aplicativo} na {Marca} {Modelo}...");
    }
}

// Classe iPhone que herda de Smartphone
public class iPhone : Smartphone
{
    public iPhone(string modelo)
    {
        Marca = "iPhone";
        Modelo = modelo;
    }

    // Implementação do método abstrato Ligar
    public override void Ligar()
    {
        Console.WriteLine($"{Marca} {Modelo} ligando...");
    }

    // Implementação do método abstrato Desligar
    public override void Desligar()
    {
        Console.WriteLine($"{Marca} {Modelo} desligando...");
    }

    // Implementação do método abstrato InstalarAplicativo
    public override void InstalarAplicativo(string aplicativo)
    {
        Console.WriteLine($"Instalando {aplicativo} no {Marca} {Modelo}...");
    }
}

class Program
{
    static void Main()
    {
        // Exemplo de uso
        Nokia nokia = new Nokia("Lumia");
        iPhone iphone = new iPhone("12 Pro");

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}
