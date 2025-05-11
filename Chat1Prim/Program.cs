/*
Exo1:
1. Creer une classe Voiture avec les attributs marque, modele et annee.
2. Ajoute une methode AfficherInfos() qui affiche ces informations.
3. Dans Main(), cree un objet Voiture, attribut des valeurs aux attributs et applelle la methode AfficherInfos().
*/

/*
 Exercice 2: Ameliorer la classe Voiture
1. Ajoute une methode Demarrer() qui affiche: "La voiture demarre."
2. Ajoute une methode Freine() qui affiche : "La voiture freine."
3. Appelle ces deux methodes dans Main().
 */

using System;
using Chat1Exo;

class Program
{
    static void Main(string[] args)
    {
        //Creation d'un objet voiture et des attribut des valeurs aux attributs
        Voiture Automobile = new Voiture();
        Automobile.marque = "BIGATTI";
        Automobile.modele = "V8";
        Automobile.annee = 2010;

        //Appelle de la methode
        Automobile.AfficherInfo();
        Automobile.Demarrer();
        Automobile.Freiner();

    }
}