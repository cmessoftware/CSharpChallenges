
//defino variables.
float sueldo;
string linea;

//Muestro mensajes en consola.
Console.Write("Ingrese el sueldo:");
linea = Console.ReadLine();

//Transformo tipo string en float
sueldo = float.Parse(linea);

//Comparo
if (sueldo > 3000) //SI
{
    Console.Write("Esta persona debe abonar impuestos");
}
else //SINO
{
    Console.Write("Esta persona NO debe abonar impuestos");
}

//Espero que el usuario toque una tecla.
Console.ReadKey();
