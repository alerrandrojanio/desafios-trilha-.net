using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(88) 9988-7766", "Tijolão", "00000000", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Iphone iphone = new Iphone("(88) 1122-3344", "iPhone 11", "1111111", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("facebook");


