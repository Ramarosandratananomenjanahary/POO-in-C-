using System;


namespace Chat1
{
    class Personne
    {
        //Atributs ou variables
        public string nom;
        public int age;

        //Methodes ou fonctions
        public void SePresenter()
        {
            Console.WriteLine($"Bonjour, je m'appelle {nom} et j'ai {age} ans");
        }
    }
}
