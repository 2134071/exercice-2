using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class cercle : Forme
    {

        private Color couleur;

        public cercle() : base()
        {
            couleur = Color.Orange;
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Pen pen = new Pen(this.couleur);
            System.Drawing.Rectangle cercle = new(0, 0, 99, 99);
            graphics.DrawEllipse(pen, cercle);
        }

        public override string ObtenirType()
        {
            return "cercle";
        }
    }
}
