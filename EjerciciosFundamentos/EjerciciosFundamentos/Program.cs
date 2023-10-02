using EjerciciosFundamentos;


//Ejercicio 1
//Console.WriteLine("Ejercicio 1: \n\tEstado: {0}", Utilidades.ejercicio1(int.Parse(Console.ReadLine())) ? "Aprobado" : "Suspenso");

//Ejercicio 2
//Console.WriteLine("Ejercicio 2: \n\tTipo de número: {0}", Utilidades.ejercicio2(int.Parse(Console.ReadLine())) ? "Número par" : "Número impar");

//Ejercicio 3.1
/*Console.WriteLine("Inserte los valores de inicio y fin de la operación");
int i = int.Parse(Console.ReadLine()), f = int.Parse(Console.ReadLine());
var (suma, promedio) = Utilidades.ejercicio3A(i, f);
Console.WriteLine("Ejercicio 3.1 \n\tLa suma del rango es: {0} \n\tEl promedio es: {1}", suma, promedio);

//Ejercicio 3.2
var (suma2, promedio2) = Utilidades.ejercicio3B(i, f);
Console.WriteLine("Ejercicio 3.2 \n\tLa suma del rango es: {0} \n\tEl promedio es: {1}", suma2, promedio2);

//Ejercicio 3.3
var (suma3, promedio3) = Utilidades.ejercicio3C(i, f);
Console.WriteLine("Ejercicio 3.3 \n\tLa suma del rango es: {0} \n\tEl promedio es: {1}", suma3, promedio3);

//Ejercicio 3.4
var (suma4, promedio4) = Utilidades.ejercicio3D(i, f);
Console.WriteLine("Ejercicio 3.4 \n\tLa suma del rango es: {0} \n\tEl promedio es: {1}", suma4, promedio4);

//Ejercicio 3.5
var (suma5, promedio5) = Utilidades.ejercicio3E(i, f);
Console.WriteLine("Ejercicio 3.5 \n\tLa suma del rango es: {0} \n\tEl promedio es: {1}", suma5, promedio5);

//Ejercicio 3.6
var (suma6, promedio6) = Utilidades.ejercicio3F(i, f);
Console.WriteLine("Ejercicio 3.6 \n\tLa suma del rango es: {0} \n\tEl promedio es: {1}", suma6, promedio6

//Ejercicio 4
int limit = 50000;
double h1 = Utilidades.ejercicio4(limit);
double h2 = Utilidades.ejercicio4R(limit);
Console.WriteLine("Ejercicio 4 \n\tEl resultado de la suma es: {0} \n\tEl resultado de la suma a la inversa es: {1}", h1, h2);
//Hay una diferencia de 1.5*10^-14 entre las 2 operaciones);

//Ejercicio 5
int rep = 1000000;
Console.WriteLine("Ejercicio 5\n\tEl resultado de pi con {0} términos utilizados es: {1}", rep, Utilidades.ejercicio5(rep));

//Ejercicio 6
int n = 20;
Console.WriteLine("Ejercicio 6\n\tLos primeros {0} números tribonacci son: \n\t{1}", n, Utilidades.leerArray(Utilidades.ejercicio6(n)));

//Ejercicio 7
Console.WriteLine("Ejercicio 7\n");
Utilidades.ejercicio7A();

//Ejercicio 8 
Console.WriteLine("Ejercicio 8\nIndique el radio de la esfera en metros.");
double radio = Utilidades.leerDoubleConsola();
double[] solution = Utilidades.ejercicio8(radio);
Console.WriteLine("\n\tEl volumen de la esfera es: {0} m3\n\tEl area de la esfera es: {1} m2", solution[0], solution[1]);

//Ejercicio 9
Console.WriteLine("Ejercicio 9\nIndique una cadena de caracteres:");
string s = Utilidades.leerConsola();
Console.WriteLine("\tLa cadena {0} al revés es: {1}", s, Utilidades.ejercicio9(s));

//Ejercicio 10
Console.WriteLine("Ejercicio 10\nIndique una cadena de caracteres para comprobar si es palíndroma:");
string s = Utilidades.leerConsola();
Console.WriteLine("La cadena {0} {1} es palíndroma", s, Utilidades.ejercicio10(s)? "si" : "no");

//Ejercicio 11
Console.WriteLine("Ejercicio 11\nIndique un numero binario a transformar al sistema decimal:");
string s = Utilidades.leerConsola(); 
int n = Utilidades.ejercicio11(s);

Console.WriteLine("\tEl número binario {0} convertido a decimal es: {1}", s, n);*/

//Ejercicio 12
Console.WriteLine("Ejercicio 12\nIndique un numero hexadecimal a transformar al sistema decimal:");
string s = Utilidades.leerConsola();
int n = Utilidades.ejercicio12(s);

Console.WriteLine("\tEl número hexadecimal {0} convertido a decimal es: {1}", s, n);