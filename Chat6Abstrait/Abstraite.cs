using System;

namespace Chat6Abstraite
{
    // Classe abstraite
    abstract class Instrument
    {
        public abstract void Jouer();
    }

    // Classe dérivée : Guitare
    class Guitare : Instrument
    {
        public override void Jouer()
        {
            Console.WriteLine("La guitare joue un solo !");
        }
    }

    // Classe dérivée : Piano
    class Piano : Instrument
    {
        public override void Jouer()
        {
            Console.WriteLine("Le piano joue une mélodie !");
        }
    }

}
