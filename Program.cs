/*
Nome: Laidone Mendes de Carvalho
Laboratório 8
*/

using System;

namespace Laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] lista = { "Gustavo", "Danilo", "Matheus", "Odin" }; 
        Console.WriteLine("Array antes da ordenacao"); 
        for (int i = 0; i < lista.Length; i++) 
        { 
            Console.Write(lista[i] + " "); 
        } 
        Console.WriteLine(); 
        Array.Sort(lista); 
        Console.WriteLine("Array depois da ordenacao"); 
        for (int i = 0; i < lista.Length; i++) 
        { 
            Console.Write(lista[i] + " "); 
        }
        Console.WriteLine(); 
        Pessoa[] lista2 = {
            new Pessoa("Jose", 25),
            new Pessoa("Ana", 28),
            new Pessoa("Paulo", 20) 
        };
        /*Array.Sort(lista2); 
        Console.WriteLine("Array depois da ordenacao"); 
        for (int i = 0; i < lista2.Length; i++) 
        { 
            Console.Write(lista2[i].Nome + " "); 
        }
        */
        System.Console.WriteLine("Array Original\n");
        for(int i = 0 ; i < lista2.Length; ++i){
            Console.Write(lista2[i].Nome + " "); 
        }
        System.Console.WriteLine();
        // Array usando Icompare e ordenando por idade
        System.Console.WriteLine("Array usando o Icompare\n");
        System.Console.WriteLine("Array ordenada por idade");
        //Array.Sort(lista2, new sortcompare());
        Array.Sort(lista2, new Pessoa.sortcompare());
        for(int i = 0 ; i < lista2.Length; ++i){
            Console.Write(lista2[i].Nome + " "); 
        }
        System.Console.WriteLine("\n");
        System.Console.WriteLine("Array ordenada pelo nome");
        Array.Sort(lista2, new Pessoa.sortcompare_2());
        for(int i = 0 ; i < lista2.Length; ++i){
            Console.Write(lista2[i].Nome + " "); 
        }
        }
    }
}
