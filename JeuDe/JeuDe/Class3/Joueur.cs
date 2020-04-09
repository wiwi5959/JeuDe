using System;
using System.Collections.Generic;
using System.Text;
using JeuDe.Class2;

namespace JeuDe.Class3
{
    class Joueur : De
    {
        public string nom;
        public int score;
        public Gobelets gobelets;


        public Joueur(string nom)
        {

        }

        public string Get_nom()
        {
            string nom = this.nom;
            return nom;
        }
        public int Get_score()
        {
            int score = this.score;
            return score;
        }

        public Gobelets lancer(Gobelets gobelets)
        {
            return gobelets;
        }

        public void Afficher_score()
        {
            Console.WriteLine(this.score);
        }


    }
}
