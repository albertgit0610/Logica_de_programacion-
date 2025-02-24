
// 1. Determinar si un número es positivo o negativo
using System.Diagnostics.CodeAnalysis;

Console.Write("Ingrese un número: ");
double num = double.Parse(Console.ReadLine()!);
if (num >= 0)
    Console.WriteLine("El número es positivo");
else
    Console.WriteLine("El número es negativo");

// 2. Determinar si ambos dígitos de un número de dos cifras son pares o impares
Console.Write("Ingrese un número de dos dígitos: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num2 >= 10 && num2 <= 99)
{
    int digi1 = num2 / 10;
    int digi2 = num2 % 10;

    if (digi1 % 2 == 0)
    {

        Console.Write("El 1er dígito es par, ");
    }
    else
    {
        Console.Write("El 1er dígito es impar, ");
    }
    if (digi2 % 2 == 0)
    {
        Console.WriteLine("el 2do dígito es par");
    }
    else
    {
        Console.WriteLine("el 2do dígito es impar");
    }
}



// 3. Suma de los dos dígitos de un número de dos cifras
Console.Write("Ingrese un número de dos dígitos: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero >= 10 && numero <= 99)
{
    int digito1 = numero / 10;
    int digito2 = numero % 10;
    int suma = digito1 + digito2;

    Console.WriteLine("La suma de los dígitos de " + numero + "es: " + suma);
}
else
{
    Console.WriteLine("El numero ingresado no es de dos dijito. " + numero);
}
// 4. Verificar si los dos dígitos de un número de dos cifras son iguales

Console.Write("Ingrese un numero de dos digitos ");
int nume = int.Parse(Console.ReadLine()!);

if (nume >= 10 && nume <= 99)
{
    int digt1 = nume / 10;
    int digt2 = nume % 10;

    if (digt1 == digt2)
    {
        Console.WriteLine("Los dígitos son iguales.");
    }
    else
    {
        Console.WriteLine("Los dígitos son diferentes.");
    }
}
else
{
    Console.WriteLine("El número ingresado no es de dos dígitos.");
}

// 5. Determinar el mayor entre dos números
Console.Write("Ingrese el primer número: ");
int n1 = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el segundo número: ");
int n2 = int.Parse(Console.ReadLine()!);

if (n1 > n2)
    Console.WriteLine("El mayor es " + n1);
else
    Console.WriteLine("El mayor es " + n2);

// 6. Verificar si la suma de dos números es par o impar
Console.Write("Ingrese el prirmer numero ");
int N1 = int.Parse(Console.ReadLine()!);
Console.Write("Ingrese el segundo numero ");
int N2 = int.Parse(Console.ReadLine()!);

int sumar = N1 + N2;

if (sumar % 2 == 0)
    Console.WriteLine("La suma es par");
else
    Console.WriteLine("La suma es impar");


// 7. Validar un número de tres dígitos y calcular la suma de sus dígitos

Console.Write("Ingrese un número de tres dígitos: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num3 >= 100 && num3 <= 999)
{
    int Digito1 = num3 / 100;
    int Digito2 = (num3 / 10) % 10;
    int Digito3 = num3 % 10;
    int suma = Digito1 + Digito2 + Digito3;

    Console.WriteLine("La suma de los dígitos es:" + suma);
}
else
    Console.WriteLine("Número inválido. Debe tener tres dígitos.");

// 8. Determinar si un número es múltiplo de 6
Console.Write("Ingrese un número: ");
int num4 = int.Parse(Console.ReadLine()!);
if (num4 % 6 == 0)
    Console.WriteLine("El número es múltiplo de 6");
else
    Console.WriteLine("El número no es múltiplo de 6");

// 9. Determinar si un dígito es múltiplo del otro en un número de dos cifras
Console.Write("Ingrese un numero de dos digitos: ");
int NUm = Convert.ToInt32(Console.ReadLine()!);

int dig1 = NUm / 10;
int dig2 = NUm % 10;

if (dig1 % dig2 == 0 || dig2 % dig1 == 0)
    Console.WriteLine("Un dígito es múltiplo del otro");
else
    Console.WriteLine("Ningún dígito es múltiplo del otro");

// 10. Ordenar tres números de menor a mayor
Console.Write("Ingresa el primer número: ");
int Num1 = int.Parse(Console.ReadLine()!);

Console.Write("Ingresa el segundo número: ");
int Num2 = int.Parse(Console.ReadLine()!);

Console.Write("Ingresa el tercer número: ");
int Num3 = int.Parse(Console.ReadLine()!);

int menor, medio, mayor;

if (Num1 <= Num2 && Num1 <= Num3)
{
    menor = Num1;
    if (Num2 <= Num3)
    {
        medio = Num2;
        mayor = Num3;
    }
    else
    {
        medio = Num3;
        mayor = Num2;
    }
}
else if (Num2 <= Num1 && Num2 <= Num3)
{
    menor = Num2;
    if (Num1 <= Num3)
    {
        medio = Num1;
        mayor = Num3;
    }
    else
    {
        medio = Num3;
        mayor = Num1;
    }
}
else
{
    menor = Num3; 
    if (Num1 <= Num2)
    {
        medio = Num1;
        mayor = Num2;
    }
    else
    {
        medio = Num2;
        mayor = Num1;
    }
}

// Corrección en la impresión
Console.WriteLine("Orden ascendente: " + menor + ", " + medio + ", " + mayor);


// 11. Determinar si el primer y el último dígito de un número de tres cifras son iguales

Console.Write("Ingrese un numero de tres digitos");
int NUm3 = int.Parse(Console.ReadLine()!);
if (NUm3 <= 100 && NUm3 >= 999)
{

    int d1 = NUm3 / 100;
    int d2 = NUm3 % 10;

    if (d1 == d2)
    {
        Console.WriteLine("El primer y último dígito son iguales");
    }
    else
    {
        Console.WriteLine("El primer y último dígito son diferentes");
    }
}
else
{
    Console.WriteLine("El numero ingresado no es de 3 digitos");
}
// 12. Clasificar la edad del usuario
Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine()!);
if (edad > 50)
    Console.WriteLine("Abuelo");
else if (edad > 30)
    Console.WriteLine("Padre");
else
    Console.WriteLine("Hijo");




















































