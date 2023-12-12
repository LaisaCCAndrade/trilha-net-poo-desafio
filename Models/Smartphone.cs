using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal TamanhoTela { get; set; }

        public Smartphone(string numero, string marca, string modelo, decimal tamanhoTela)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            TamanhoTela = tamanhoTela;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
