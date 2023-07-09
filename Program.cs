using System;

namespace HelloCSharp
    {
    class Program
    {
        static void Main(string[] args)
        {
            const string nome = "Marika"; //variabile inizializzata. Portata a costante
            int eta = 33; //se dentro doppi apici diventa una stringa. Questo è un intero.

            Console.WriteLine("Hello C#");
            Console.WriteLine("Ciao io sono " + nome); //concateno le variabili
            Console.WriteLine("ho " + eta +" anni");
            Console.WriteLine(nome + " è il mio primo nome");
            Console.Read();
        }
    }
}