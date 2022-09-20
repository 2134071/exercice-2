namespace ExerciceSomatif2.Controles
{
    partial class UserControlForme
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lblTypeDeForme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(25, 26);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(304, 150);
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // lblTypeDeForme
            // 
            this.lblTypeDeForme.AutoSize = true;
            this.lblTypeDeForme.Location = new System.Drawing.Point(29, 194);
            this.lblTypeDeForme.Name = "lblTypeDeForme";
            this.lblTypeDeForme.Size = new System.Drawing.Size(82, 15);
            this.lblTypeDeForme.TabIndex = 3;
            this.lblTypeDeForme.Text = "Type de forme";
            // 
            // UserControlForme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTypeDeForme);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "UserControlForme";
            this.Size = new System.Drawing.Size(412, 222);
            this.Load += new System.EventHandler(this.UserControlForme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBoxImage;
        private Label lblTypeDeForme;
    }
}
