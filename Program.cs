using DesafioPOO.Models;

Console.WriteLine("testando o nokia");
Smartphone nokia = new Nokia("95877-8874","A22","ABC2335424",124);
nokia.InstalarAplicativo("facebook");

Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("testando o Iphone");
Smartphone iphone = new Iphone("95622-6798","8s","ADC1213412",248);
iphone.InstalarAplicativo("twiter");

// TODO: Realizar os testes com as classes Nokia e Iphone