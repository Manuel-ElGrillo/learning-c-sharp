// Arrays

// Tamaño fijo y es definido al crearlo. No se pueden agregar o quitar elementos
Console.WriteLine("--- Array de tamaño fijo ---");
int[] numeros = {10, 20, 30, 40, 50};

Console.WriteLine($"Primer elemento: {numeros[0]}");
Console.WriteLine($"Cantidad de elementos: {numeros.Length}");

numeros[2] = 99; // Es posible modificar un elemento
Console.WriteLine($"Indice modificado: {numeros[2]}");

// Array vacío pero de tamaño fijo
Console.WriteLine("--- Arrays vacíos pero con tamaño fijo ---");
string[] nombres = new string[3];

nombres[0] = "Ana";
nombres[1] = "Lucille";
nombres[2] = "Sofía";

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

//LIST<T> - La <T> es de Type :)
//El tamaño de las listas es dinámico
Console.WriteLine("--- Listas<T> ---");
List<string> tareasPendientes = new List<string>();

tareasPendientes.Add("Estudiar C#");
tareasPendientes.Add("Cocinar");
tareasPendientes.Add("Hacer ejercicio");
Console.WriteLine($"Cantidad de tareas: {tareasPendientes.Count}");

tareasPendientes.Remove("hacer ejercicio"); // Es case sensitive así que no se remueve la tarea
Console.WriteLine($"Cantidad de tareas: {tareasPendientes.Count}"); // 3

bool contieneTarea = tareasPendientes.Contains("Cocinar");
Console.WriteLine($"¿Existe la tarea para hacer comida? - Respuesta: {contieneTarea}");

foreach (string tarea in tareasPendientes)
{
    Console.WriteLine($"Tarea pendiente por hacer: {tarea}");
}

// Inicialización de una Lista con valores
Console.WriteLine("--- Inicialización de una Lista con valores ---");

List<int> numerosRandom = new List<int> {12 , 234 ,45, 78231, 135, 092};
numerosRandom.Sort();

foreach (int numero in numerosRandom)
{
    Console.WriteLine(numero);
}

// Diccionarios<K,V> K = Key, V = Value
// Pares clave-valor. Acceso rápido por clave en vez de índice.
Console.WriteLine("--- Diccionarios ---");

Dictionary<string, int> inventario = new Dictionary<string, int>();

inventario.Add("Manzanas", 50);
inventario.Add("Bananas", 30);
inventario.Add("Naranjas", 20);

Console.WriteLine($"Stock de manzanas: {inventario["Manzanas"]}");

inventario["Manzanas"] = 45; // Se puede modificar el valor

Console.WriteLine($"Stock actualizado de manzanas: {inventario["Manzanas"]}");

// Acceso seguro, evita una excepción si la clave no existe
bool tieneClave = inventario.TryGetValue("Peras", out int cantidadPeras);
Console.WriteLine($"¿Hay peras? R: {tieneClave}, cantidad: {cantidadPeras}");

// Recorriendo todo el diccoinario
foreach (KeyValuePair<string, int> producto in inventario)
{
    Console.WriteLine($"Producto: {producto.Key} - Cantidad: {producto.Value}");
}

// Recorriendo solo las claves o solo los valores
foreach (string nombreProducto in inventario.Keys)
{
    Console.WriteLine($"Clave: {nombreProducto}");
}