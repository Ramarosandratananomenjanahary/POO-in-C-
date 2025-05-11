/*
 EXERCICE 4: 
1. Cree une classe livre avec : 
    .Titre (string)
    .Auteur (string)
    .AnneePublication(int)

2. Utilise l'encapsulation (get/set)

3. Dans le constructeur , initialise les attributs.

4. Cree une methode AfficherDetails() pour afficher les infos du livre.

5. Dans Main(), cree un objet Livre et affiche ses details.
 */

using System;

namespace ChatEmcapsulationAvecGetters_Setters
{
    class Livre
    {
        private string titre;
        private string auteur;
        private int anneePublication;

        //Encapsulation (get / set)
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }

        public int AnneePublication
        {
            get { return anneePublication; }
            set
            {
                if (value > 1000)
                {
                    anneePublication = value;
                }
            }
        }

        //Dans le constructeur , initialise les attributs.
        public Livre(string titre, string auteur, int anneePublication)
        {
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
        }

        //Cree une methode AfficherDetails() pour afficher les infos du livre.
        public void AfficherDetails()
        {
            Console.WriteLine($"Cet livre a de titre : {Titre}, auteur : {Auteur} et de l annee du publication en : {AnneePublication}");
        }

    }
}
