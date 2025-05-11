/*
 Exercice 3: Cree une classe Etudiant
1. Ajoute les attributs nom, prenom, age
2. Cree un constructeur qui initialise ces attributs
3. Cree une methode SePresenter() qui affiche: "Je suis [prenom] [nom] et j'ai [age] ans."
4. Dans Main(), cree un objet Etudiant avec des valeurs, puis appelle SePresenter().
 */

using System;
using System.ComponentModel.Design;
using Chat2constructeur;

class Program
{
    public static void Main(string[] args)
    {
        //Creation d'un objet
        Etudiant Student = new Etudiant("Nomenjanahary", "Ramarosandratana", 22);

        //appelle la fonction
        Student.SePresenter();
    }
}