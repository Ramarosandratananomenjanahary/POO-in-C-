//Le polymorphisme permet d’utiliser une méthode de manière différente selon l’objet. Par exemple, tu peux appeler une méthode FaireDuBruit() sur plusieurs animaux, et chacun fait un bruit différent 🐶🐱🐮
//✅ Explication:
//virtual = méthode qu’on peut redéfinir.

//override = redéfinit cette méthode dans la classe fille.

//On utilise le même type Animal pour stocker un Chien ou un Chat, mais leur comportement change.

using System;
namespace Chat5Polymorphisme
{
    class Program
    {
        public static void Main(string[] args)
        {
            Animal monVache = new Vache();

            monVache.FaireDuBruit();
        }
    }
}