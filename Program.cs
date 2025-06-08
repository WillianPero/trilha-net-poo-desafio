using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Criando instâncias dos smartphones
        Smartphone iphone = new Iphone("123456789", "iPhone 13", "IMEI123456", 128);
        Smartphone nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654", 32);

        // Testando funcionalidades básicas
        Console.WriteLine("Testando iPhone:");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\nTestando Nokia:");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
    }
}
