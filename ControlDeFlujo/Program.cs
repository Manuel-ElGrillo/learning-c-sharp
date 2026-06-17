// If Else
int temperatura = 9;

Console.WriteLine("--- IF Else ---");

if (temperatura > 30)
{
    Console.WriteLine("Hace calor LPM!!!!");
}
else if (temperatura > 20)
{
    Console.WriteLine("No está tan mal aquí.");
}
else
{
    Console.WriteLine("Ta frío :3");
}

// Switch
string diaDeLaSemana = "Sábado";

Console.WriteLine("--- Switch ---");

switch (diaDeLaSemana)
{
    case "Lunes":
    case "Martes":
    case "Miércoles":
    case "Jueves":
    case "Viernes":
        Console.WriteLine("Hoy se labura!");
        break;
    case "Sábado":
    case "Domingo":
        Console.WriteLine("Descansito :3");
        break;
    default:
        Console.WriteLine("Feriado u otra vaina.");
        break;
}

// Switch expression
Console.WriteLine("--- Switch Expression ---");

string resultado = diaDeLaSemana switch
{
    "Sábado" or "Domingo" => "Fin de semana",
    "Lunes" or "Martes" or "Miércoles" or "Jueves" or "Viernes" => "Hoy se labura",
    _ => "Cualquier vaina feriada" // acá se usó el guión bajo _
}; // Interesante que aquí se termine con ; 

Console.WriteLine(resultado);

//For
Console.WriteLine("--- For ---");

for (int indice = 1; indice <= 5; indice++)
{
    Console.WriteLine($" Indice: {indice}");
}

// While
Console.WriteLine("--- While ---");

int intentosRestantes = 3;

while (intentosRestantes > 0)
{
    Console.WriteLine($"Intentos restantes: {intentosRestantes}");
    intentosRestantes--;
}

// Do while
Console.WriteLine("--- Do While ---");

int opcion;

do
{
    Console.WriteLine("Ingresá un número entre 1 y 3:");
    opcion = int.Parse(Console.ReadLine()!);
}
while (opcion < 1 || opcion > 3);

Console.WriteLine($"Elegiste: {opcion}");

// ── FOREACH ───────────────────────────────────────────────────
Console.WriteLine("--- For Each ---");

string[] diasLaborales = { "lunes", "martes", "miércoles", "jueves", "viernes" };

foreach (string dia in diasLaborales)
{
    Console.WriteLine($"Día laboral: {dia}");
}

// ── BREAK Y CONTINUE ──────────────────────────────────────────
Console.WriteLine("--- Break y Continue ---");

for (int numero = 1; numero <= 10; numero++)
{
    if (numero == 5)
        continue;   // saltea el 5 y sigue

    if (numero == 8)
        break;      // para el loop en el 8

    Console.WriteLine($"Procesando: {numero}");
}