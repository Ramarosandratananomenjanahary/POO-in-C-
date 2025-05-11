using System;
using Chat1;

class Program
{
    public static void Main(string[] args)
    {
        //Creation d'un objet
        Personne Personne1 = new Personne();
        Personne1.nom = "Alice";
        Personne1.age = 25;

        //appelle de la methode ou fonction a creer
        Personne1.SePresenter();
    }
}