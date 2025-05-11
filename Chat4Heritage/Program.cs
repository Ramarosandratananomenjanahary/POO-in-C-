using System;

namespace Chat4Heritage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Chien monChien = new Chien("Rex", 3);
            monChien.FaireDuBruit();
            monChien.Aboyer();
        }
    }

}

