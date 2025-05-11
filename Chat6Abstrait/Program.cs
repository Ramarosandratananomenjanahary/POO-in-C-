using System;
using System.Diagnostics.Metrics;
namespace Chat6Abstraite
{
    class Program
    {
        public static void Main(string[] args)
        {
            Instrument monInstrument = new Guitare();
            Instrument monPiano = new Piano();

            monInstrument.Jouer();
            monPiano.Jouer();
        }
    }
}