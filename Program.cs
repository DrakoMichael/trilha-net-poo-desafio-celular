using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone Nokia: ");
Nokia nokia = new Nokia("123", "1111111", "modelo 1", 128);
nokia.InstalarAplicativo("WHATSAPP");
nokia.Ligar();

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("123", "222222222222", "modelo 2", 32);
iphone.InstalarAplicativo("WHATSAPP");
iphone.ReceberLigacao();