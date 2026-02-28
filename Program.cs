using System;

/* ADVERTENCIA: 
   Este archivo es utilizado por el Autograding de GitHub para calificar.
   No modifiques la lectura de datos ni la salida de consola, 
   de lo contrario tu nota podría ser 0.
*/

// 1. Lectura de la expresión matemática
string? entrada = Console.ReadLine();
if (string.IsNullOrWhiteSpace(entrada)) return;

// 2. Instancia de la clase del alumno
Pila sol = new Pila();

// 3. Ejecución de la lógica de validación
//Ejemplo entrada = ((a+b)*[c-d])
bool esValida = sol.ValidarMatematica(entrada);

// 4. Salida para Autograding: 
// GitHub comparará esta línea con el resultado esperado (true/false)
Console.WriteLine(esValida.ToString().ToLower());

/* NOTA DE RENDIMIENTO:
   El tiempo de ejecución y la memoria RAM consumida serán enviados 
   automáticamente al ranking de la clase. ¡Optimiza tu código!
*/
