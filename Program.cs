using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "88442222", modelo: "Modelo 1", imei: "1111111111", memoria: 64);
Console.WriteLine($"Numero: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "99553333", modelo: "Modelo 13", imei: "2222222222", memoria: 64);
Console.WriteLine($"Numero: {iphone.Numero}");
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");