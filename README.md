#TP6
¿String es un tipo por valor o por referencia?
En C#, string es un tipo por referencia. Se almacena en el montón (heap) y la variable guarda la dirección de memoria del dato. Sin embargo, tiene una peculiaridad: se comporta como un tipo por valor debido a su inmutabilidad:
Si modificas un string, en realidad se crea uno nuevo en memoria.
El operador == compara el contenido (el texto) en lugar de la referencia en memoria.

¿Que secuencias de escape tiene el tipo string?
\' Comilla simple
\" Comilla doble
\\ Barra invertida
\0 Caracter nulo
\n Salto de linea
\t Tabulacion horizontal
\v Tabulacion vertical
\r Retorno de carro
\a Alerta (sonido de sistema)
\b Retroceso (backscape)
\f Avance de pagina/Salto de pagina
\e Escape

¿Que sucede cuando se utiliza el caracter @ y $ antes de una cadena de texto?
En C#, el uso de estos caracteres antes de una cadena de texto modifica radicalmente cómo el compilador la interpreta. Dependiendo del orden y de si los usas juntos o por separado, logras resultados muy específicos para el manejo de texto y variables.
Al anteponer el @, le indicas al compilador que ignore las secuencias de escape (como \n para salto de línea o \t para tabulación) y que trate el texto exactamente como fue escrito.
Ventaja principal: Es ideal para rutas de archivos o textos largos.
Ejemplo de uso: string ruta = @"C:\Documentos\Archivo.txt"; (No necesitas escribir \\ para la barra invertida).
Al anteponer el $, activas la interpolación de cadenas, lo que te permite insertar variables o expresiones directamente dentro del texto envolviéndolas en llaves {}.
Ventaja principal: Es más limpio y fácil de leer que usar el método tradicional string.Format() o el operador +.
Ejemplo de uso: string saludo = $"Hola, {nombre}. Tienes {edad} años.";