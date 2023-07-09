using System;

namespace HelloCSharp
    {
    class Program
    {
        static void Main(string[] args)
        {
            //const string nome = "Marika"; //variabile inizializzata. Portata a costante
            //int eta = 33; //se dentro doppi apici diventa una stringa. Questo è un intero.

            //Console.WriteLine("Hello C#");
            //Console.WriteLine("Ciao io sono " + nome); //concateno le variabili
            //Console.WriteLine("ho " + eta +" anni");
            //Console.WriteLine(nome + " è il mio primo nome");
            //Console.Read();


            //Tipi di Dati
            //int intero = 2000000000;
            //long lungo = 20000000000000;
            //double doppio = 4.5;
            //float flottante = 4.5f;
            //decimal decimale = 4.5m;

            //Casting - Conversione
            // -Implicito
            //int prova = 345;
            //long qwerty = prova;

            ////- esplicito
            //double prova = 35.26;
            //int qwerty = (int)prova; //Davanti alla nostra variabile prova andiamo a scrivere davanti che vogliamo convertirlo da double a int.
            //Stampato in console vedremo 35 e non 35.26

            //metodi di conversione
            int prova = 34;
            double doppio = 34.56;
            bool qwerty = true;

            string stringa = Convert.ToString(prova);// Con questo metodo posso convertire la mia variabile in una stringa

            Console.WriteLine(Convert.ToDouble(prova));// diventa un double
            Console.WriteLine(Convert.ToInt32(doppio));//diventa un intero
            Console.Read();




        }
    }
}