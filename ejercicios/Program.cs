#region Ejericio 1
/*
Dado un valor, devolver un mensaje que diga “El valor es mayor que 100”
sólo cuando se cumpla dicha condición.
Entrada: valor numérico entero
Restricción: en caso de ser mayor a 100 visualizar mensaje
Salida: Mensaje "El valor es mayor que 100"
 */
//Console.WriteLine("********** Ejericio 1 **********");
////int valor = 66;
//int num1 = 150;
//if (num1 > 100)
//{
//    Console.WriteLine("El valor es mayor que 100");
//}
#endregion

#region Ejericio 2
/*
 Pedir un número entero por teclado y calcular si es par o impar.
Entrada: Valor numérico entero ingresado por teclado
Resctricción:
Salida: Informar si el valor ingresado es par o impar
 */
//int num2;
//Console.WriteLine("********** Ejericio 2 **********");
//Console.WriteLine("Ingrese un valor numérico entero: ");
//var option2 = Console.ReadLine(); 
//Int32.TryParse(option2, out num2);
//if ((num2 % 2) == 0)
//        Console.WriteLine("ES PAR");
//    else
//        Console.WriteLine("ES IMPAR");
#endregion

#region Ejericio 3
/*
Teniendo un valor entero, verificar si se cumple o no que ese valor es el doble
de un impar. Por ejemplo, 14 cumple con esta condición.
*/
//int num3 = 8; //no
//int num3 = 14;
//int cociente;
//Console.WriteLine("********** Ejericio 3 **********");
//cociente = num3 / 2;
//if ((cociente % 2) == 0)
//    Console.WriteLine("No es doble de un impar");
//else
//    Console.WriteLine("Es doble de un impar");
#endregion

#region Ejercicio 4
/*
Dado un número del 1 al 10, devolver su “versión” en números romanos.
*/
//int num4;
//Console.WriteLine("********** Ejericio 4 **********");
//Console.WriteLine("Ingrese un valor numérico entero del 1 al 10: ");
//var option4 = Console.ReadLine();
//Int32.TryParse(option4, out num4);
//switch (num4)
//{
//    case 1:
//        Console.WriteLine("Su correspondiente número romano es: I");
//        break;
//    case 2:
//        Console.WriteLine("Su correspondiente número romano es: II");
//        break;
//    case 3:
//        Console.WriteLine("Su correspondiente número romano es: III");
//        break;
//    case 4:
//        Console.WriteLine("Su correspondiente número romano es: IV");
//        break;
//    case 5:
//        Console.WriteLine("Su correspondiente número romano es: V");
//        break;
//    case 6:
//        Console.WriteLine("Su correspondiente número romano es: VI");
//        break;
//    case 7:
//        Console.WriteLine("Su correspondiente número romano es: VII");
//        break;
//    case 8:
//        Console.WriteLine("Su correspondiente número romano es: VIII");
//        break;
//    case 9:
//        Console.WriteLine("Su correspondiente número romano es: IX");
//        break;
//    case 10:
//        Console.WriteLine("Su correspondiente número romano es: X");
//        break;
//    default:
//        Console.WriteLine("Ingrese un valor dentro del rango 1 al 10");
//        break;
//}
#endregion

#region Ejercicio 5 
/*
Leer el nombre y las edades de dos personas y devolver el nombre del menor.
En caso de que tengan la misma edad también debe indicarse.
Devolver también la diferencia de edad en caso de corresponder.
 */
//string nombre1;
//string nombre2;
//int edad1;
//int edad2;
//Console.WriteLine("********** Ejericio 5 **********");
//Console.WriteLine("Ingrese nombre y edad de la persona 1: ");
//nombre1 = Console.ReadLine();
//var opt1 = Console.ReadLine();
//Int32.TryParse(opt1, out edad1);
//Console.WriteLine("Ingrese nombre y edad de la persona 2: ");
//nombre2 = Console.ReadLine();
//var opt2 = Console.ReadLine();
//Int32.TryParse(opt2, out edad2);
//if(edad1 == edad2)
//{
//    Console.WriteLine(nombre1 + " y " + nombre2 + " tienen la misma edad.");
//}else if (edad1 < edad2)
//{
//    Console.WriteLine("La persona de menor edad es: " + nombre1 + ". Con una diferencia de "+ (edad2-edad1)+" años.");
//}
//else
//{
//    Console.WriteLine("La persona de menor edad es: " + nombre2 + ". Con una diferencia de " + (edad1 - edad2) + " años.");
//}
#endregion

#region Ejercicio 6
/*
Escribir un programa que calcule el tipo de un triángulo conociendo la longitud de sus 3 lados. 
También que calcule su perímetro y su área.

Si los tres lados son iguales, se trata de un triángulo equilátero
Si los tres lados no son iguales entre sí, es un triángulo escaleno
Si dos de sus lados son iguales es un triángulo isósceles
perimetro = l + l + l
area = √((a+b+c)/2·((a+b+c)/2-a)·((a+b+c)/2-b)·((a+b+c)/2-c)) //teniendo sus lados no base ni altura
 */
//float a;
//float b;
//float c;
//double perimetro;
//float area;
//Console.WriteLine("********** Ejericio 6 **********");
//Console.WriteLine("Ingrese primer lado: ");
//var lado1 = Console.ReadLine();
//float.TryParse(lado1, out a);
//Console.WriteLine("Ingrese segundo lado: ");
//var lado2 = Console.ReadLine();
//float.TryParse(lado2, out b);
//Console.WriteLine("Ingrese tercer lado: ");
//var lado3 = Console.ReadLine();
//float.TryParse(lado3, out c);      
//if (a <= 0 || b<=0 || c <= 0)
//{
//    Console.WriteLine("Ingrese valores positivos : ");
//}
//else
//{
//    area = a + b + c;
//    perimetro = Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
//    if (a == b && b == c)
//       Console.WriteLine("Es un triangulo Equilátero");
//    else if (a == b || a == c || b == c)
//        Console.WriteLine("Es un triangulo Isósceles");
//    else
//        Console.WriteLine("Es un triangulo Escaleno");
//    Console.WriteLine("Area: " + area);
//    Console.WriteLine("Perímetro: " + perimetro); //NaN ¿?
//}

#endregion

#region Ejercicio 7
/*Desarrolle un programa que calcule el desglose de una cantidad dada, en billetes y monedas tal que se minimice la cantidad de monedas y billetes.
Considere las denominaciones $1000, $500, $100, $50, $20, $10, $5, $2, $1,donde los últimos tres son monedas. 
(Por ejemplo, para $1,723 se debe imprimir: “1 billete de $1000, 1 billete de $500, 1 billete de $200, 1 billete de
$20, 1 moneda de $2, 1 moneda de $1). Obviar los signos de billete ($) y tratar todos los valores como números, para los cálculos.*/
//int monto;//por ej. 1723
//int billetes_de_1;
//int billetes_de_mil;
//int billetes_de_quinientos;
//int billetes_de_doscientos;
//int billetes_de_cien;
//int billetes_de_cincuenta;
//int billetes_de_veinte;
//int billetes_de_diez;
//int monedas_de_cinco, monedas_de_dos, monedas_de_uno;
//string cadena = "";

//Console.WriteLine("********** Ejericio 7 **********");
//Console.WriteLine("Ingrese el valor de cantidad de pesos: ");
//var dinero = Console.ReadLine();
//Int32.TryParse(dinero, out monto);
//billetes_de_1 = monto;
//billetes_de_mil = (billetes_de_1 - billetes_de_1 % 1000)/ 1000; // 1
//billetes_de_1 = billetes_de_1 % 1000; //723 
//billetes_de_quinientos = (billetes_de_1 - billetes_de_1 % 500) / 500; // 1
//billetes_de_1 = billetes_de_1 % 500;//223
//billetes_de_doscientos = (billetes_de_1 - billetes_de_1 % 200) / 200; // 1
//billetes_de_1 = billetes_de_1 % 200;//23
//billetes_de_cien = (billetes_de_1 - billetes_de_1 % 100) / 100; 
//billetes_de_1 = billetes_de_1 % 100;//
//billetes_de_cincuenta = (billetes_de_1 - billetes_de_1 % 50) / 50;
//billetes_de_1 = billetes_de_1 % 50;
//billetes_de_veinte = (billetes_de_1 - billetes_de_1 % 20) / 20;//1
//billetes_de_1 = billetes_de_1 % 20;
//billetes_de_diez = (billetes_de_1 - billetes_de_1 % 10) / 10; 
//billetes_de_1 = billetes_de_1 % 10;
//monedas_de_cinco = (billetes_de_1 - billetes_de_1 % 5) / 5;
//billetes_de_1 = billetes_de_1 % 5;
//monedas_de_dos = (billetes_de_1 - billetes_de_1 % 2) / 2;
//billetes_de_1 = billetes_de_1 % 2;
//monedas_de_uno = (billetes_de_1 - billetes_de_1 % 1) / 1;

//if (billetes_de_mil != 0)
//    cadena += billetes_de_mil + " billete/s de 1000";
//if(billetes_de_quinientos != 0)
//    cadena += ", "+billetes_de_quinientos + " billete/s de 500";
//if (billetes_de_doscientos != 0)
//    cadena += ", " + billetes_de_doscientos + " billete/s de 200";
//if (billetes_de_cien != 0)
//    cadena += ", " + billetes_de_cien + " ,billete/s de 100";
//if (billetes_de_cincuenta != 0)
//    cadena += ", " + billetes_de_cincuenta + " billete/s de 50";
//if (billetes_de_veinte != 0)
//    cadena += ", " + billetes_de_veinte + " billete/s de 20";
//if (billetes_de_diez != 0)
//    cadena += ", " + billetes_de_diez + " billete/s de 10";
//if (monedas_de_cinco != 0)
//    cadena += ", " + monedas_de_cinco + " moneda/s de 5";
//if (monedas_de_dos != 0)
//    cadena += ", " + monedas_de_dos + " moneda/s de 2";
//if (monedas_de_uno != 0)
//    cadena += ", " + monedas_de_uno + " moneda/s de 1.";

//Console.WriteLine(cadena);

#endregion

#region Ejercicio 8
/*
 Pide un número N, y muestra todos los números del 1 al N.
 */
//int n;
//Console.WriteLine("********** Ejericio 8 **********");
//Console.WriteLine("Ingrese un valor numérico entero: ");
//var option2 = Console.ReadLine();
//Int32.TryParse(option2, out n);
//for (int i = 1; i < n+1; i++)
//{
//    Console.WriteLine(i);
//}

#endregion

#region Ejercicio 9
/*
 Pedir 15 números y escribir la suma total.
 */
//int num;
//var total=0;
//Console.WriteLine("********** Ejericio 9 **********");
//for (int i = 0; i < 15; i++)
//{
//    Console.WriteLine("\nIngrese un valor numérico entero: ");
//    var opt = Console.ReadLine();
//    Int32.TryParse(opt, out num);
//    total += num;
//}
//Console.WriteLine("Suma total de los 15 valores: "+total);
#endregion

#region Ejercicio 10
/*Pide 5 números e indica si alguno es múltiplo de 3.*/
//int num;
//Console.WriteLine("********** Ejericio 10 **********");
//Console.WriteLine("\nIngrese cinco valores numéricos enteros: ");
//for (int i = 0; i < 5; i++)
//{

//    var opt = Console.ReadLine();
//    Int32.TryParse(opt, out num);
//    if(num % 3 == 0)
//    {
//        Console.WriteLine(num + " es múltiplo de 3 ");
//    }
//}

#endregion

#region Ejercicio 11
/*
 Escriba un programa que solicite una contraseña (el texto de la contraseña
no es importante) y la vuelva a solicitar hasta que las dos contraseñas
coincidan.
 */
//string pass = "miclave123";
//string mipass;
//bool acierto = false;
//Console.WriteLine("********** Ejericio 11 **********");
//while (acierto == false)
//{
//    Console.WriteLine("Ingrese la contraseña: ");
//    mipass = Console.ReadLine();
//    if (mipass == pass)
//    {
//        acierto = true;
//        Console.WriteLine("Contraseña CORRECTA!!");
//    }
//    else
//    {
//        Console.WriteLine("Contraseña INCORRECTA ");
//    }

//}
#endregion

#region Ejercicio 12
/*Mismo que el anterior pero con un límite de tres peticiones. Luego de las tres
peticiones no debe solicitar más la contraseña y terminar el programa.*/
//string pass = "miclave123";
//string mipass;
//bool acierto = false;
//int contador = 0;
//Console.WriteLine("********** Ejericio 12 **********");
//while (contador < 3 && acierto == false)
//{
//    Console.WriteLine("Ingrese la contraseña: ");
//    mipass = Console.ReadLine();
//    if (mipass == pass)
//    {
//        acierto = true;
//        Console.WriteLine("Contraseña CORRECTA!!");
//    }
//    else
//    {
//        Console.WriteLine("Contraseña INCORRECTA ");
//        contador++;
//    }
//    if (contador == 3 && acierto == false)
//    {
//        Console.WriteLine("Ya no Tienes más Intentos!");
//    }
//}
#endregion

#region Ejercicio 13
/*
 Proponer al usuario que adivine un número a base de intentarlo.
 */
//int numero = 123;
//int adivinaNumero;
//bool acierto = false;

//Console.WriteLine("********** Ejericio 13 **********");
//while (acierto == false)
//{
//    Console.WriteLine("Intente adivinar el número: ");
//    var numeroUser = Console.ReadLine();
//    Int32.TryParse(numeroUser, out adivinaNumero);
//    if (numero == adivinaNumero)
//    {
//        acierto = true;
//        Console.WriteLine("Haz adivinado!!");
//    }
//    else
//    {
//        Console.WriteLine("Vuelve a intentarlo");
//    }

//}
#endregion

#region Ejercicio 14
///*Modificar el programa anterior para que vaya dando pistas del tipo «mayor» o «menor».*/
//int numero = 123;
//int adivinaNumero;
//bool acierto = false;

//Console.WriteLine("********** Ejericio 14 **********");
//while (acierto == false)
//{
//    Console.WriteLine("Intente adivinar el número: ");
//    var numeroUser = Console.ReadLine();
//    Int32.TryParse(numeroUser, out adivinaNumero);
//    if (numero == adivinaNumero)
//    {
//        acierto = true;
//        Console.WriteLine("Haz adivinado!!");
//    }
//    else if (numero < adivinaNumero)
//    {
//        Console.WriteLine("Vuelve a intentarlo... una pista: el numero es más chico ;)");
//    }
//    else
//    {
//        Console.WriteLine("Vuelve a intentarlo... una pista: el numero es más alto ;)");
//    }

//}

#endregion

#region Ejercicio 15
/*Crea un programa que permita sumar N números. El usuario decide cuándo
termina de introducir números al indicar la palabra ‘fin’.*/
//var suma = 0;
//var num = 0;
//string opt;
//Console.WriteLine("********** Ejericio 15 **********");
//Console.WriteLine("\nIngrese valores a sumar: ");
//opt = Console.ReadLine();
//while (opt != "fin")
//{
//    int.TryParse(opt, out num);
//    suma += num;
//    opt = Console.ReadLine();

//}
//Console.WriteLine("Suma total de los valores: "+suma);
#endregion