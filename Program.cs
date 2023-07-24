using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(numero: 12345, modelo: "Lumia", imei:  655464, memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
Console.WriteLine("");
Smartphone iphone = new Iphone(numero: 546565, modelo: "Iphone12", imei: 6616226, memoria: 126);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");