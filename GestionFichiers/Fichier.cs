using System;

public class Fichier
{
    public string Nom { get; set; }
    public string Extension { get; set; }
    public float Taille { get; set; } // Taille en KO

    public Fichier(string nom, string extension, float taille)
    {
        Nom = nom;
        Extension = extension;
        Taille = taille;
    }

    public void Afficher()
    {
        Console.WriteLine($"Fichier: {Nom}.{Extension} - {Taille} KO");
    }
}
