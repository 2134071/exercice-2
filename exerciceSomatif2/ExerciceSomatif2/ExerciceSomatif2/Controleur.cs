using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceSomatif2
{
    internal class Controleur
    {
        
        private int index;
        private Forme formeCourante;
        
        private List<Forme> listeDeForme = new List<Forme>();


        public event EventHandler<Forme> ChangerFormeCouranteEvent;

        internal Controleur()
        {
            Models.Rectangle rectangle = new Models.Rectangle();
            Models.RectanglePlein rectanglePlein = new Models.RectanglePlein();
            Models.cercle cercle = new Models.cercle();
            Models.CerclePlein cerclePlein = new Models.CerclePlein();
            listeDeForme.Add(rectangle);
            listeDeForme.Add(rectanglePlein);
            listeDeForme.Add(cercle);
            listeDeForme.Add(cerclePlein);
            index = 0;
        }
        public void ValeurDeLaListe()
        {
           formeCourante = listeDeForme[index];
            index = (index+ 1) % listeDeForme.Count;
             formeCourante.DessinerCustom();
            ChangerFormeCouranteEvent?.Invoke(this, formeCourante);
        }
    }
}
