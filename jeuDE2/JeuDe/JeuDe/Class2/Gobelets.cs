using System;
using System.Collections.Generic;
using System.Text;

namespace JeuDe.Class2
{
    class Gobelets : De
    {
        public int[] tableau = new int[7];
        public De nb_des;

        public Gobelets(int nb_des)
        {

        }

        public void Afficher_score()
        {
            Console.WriteLine(this.valeur);
        }
    }
}
