using System;

namespace Chat5Polymorphisme
{
    public class Animal
    {
        public virtual void FaireDuBruit()
        {
            Console.WriteLine("L'animal fait un bruit !");
        }
    }

    public class Vache : Animal
    {
        public override void FaireDuBruit()
        {
            Console.WriteLine("La vache meugle : meuuuh !");
        }
    }
}
