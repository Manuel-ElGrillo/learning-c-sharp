// Método básico sin retorno

void SaludarUsuario(string nombre) {
    Console.WriteLine($"Hola, {nombre}");
}

SaludarUsuario("Individuo");

// Método con retorno

int Suma(int num1, int num2){
    return num1 + num2;
}

int resultado = Suma(3, 9);
Console.WriteLine($"Resultado = {resultado}");

// Parámetros opcionales y un valor por defecto

void mostrarMensaje(string msj, int repeticiones = 1){
    for (int i = 0; i < repeticiones; i++)
    {
        Console.WriteLine(msj);
    }
}

mostrarMensaje("Mensaje 1"); // Muestra por defecto 1 sola vez
mostrarMensaje("Mensaje 2", 3); // Muestra el mensaje 3 veces

// Parámetros con nombre (named arguments)

void crearUsuario(string nombre, int edad, string ciudad){
    Console.WriteLine($"Usuario: {nombre}, {edad} años, reside en {ciudad}");
}

crearUsuario(nombre: "Mateo", edad: 28, ciudad: "Chiuahua"); // El orden es libre, no importa cómo estén los parámetros

// Paso por valor

void intentarDuplicar(int numero) {
    numero = numero * 2; // No afecta a la variable original
}

int variableOriginal = 10;
intentarDuplicar(variableOriginal);
Console.WriteLine($"Como queda la variable original después de que pasa por la función: {variableOriginal}"); //10

// Paso por referencia "ref"

void duplicarPorReferencia(ref int numero) {
    numero = numero * 2; // Esto sí afecta el valor original de la variable
}

int variableOriginalDos = 10;
duplicarPorReferencia(ref variableOriginalDos);
Console.WriteLine($"Variable después de pasarlo como referencia: {variableOriginalDos}"); //20

// "out" para devolver valores adicionales

bool intentarDividir(int dividendo, int divisor, out int resultado) {
    if(divisor == 0) {
        resultado = 0;
        return false;
    }

    resultado = dividendo / divisor;
    return true;
}

bool divisionExitosa = intentarDividir(10, 2, out int resultadoDivision);
Console.WriteLine($"¿Exitosa? {divisionExitosa} - resultado: {resultadoDivision}"); //true, 5

bool divisionFallida = intentarDividir(10, 0, out int resultadoFallido);
Console.WriteLine($"¿Exitosa? {divisionFallida} - resultado: {resultadoFallido}"); //false, 0 porque se igualó el resultado a 0 en la función

// Paso de tipos de referencia (listas, arrays)

void AgregarTarea(List<string> tareas, string nuevaTarea) {
    tareas.Add(nuevaTarea); // Modifica la lista original directamente porque las listas son una referencia
}

List<string> tareasPendientes = new List<string> {"Estudiar C#"};
AgregarTarea(tareasPendientes, "Ir a entrenar");

Console.WriteLine($"Cantidad de tareas agregadas: {tareasPendientes.Count}");
foreach (string tarea in tareasPendientes)
{
    Console.WriteLine($"Tarea pendiente: {tarea}");
}

// Sobrecarga de métodos

int Multiplicar(int n1, int n2) {
    return n1 * n2;
}

double Multiplicar(double n1, double n2) {
    return n1 * n2;
}

Console.WriteLine($"Multiplicación de enteros: {Multiplicar(2,3)}");
Console.WriteLine($"Multiplicación de decimales: {Multiplicar(2.0, 3.5)}");

// Se pueden tener varios métodos con el mismo nombre si difieren de en la cantidad o en el tipo de los parámetros
// La sobrecarga solo funciona dentro de las clases y no como funciones locales