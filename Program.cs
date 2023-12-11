using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia("123456789", "Nokia S10", "11111111111", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine(Environment.NewLine);

Console.WriteLine("Smartphone Iphone");
var iphone = new Iphone("987654321", "Iphone 6", "444444444", 8);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
