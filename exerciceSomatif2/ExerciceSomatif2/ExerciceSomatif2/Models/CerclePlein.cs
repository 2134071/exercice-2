using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class CerclePlein : Forme
    {
        private Color couleur;

        public CerclePlein() : base()
        {
            couleur = Color.Orange;
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.couleur);
            System.Drawing.Rectangle cercle = new(0, 0, 99, 99);
            graphics.FillEllipse( brush , cercle);
        }

        public override string ObtenirType()
        {
            return "cercle plein";
        }
    }
}
