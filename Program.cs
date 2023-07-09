using Microsoft.VisualBasic;
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
            //int prova = 34;
            //double doppio = 34.56;
            //bool qwerty = true;

            //string stringa = Convert.ToString(prova);// Con questo metodo posso convertire la mia variabile in una stringa

            //Console.WriteLine(Convert.ToDouble(prova));// diventa un double
            //Console.WriteLine(Convert.ToInt32(doppio));//diventa un intero
            //Console.Read();

            //Lavorare con le stringhe
            /*string stringa = "Citazione: \"Hello there\""*/; //il bs interrompe gli apici delle stringa principale per inserire all'interno un'altra stringa con doppi apici e mandarla a schermo.
            // \n a schermo la mia stringa verra mandata a capo
            // \n\ + "testo" -> manda a schermo la citazione con gli apici e la scrive andando daccapo

            //Concatenazione

            string nome = "Obi Uan";
            string cognome = "Kenobi";
            string quote = "Citazione: \"Hello there\"";
            //string stringa = "Ciao " + nome + " " + cognome; //non deve essere per forza contenuto all'interno della variabile, ma possiamo metterlo in console.

            //format
            //string stringa = string.Format("buongiorno sono {0} {1}, nome, cognome"); //abbiamo lo stesso risultato di quanto scritto nel console.
            //Console.WriteLine(stringa);

            //Console.WriteLine("buongiorno sono {0} {1}, nome, cognome");//la posizione inserita nelle graffe corrisponde all'indice della nostra variabile.
            //A seconda della posizione in cui riporto le variabili o dell'indice, saranno stampate a schermo es prima inserisco cognome e poi nome oppure cambio da {1} {0}.
            Console.Read();


            //interpolazione
            //Console.WriteLine($"buongiorno {nome} {cognome}"); //simbolo del dollaro, variabili interpolate tra graffe e a schermmo abbiamo la stringa.
            //funziona anche se riportata all'interno di una variabile stringa.

            //toUpper -> funzione di string, non è solo un tipo di dato ma anche un classe
            string stringa = nome.ToUpper(); //->metodo per scrivere tutta la stringa in maiuscolo. ToLower(), scrivo in minuscolo
            //nome.length() -> mi dà la lunghezza della stringa. Lo devo riportare nel console e lasciare la variabile stringa vuota.
            //indexing -> consiste nell'andare a prendere un carattere in base al suo indice
            //Indexof -> è un metodo che mi permette di recuperare la posizione di un singolo elemento all'interno della stringa.
            //Substring ->metodo che mi permette di recuperare una porzione della stringa. Andrò a specificare come argomento tra le tonde del metodo l'indice da cui voglio partire per recuperarla.
            //Per andare a ritroso possiamo scrivere una sintassi del genere: Console.WriteLine(congome.Substring(cognome.Length - 3));
            Console.WriteLine(stringa);






        }
    }
}