# Reto: Validador de Expresiones con Pilas (Nodos) 🚀

Este proyecto consiste en implementar una **Pila dinámica basada en Nodos** para resolver un problema clásico de ciencias de la computación: el balanceo de signos de agrupación en expresiones matemáticas.

## 🎯 Objetivo
Desarrollar una solución eficiente que determine si una expresión matemática está correctamente balanceada en sus signos de agrupación: `()`, `[]` y `{}`.

## 📋 Instrucciones de Desarrollo

1.  **Clase `Pila.cs`**:
    * **`Insertar(char x)`**: Implementar la lógica de *Push* utilizando nodos.
    * **`Extraer()`**: Implementar la lógica de *Pop*. Debe retornar el carácter superior y mover el puntero.
    * **`ValidarMatematica(string expresion)`**: 
        * Recorrer la cadena una sola vez (O(n)).
        * Ignorar números, letras y operadores.
        * Utilizar la estructura de Pila para validar la jerarquía y el cierre de signos.

2.  **Restricciones Técnicas**:
    * **Prohibido** el uso de `System.Collections.Generic.Stack`.
    * **Prohibido** el uso de métodos de limpieza de strings como `Replace()`.
    * La gestión de memoria debe ser manual mediante la clase interna `Nodo`.

## ⚙️ Evaluación y Ranking

Al realizar un `git push`, GitHub evaluará automáticamente tu código con diferentes casos de prueba.

* **Puntuación**: Se basa en la exactitud de los resultados.
* **Ranking de Eficiencia**: Los mejores puestos en el Dashboard de la clase se asignarán a quienes logren el **menor tiempo de ejecución** y el **menor consumo de RAM**. ¡Optimiza tu uso de memoria!

## 💻 Ejecución Local

Para probar tu programa en tu máquina:
1. Asegúrate de tener instalado el SDK de **.NET 10**.
2. Ejecuta el comando: `dotnet run`
3. Ingresa una expresión, por ejemplo: {(3+2)*[5-1]}
4. La salida debe ser: `true`

---
**Nota:** No modifiques el archivo `Program.cs`.
