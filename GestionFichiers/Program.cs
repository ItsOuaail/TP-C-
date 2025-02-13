using System;

class Program
{
    static void Main()
    {
        Repertoire monRepertoire = new Repertoire("Mes Documents");

        monRepertoire.Ajouter(new Fichier("cours", "pdf", 500));
        monRepertoire.Ajouter(new Fichier("image", "jpg", 200));
        monRepertoire.Ajouter(new Fichier("video", "mp4", 5000));

        monRepertoire.Afficher();
        Console.WriteLine($"Taille totale: {monRepertoire.GetTaille()} MO");

        monRepertoire.RechercherParExtension("pdf");

        monRepertoire.Supprimer("image");
        monRepertoire.Afficher();
    }
}
