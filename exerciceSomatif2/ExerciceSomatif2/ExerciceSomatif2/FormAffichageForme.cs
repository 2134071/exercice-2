using ExerciceSomatif2.Controles;
using ExerciceSomatif2.Models;

namespace ExerciceSomatif2
{
    public partial class FormAffichageForme : Form
    {
        private readonly Controleur controleur;
        public FormAffichageForme()
        {
            InitializeComponent();
            controleur = new Controleur();
            abonnement();
        }
        private void abonnement()
        {
            controleur.ChangerFormeCouranteEvent += Controleur_ChangerFormeCouranteEvent;
        }

        private void Controleur_ChangerFormeCouranteEvent(object? sender, Models.Forme formeCourante)
        {
            userControlForme1.Forme = formeCourante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controleur.ValeurDeLaListe();
        }

        private void userControlForme1_Load(object sender, EventArgs e)
        {

        }

        private void FormAffichageForme_Load(object sender, EventArgs e)
        {

        }

        private void userControlForme1_Load_1(object sender, EventArgs e)
        {

        }
       
    }
}