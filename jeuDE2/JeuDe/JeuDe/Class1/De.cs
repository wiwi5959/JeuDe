using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDe
{
    class De
    {
        public int valeur;
        Random alea = new Random();
        int min = 1;
        int max = 6;

        public De()
        {

        }

        public De(int valeur)
        {

        }

        public int Get_valeur()
        {
            int valeur = this.valeur;
            return valeur;
        }

        public int Lancer(int min, int max)

        {
            int valeur = new Random().Next(min, max);
            return valeur;
        }

    }
}
