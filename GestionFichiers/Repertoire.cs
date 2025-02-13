using System;
using System.Collections.Generic;

public class Repertoire
{
    public string Nom { get; set; }
    private List<Fichier> fichiers;

    public Repertoire(string nom)
    {
        Nom = nom;
        fichiers = new List<Fichier>();
    }

    public void Afficher()
    {
        Console.WriteLine($"Répertoire: {Nom}");
        foreach (var fichier in fichiers)
        {
            fichier.Afficher();
        }
    }

    public int Rechercher(string nom)
    {
        return fichiers.FindIndex(f => f.Nom == nom);
    }

    public void Ajouter(Fichier fichier)
    {
        fichiers.Add(fichier);
    }

    public void Supprimer(string nom)
    {
        int index = Rechercher(nom);
        if (index != -1)
        {
            fichiers.RemoveAt(index);
            Console.WriteLine($"Fichier {nom} supprimé.");
        }
        else
        {
            Console.WriteLine("Fichier non trouvé.");
        }
    }

    public void RechercherParExtension(string extension)
    {
        foreach (var fichier in fichiers)
        {
            if (fichier.Extension == extension)
            {
                fichier.Afficher();
            }
        }
    }

    public float GetTaille()
    {
        float tailleTotale = 0;
        foreach (var fichier in fichiers)
        {
            tailleTotale += fichier.Taille;
        }
        return tailleTotale / 1024; // Conversion en MO
    }
}
