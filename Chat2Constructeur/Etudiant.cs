using System;

namespace Chat2constructeur
{
    class Etudiant
    {
        //Attribut ou variable ou accessoire
        public string nom;
        public string prenom;
        public int age;

        //Constructeur ou methode speciale qui initialise ces attributs
        public Etudiant(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        //Creation d'un methode ou affichage
        public void SePresenter()
        {
            Console.WriteLine($"Je suis {prenom} {nom} et j'ai {age} ans");
        }

    }
}
