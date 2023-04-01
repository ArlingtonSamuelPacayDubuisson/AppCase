// See https://aka.ms/new-console-template for more information
//Variables
int option;
double A;
double B;
double resultado;
string mensaje;

//Dibujar menu
console.WriteLine("--CALCULADORA--");
console.WriteLine("1. Sumar.");
console.WriteLine("2. Restar.");
console.WriteLine("3. Multiplicar.");
console.WriteLine("4. Dividir.");
console.WriteLine("5. Elevar a la potencia.");
console.WriteLine("Selecccione una opcion (1 - 5): ");


//Guardar Variable
option = int.Parse(console.Readline());
//ahora pedimos los dos numeros
console.Write(Console.Readline());
console.Write("Ingrese el primer numero: ");
A = double.Parse(console.Readline());
console.Write("Ingrese el segundo numero: ");
B = double.Parse(console.Readline());

