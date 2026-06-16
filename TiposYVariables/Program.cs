// Tipos de valor
int edad = 22;
double precio = 19.99; //Este es el tipo de dato decimal por defecto en C#
float temperatura = 7.4f; //La f es obligatoria para los float
bool isActive = true; 
char inicial = 'G'; //Va con comillas simples

// Tipos de referencia
string nombre = "Ada"; //Con comillas dobles
string? alias = null;  //El "?" porque puede ser null o que "Este valor podría no existir"

// Constantes
const double Pi = 3.14159;
const int INTENTOS_MAXIMOS = 3;

// Inferencia de tipos
var ciudad = "Santiago"; // El compilador deduce que es un string
var year = 2026; // El compilador deduce que es un int

// Imprimir en consola
Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Ciudad: {ciudad}");
Console.WriteLine($"Pi: {Pi}, Cantidad de intentos: {INTENTOS_MAXIMOS}");

// Conversiones
string numeroComoTexto = "42";
int parseo = int.Parse(numeroComoTexto);
Console.WriteLine($"Número parseado a int: {parseo}");

bool exito = int.TryParse("abc", out int resultado); // versión segura, no lanza excepción
Console.WriteLine($"TryParse exitoso: {exito}, resultado: {resultado}");

double precioConDecimal = 9.99;
int precioTruncado = (int)precioConDecimal; // cast explícito, pierde el decimal
Console.WriteLine($"Cast explícito de {precioConDecimal}: {precioTruncado}");