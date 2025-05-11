using System;

namespace Chat1Exo
{
    class Voiture
    {
        //Attributs ou variables ou accessoirs
        public string marque;
        public string modele;
        public int annee;

        //Methodes ou fonctions ou comportements
        public void AfficherInfo()
        {
            Console.WriteLine($"Cette voiture a du marque: {marque}, de modele: {modele} et offrir en annee {annee}");
        }

        public void Demarrer()
        {
            Console.WriteLine("La voiture demarre.");
        }

        public void Freiner()
        {
            Console.WriteLine("La voiture freine.");
        }
    }
}
