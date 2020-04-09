using System;
using System.Collections.Generic;
using System.Text;
using JeuDe.Class3;
using JeuDe.Class2;

namespace JeuDe.Class4
{
    static class Partie
    {
        public static Joueur joueur;
        public static Gobelets gobelets;
        public static De de;

        public static void Initialiser()
        {
            joueur = joueur1();
            joueur = joueur2();
            AfficherInfoJoueur();
            Lancer();
        }
        public static Joueur joueur1()
        {
            Console.Write("entrez un nom ");
            return new Joueur(Console.ReadLine(), 0);
        }

        public static Joueur joueur2()
        {
            Console.Write("entrez un nom ");
            return new Joueur(Console.ReadLine(), 0);
        }

        public static void AfficherInfoJoueur()
        {
            Console.WriteLine(joueur1().ToString());
            Console.WriteLine(joueur2().ToString());
        }

        public static void Lancer()
        {
            int scorejoueur1 = joueur1().score;
            int scorejoueur2 = joueur2().score;
            bool tour = false;

            while (scorejoueur1 > 0 && scorejoueur2 > 0)
            {
                if (tour == true)
                {
                    tour = false;
                    Console.WriteLine(joueur1().nom + " lance le dé et fait un score de " + scorejoueur1);
                }
                else if (tour == false)
                {
                    tour = true;
                    Console.WriteLine(joueur2().nom + " lance le dé et fait un score de " + scorejoueur2);
                }

                if (scorejoueur1 == 15)
                {
                    Console.WriteLine(joueur1().nom + " a gagné la partie");
                }
                else if (scorejoueur2 == 15)
                {
                    Console.WriteLine(joueur2().nom + " a gagné la partie");
                }
            }
        }
    }
}
