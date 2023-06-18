using Projeto_POO_Celular.Models;

Console.WriteLine("Telefone Nokia:");
Smartphone nokia = new Nokia("99730924", "top", "12345", 125);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Telefone Iphone");
Smartphone iphone = new Iphone("987567546", "6s", "46813", 68);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");
