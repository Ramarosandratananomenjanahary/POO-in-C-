using System;
using ChatEmcapsulationAvecGetters_Setters;

class program
{
    public static void Main(string[] args)
    {
        //Dans Main(), cree un objet Livre et affiche ses details.
        Livre books = new Livre("Methode bocheur", "Adrien", 2005);
        //appele de l'affichage du details
        books.AfficherDetails();
    }
}