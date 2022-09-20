using ExerciceSomatif2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceSomatif2.Controles
{
    public partial class UserControlForme : UserControl
    {
        private Models.Forme forme;

        public Models.Forme Forme { get => forme;
            
            set  
            { if(value is null)
                {
                    lblTypeDeForme.Text = "";
                }
                else
                {
                    if(forme is not null)
                    {
                        forme.TypeFormechanged -= forme_ValeurChanged;
                    }
                }
                this.forme = value;
                if(forme is not null)
                {
                    affichage();
                    forme.TypeFormechanged += forme_ValeurChanged;
                }
            
            
            } }

        private void forme_ValeurChanged(object? sender, Bitmap type)
        {
            pictureBoxImage.Image = type;
        }

        public UserControlForme()
        {
            InitializeComponent();
        }
        
        private void UserControlForme_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }
        private void affichage()
        {
            lblTypeDeForme.Text = forme.ObtenirType();
            pictureBoxImage.Image = forme.DessinerCustom();
        }
    }
}
