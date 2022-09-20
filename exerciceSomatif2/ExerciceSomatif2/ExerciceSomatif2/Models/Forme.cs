using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2.Models
{
    public abstract class Forme
    {
        
        protected Forme()
        {
            
        }
        public void Dessiner() {
            DessinerCustom();
        }
        public event EventHandler<Bitmap> TypeFormechanged;
        protected abstract void DessinerCustom(Graphics graphics);

        public Bitmap DessinerCustom()
        {
            Bitmap bitmap = new Bitmap(100, 100);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                DessinerCustom(graphics);
            }
            TypeFormechanged?.Invoke(this, bitmap);
            return bitmap;

        }

        public abstract string ObtenirType();
    }
}
