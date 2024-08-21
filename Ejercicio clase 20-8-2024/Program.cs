using Ejercicios;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("probando la pila");
        Pila pila = new Pila();

        //añadi elementos a la pila
        pila.Añadir("Elemento 1");
        pila.Añadir("Elemento 2");
        pila.Añadir("Elemento 3");

        // primer elemento
        Console.WriteLine("El primer elemento de la pila:" + pila.Primero());

        // Extraer elementos de la pila y mostrarlos
        Console.WriteLine("Extrayendo elementos de la pila:");
        while (!pila.Estavacia())
        {
            Console.WriteLine(pila.Extraer());
        }

        try
        {
            // Intentar extraer de una pila vacía
            pila.Extraer();
        }

        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Exception capturada:" + ex.Message);

        }

        // Prueba de la clase Cola
        Console.WriteLine("probando la cola");
        Cola cola = new Cola();

        // Añadir elementos a la cola
        cola.Añadir("Elemento A");
        cola.Añadir("Elemento B");
        cola.Añadir("Elemento C");

        // Mostrar el primer elemento de la cola
        Console.WriteLine("Extrayendo elementos de la cola");

        // Extraer elementos de la cola y mostrarlos
        Console.WriteLine("Extrayendo elementos de la cola:");
        while (!cola.Estavacia())
        {
            Console.WriteLine(cola.Extraer());
        }
        try
        {
            // Intentar extraer de una cola vacía
            cola.Extraer();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Excepción capturada:" + ex.Message);

        } 


        try
        {
            // Intentar añadir un objeto nulo a la cola
            cola.Añadir(null);

        }

        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exception capturada; " + ex.Message);
        }



    }
}