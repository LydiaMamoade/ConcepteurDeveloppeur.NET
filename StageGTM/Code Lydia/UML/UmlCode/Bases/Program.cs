

using System;

public class Maison
{
    public string Couleur = "Bleu"; // Déclaration de l'objet couleur
    public int NombrePorte = 5;
    private string Code;        // code est privé, interdiction d'y acceder en dehors de la classe

    public void Rechauffer()    // Déclaration de la méthode rechauffer
    {
        Console.WriteLine("La maison chauffe");
    }
}

public class MonProgramme          // la classe qui contient le code 
{
    public static void Main()
    {
        Maison ResidencePrincipale;                   // Déclaration objet
        ResidencePrincipale = new Maison();           // Contruction objet (instantiation)
        ResidencePrincipale.Couleur = "Jaune";
        ResidencePrincipale.NombrePorte = 7;

        Maison ResidenceSecondaire = new Maison();     // Déclaration et construction
        ResidenceSecondaire.Couleur = "Verte";         // modification d'une propriété de la classe
        ResidenceSecondaire.NombrePorte = 6;

        Auto Porsche = new Auto();
        Porsche.NombrePorte = 2;

        ResidencePrincipale.Rechauffer();  // Utilistion de la méthode rechauffer par l'objet residencescondaire

        Console.WriteLine("La résidence secondaire est de couleur {0} et le nombre de porte est de {1}",
            ResidenceSecondaire.Couleur,
            ResidenceSecondaire.NombrePorte);  // demande à la console d'écrire et afficher la couleur et le nombre de porte de la résidence secondaire 
        Console.Read();                        //  demande à la console d'attendre qu'on appuie sur une touche du clavier

    }
}

public class Auto
{
    public string moteur;
    public int NombrePorte;
    private string NoCarteGrise;
}