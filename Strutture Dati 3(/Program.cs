using System;
using System.IO;

namespace Strutture_Dati_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il nome del file sorgente");
            string nomefilesorgente = $"{Console.ReadLine()}";
            Console.WriteLine("Come vuoi chiamare il nuovo file?");
            string nomefile = $"{Console.ReadLine()}";
            if (File.Exists(nomefilesorgente))
            {
                try {
                    using (StreamReader r = new StreamReader(nomefilesorgente))
                    {
                        using (StreamWriter w = new StreamWriter(nomefile))
                        {
                            string linea;
                            while ((linea = r.ReadLine()) != null)
                            {
                                w.WriteLine(linea);
                            }
                        }
                    }
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("il file sorgente non esiste");
            }
        }
    }
}
