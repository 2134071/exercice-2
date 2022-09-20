using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class RectanglePlein : Forme
    {
        //Graphics.fillrectangle
        private Color couleur;
        public RectanglePlein() : base()
        {
            couleur = Color.Green;

        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Brush brush = new SolidBrush(this.couleur);
            System.Drawing.Rectangle rectangle = new(0, 0, 50, 99);
            graphics.FillRectangle(brush, rectangle);
        }

        public override string ObtenirType()
        {
            return "Rectangle Plein";
        }
    }
}
