using SymetriskKrytpering;

var gui = new GUI();

Console.WriteLine("Velkommen til min kryptering");
Console.WriteLine("Vælg et af følgende tal for krypteringsmetode:");
Console.WriteLine("1) AES");
Console.WriteLine("2) DES");
Console.WriteLine("3) 3DES");

var userCoise = Console.ReadLine();

if (userCoise == "1"){gui.AES();}
if (userCoise == "2"){gui.DES();}
if (userCoise == "3"){gui.TripleDES();}
else{  }
