using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    internal class Rectangle : Forme
    {
        private Color couleur;
        public Rectangle() : base()
        {
            couleur = Color.Green;
            
        }

        protected override void DessinerCustom(Graphics graphics)
        {
            Pen pen = new Pen(this.couleur);
            System.Drawing.Rectangle rectangle = new(0, 0, 50, 99);
            graphics.DrawRectangle(pen, rectangle);
        }

        public override string ObtenirType()
        {
            return "Rectangle";
        }
    }
}
