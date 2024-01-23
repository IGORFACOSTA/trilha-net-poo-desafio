sing DesafioPOO.Models;

public class Nokia : Smartphone
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    public override void InstalarAplicativo(string nomeApp)
    {
        // Implementação do método InstalarAplicativo para Nokia
        // Aqui você pode adicionar a lógica específica para instalar um aplicativo em um Nokia
        Console.WriteLine($"Instalando {nomeApp} no Nokia.");
    }
}