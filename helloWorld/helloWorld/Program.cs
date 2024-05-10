//Programa que calcula el área de un rectángulo.
var ladoA = 0d;
var ladoB = 0d;
var resultado = 0.0;

Console.WriteLine("Calcula el área de un rectángulo!!");
Console.WriteLine("Ingrese el valor del lado A");
ladoA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Calcula el área de un rectángulo!!");
Console.WriteLine("Ingrese el valor del lado B");
ladoB = Convert.ToDouble(Console.ReadLine());

ladoA++; //Operador artimetico para incrementar
ladoA--;//Operador artimetico para decrementar

resultado = ladoA * ladoB;

Console.WriteLine("El resultado es: " + resultado);