using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero :"31 - 123456789", modelo: "Nokia Lumia 410", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.VinculandoNumero();
nokia.InformandoMemoria();


Console.WriteLine("\n");

Console.WriteLine("Smartphone Ihpone");
Smartphone iphone = new Iphone(numero :"21 - 975612461", modelo: "Iphone 11", imei: "987456321", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.VinculandoNumero();
iphone.InformandoMemoria();
iphone.ReceberLigacao();
