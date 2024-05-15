using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo numero 123", imei: "abs25364", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "4567895", modelo: "Modelo numero 250", imei: "ADF25364", memoria: 120);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
