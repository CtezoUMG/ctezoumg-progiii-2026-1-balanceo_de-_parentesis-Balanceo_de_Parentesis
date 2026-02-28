using System;

/* Instrucciones:
   - Solo puedes programar dentro de los métodos indicados.
   - No cambies el nombre de la clase ni de los métodos existentes.
   - La Pila debe trabajar con nodos (memoria dinámica).
*/
public class Pila
{
    private class Nodo
    {
        public char info;
        public Nodo sig;
    }

    private Nodo? raiz;

    public void Insertar(char x)
    {
        // TODO: Programar lógica para insertar un nodo al principio (Push)
        // El alumno debe implementar la gestión de memoria aquí
    }

    public char Extraer()
    {
        // TODO: Programar lógica para extraer el nodo superior (Pop)
        // Debe retornar '\0' si la pila está vacía
        return '\0';
    }

    public bool EstaVacia() => raiz == null;

    // --- EL RETO PARA EL ALUMNO ---
    public bool ValidarMatematica(string expresion)
    {
        /* RETO:
        // Deben ignorar números, letras y operadores.
        // Solo deben usar la Pila para (, [, {, }, ], )
        */

        return false;
    }
}
