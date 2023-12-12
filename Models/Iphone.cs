namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} no iPhone...");
        }
    }
}
