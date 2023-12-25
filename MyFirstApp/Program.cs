// See https://aka.ms/new-console-template for more information
//rakendus palub kasutajal sisestada tema nime
//rakendus tervutab kasutajat nimepidi

Console.WriteLine("Enter your name:");
//string - sõne
string userName;

userName = Console.ReadLine(); /*input*/

Console.WriteLine("Hello" + "," + userName); /*output*/

//string - interpolation

Console.WriteLine($"Hello, {userName} !");



