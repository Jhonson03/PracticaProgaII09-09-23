// Practica

String[] Frutas = { "Melon", "Fresa", "Manzana", "Guayaba", "Uva" };

var Orden = from x in Frutas select x;

Console.WriteLine(string.Join(" ", Orden));

/**************************************************************/

IEnumerable<string> OrdenAscendente = from x in Frutas orderby x select x;

Console.WriteLine($"Ascendente: {string.Join(" ", OrdenAscendente)}");

IEnumerable<string> OrdenDescendente = from x in Frutas orderby x descending select x;

Console.WriteLine($"Descendente: {string.Join(" ", OrdenDescendente)}");

IEnumerable<string> Finalice = from x in Frutas where x.EndsWith("na") select x;
Console.WriteLine($"Finalice: {string.Join(" ", Finalice)}");

