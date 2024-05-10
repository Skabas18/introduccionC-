// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido, calculemos círculos!");
//Pi * radio*radio

var resultado = 0d; //Forma de indicarle a c# que es un valor de tipo double

Console.WriteLine("Ingrese el valor del radio");
var radio=Convert.ToDouble(Console.ReadLine());

resultado = Math.PI * radio * radio;
Console.WriteLine("El área de tu círculo es de: "+ resultado);