using System;

namespace Chat4Heritage
{
    //heiritage Chien:Animal
    public class Chien : Animal
    {
        //declaration de l'attribut existe et creation
        public Chien(string nom, int age)
                : base(nom, age)
        {

        }

        //cration du methode ou fonction ou comportement 'Aboyer'
        public void Aboyer()
        {
            Console.WriteLine("waouh waouuuh waouh");
        }
    }
}
