using DesafioPOO.Models;

public class iphone()
{
    public string Numero { get; set; }
    public string Modelo { get; set; }
    public string IMEI { get; set; }
    public int Memoria { get; set; }

    public override void InstalarAplicativo (string nomeApp)
    {
        // Implementação do método InstalarAplicativo para iPhone
        // Aqui você pode adicionar a lógica específica para instalar um aplicativo em um iPhone
        Console.WriteLine($"Instalando {nomeApp} no iPhone.");
    }
}
