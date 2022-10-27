using DesafioPOO.Models;

Iphone iphone = new Iphone(numero: "123", modelo: "Iphone 7", imei: "321", memoria: 32);
Console.WriteLine($"Modelo:{iphone.Modelo}, Numero:{iphone.Numero}, Memoria:{iphone.Memoria}GB, Imei:{iphone.IMEI}");
iphone.InstalarAplicativo("Whatsapp");
iphone.Ligar();

Nokia nokia = new Nokia(numero: "54321", modelo: "Nokia C20", imei: "12345", memoria: 32);
Console.WriteLine($"Modelo:{nokia.Modelo}, Numero:{nokia.Numero}, Memoria:{nokia.Memoria}GB, Imei:{nokia.IMEI}");
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();
