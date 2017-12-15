using System;

public class Maison
{
    public string Couleur = "Bleu";
    public int NombrePorte = 5;
    private string Code;

    public void Rechauffer()
    {
        Console.WriteLine("La maison chauffe");
    }
}

public class ProgrammeAMoi
{
    public static void Main()
    {
        Maison ResidencePrincipal;          // Déclaration
        ResidencePrincipal = new Maison();  // Instanciation (construction)
        ResidencePrincipal.Couleur = "Jaune";
        ResidencePrincipal.NombrePorte = 7;

        Maison ResidenceSecondaire = new Maison(); // Déclaration et instanciation
        ResidenceSecondaire.Couleur = "Verte";
        ResidenceSecondaire.NombrePorte = 6;

        Auto Porsche = new Auto();
        Porsche.NombrePorte = 2;

        Console.WriteLine("La résidence secondaire est de couleur {0} et le nombre de portes est de {1}",
            ResidenceSecondaire.Couleur, 
            ResidenceSecondaire.NombrePorte);

        ResidencePrincipal.Rechauffer();

        Console.Read();
    }
}

public class Auto
{
    public string Moteur;
    public int NombrePorte=3;
}