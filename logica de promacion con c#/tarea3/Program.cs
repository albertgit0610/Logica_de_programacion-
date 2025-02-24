
// 1. Saludo al usuario
Console.WriteLine("1. Saludo al usuario");
Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine()!;
Console.WriteLine("Hola, " + nombre + "!");

// 2. Cálculo de perímetro y área de un rectángulo
Console.Write("Ingrese la base del rectángulo: ");
double baseRect = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la altura del rectángulo: ");
double alturaRect = Convert.ToDouble(Console.ReadLine());

double perimetro = 2 * (baseRect + alturaRect);
double area = baseRect * alturaRect;

Console.WriteLine("Perímetro: " + perimetro);
Console.WriteLine("Área: " + area);

// 3. Operaciones aritméticas
Console.Write("Ingrese el primer número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Suma: " + (num1 + num2));
Console.WriteLine("Resta: " + (num1 - num2));
Console.WriteLine("Multiplicación: " + (num1 * num2));
Console.WriteLine("División: " + (num1 / num2));

// 4. Conversión de Fahrenheit a Celsius
Console.WriteLine("Conversión de Fahrenheit a Celsius");
Console.Write("Ingrese los grados Fahrenheit: ");

double fahrenheit = Convert.ToDouble(Console.ReadLine());
double celsius = (fahrenheit - 32) * 5 / 9;
Console.WriteLine("Equivalente en Celsius: " + celsius);

// 5. Cálculo de la media
Console.Write("Ingrese un números: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese un números: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese un números: ");
double c = Convert.ToDouble(Console.ReadLine());

double promedio = (a + b + c) / 3;
Console.WriteLine("Promedio: " + (promedio));

// 6. Conversión de minutos a horas y minutos
Console.WriteLine("Conversión de minutos a horas y minutos");
Console.Write("Ingrese la cantidad de minutos: ");

int minutos = Convert.ToInt32(Console.ReadLine());
int horas = minutos / 60;
int minutosRestantes = minutos % 60;

Console.WriteLine(minutos + " minutos equivalen a ");
Console.WriteLine(horas + " horas y ");
Console.WriteLine(minutosRestantes + " minutos.");

// 7. Cálculo del salario con comisión
Console.Write("Ingrese el salario base del vendedor: ");
double salarioBase = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el monto total de ventas: ");
double ventas = Convert.ToDouble(Console.ReadLine());

double comision = ventas * 0.10;
double salarioTotal = salarioBase + comision;

Console.WriteLine("Comisión: " + comision);
Console.WriteLine(" Salario total: " + salarioTotal);

// 8. Cálculo de descuento en una compra
Console.Write("Ingrese el monto de la compra: ");

double montoCompra = Convert.ToDouble(Console.ReadLine());
double descuento = montoCompra * 0.15;
double precioFinal = montoCompra - descuento;

Console.WriteLine("Descuento: " + descuento + " Total a pagar: " + precioFinal);

// 9. Cálculo de la distancia absoluta entre dos números
Console.Write("Ingrese el primer número: ");
double numA = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
double numB = Convert.ToDouble(Console.ReadLine());

double distancia = Math.Abs(numA - numB);
Console.WriteLine("Distancia entre ellos: " + distancia);

// 10. Calcula Raíz cuadrada y cúbica de un numero 
Console.Write("Ingrese un número: ");
double Numero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(Numero));
Console.WriteLine("Raíz cúbica: " + Math.Cbrt(Numero));

// 11. Inversión de un número de dos cifras
Console.Write("Ingrese un número de dos cifras: ");

int numero = Convert.ToInt32(Console.ReadLine());
int invertido = (numero % 10) * 10 + (numero / 10);
Console.WriteLine("Número invertido: " + invertido);

// 12. Intercambio de valores entre dos variables
Console.Write("Ingrese el valor de A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el valor de B: ");
int B = Convert.ToInt32(Console.ReadLine());

(A, B) = (B, A);
Console.WriteLine("A: " + A + " B: " + B);

// 13. Iniciales de nombre y apellidos
Console.Write("Ingrese su nombre: ");
string primerNombre = Console.ReadLine()!;

Console.Write("Ingrese su primer apellido: ");
string apellido1 = Console.ReadLine()!;

Console.Write("Ingrese su segundo apellido: ");
string apellido2 = Console.ReadLine()!;

Console.WriteLine("Iniciales: " + primerNombre[0] + "." + apellido1[0] + "." + apellido2[0]);

