using DesafioPOO.Models;

Console.WriteLine("Celular Nokia");
var nokia = new Nokia("123456", "modelo 1", "6542318", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n\n\n");

Console.WriteLine("Celular Iphone");
var iphone = new Iphone("456123", "modelo 2", "587984", 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");