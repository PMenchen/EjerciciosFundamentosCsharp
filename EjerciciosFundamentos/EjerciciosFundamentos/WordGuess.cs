using Pathfinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosFundamentos
{
    public class WordGuess
    {
        //Creo un array de palabras aleatorias
        public static readonly string[] words = { "Manzana", "Coche", "Lápiz", "Montaña", "Guitarra", "Felicidad", "Mariposa", "Reloj", "Playa", "Globo",
                "Aventura", "Luna", "Espejo", "Sonrisa", "Tren", "Nube", "Bailar", "Café", "Libro", "Jirafa", "Arcoiris", "Cascada", "Pintura",
                "Palabra", "Elefante", "Bicicleta", "Estrella", "Chocolate", "Computadora", "Silla", "Viento", "Payaso", "Serpiente", "Helado",
                "Camino", "Avión", "Sueño", "Océano", "Llave", "Rayo", "Radio", "Fruta" };

        public static void Game()
        {
            int attempts = 1;
            string toGuess = RandomNumber.randomWord(words).ToLower(); //Asigno aleatoriamente una palabra del array para adivinar
            char[] letters = new char[toGuess.Length];
            for (int i = 0; i < toGuess.Length; i++)
            {
                letters[i] = '_'; //Inicializo el array que muestra la palabra con '_' para que el usuario se guíe visualmente del número de letras que hay
                                  //y para sustituir posteriormente ese caracter con la letra adivinada 
            }

            bool finish = false; //Establezco una condición de fin de partida. También se puede sustituir por número de intentos disponibles


            while (!finish)
            {
                Console.WriteLine($"Palabra a adivinar: {string.Join(" ", letters)}");

                Console.Write("Intente una letra: ");
                char guess = Console.ReadLine().ToLower()[0]; // Convierte la entrada en minúscula y solo toma el primer caracter en caso de introducir más de uno

                bool correctGuess = false;

                for (int i = 0; i < toGuess.Length; i++)
                {
                    if (toGuess[i] == guess && letters[i] == '_') //comprobamos el caracter introducido en cada posición del array letras y miramos que no se haya adivinado antes
                    {
                        letters[i] = guess; //Si coincide, se sustituye '_' con la letra introducida
                        correctGuess = true;
                    }
                }

                if (!correctGuess)
                {
                    Console.WriteLine($"La letra {guess} no se encuentra en la palabra");
                }

                if (string.Join("", letters) == toGuess)
                {
                    Console.WriteLine($"Felicidades! Adivinaste la palabra: {toGuess} en {attempts} intentos");
                    finish = true; //En caso de querer usar intentos. Hay que crear un contador decreciente y establecer que, cuando llega a 0, pierde
                }
                attempts++;
            }
        }

    }
}
