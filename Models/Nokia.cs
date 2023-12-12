namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando {aplicativo} no Nokia...");
        }
    }
}
