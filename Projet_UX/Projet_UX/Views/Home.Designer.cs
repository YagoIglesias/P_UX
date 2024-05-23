namespace Projet_UX
{
    partial class Home
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLanguage = new System.Windows.Forms.Label();
            this.picBoxItaly = new System.Windows.Forms.PictureBox();
            this.picBoxGermany = new System.Windows.Forms.PictureBox();
            this.picBoxSpain = new System.Windows.Forms.PictureBox();
            this.picBoxUk = new System.Windows.Forms.PictureBox();
            this.picBoxFrance = new System.Windows.Forms.PictureBox();
            this.lblFrench = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblSpanish = new System.Windows.Forms.Label();
            this.lblGerman = new System.Windows.Forms.Label();
            this.lblItalian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItaly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSpain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(322, 59);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(461, 31);
            this.lblLanguage.TabIndex = 0;
            this.lblLanguage.Text = "Selectionnez la langue de votre choix";
            // 
            // picBoxItaly
            // 
            this.picBoxItaly.Image = global::Projet_UX.Properties.Resources.ItalyFlag;
            this.picBoxItaly.Location = new System.Drawing.Point(328, 568);
            this.picBoxItaly.Name = "picBoxItaly";
            this.picBoxItaly.Size = new System.Drawing.Size(127, 82);
            this.picBoxItaly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxItaly.TabIndex = 5;
            this.picBoxItaly.TabStop = false;
            // 
            // picBoxGermany
            // 
            this.picBoxGermany.Image = global::Projet_UX.Properties.Resources.GermanyFlag;
            this.picBoxGermany.Location = new System.Drawing.Point(328, 459);
            this.picBoxGermany.Name = "picBoxGermany";
            this.picBoxGermany.Size = new System.Drawing.Size(127, 82);
            this.picBoxGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGermany.TabIndex = 4;
            this.picBoxGermany.TabStop = false;
            // 
            // picBoxSpain
            // 
            this.picBoxSpain.Image = global::Projet_UX.Properties.Resources.SpainFlag;
            this.picBoxSpain.Location = new System.Drawing.Point(328, 352);
            this.picBoxSpain.Name = "picBoxSpain";
            this.picBoxSpain.Size = new System.Drawing.Size(127, 82);
            this.picBoxSpain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSpain.TabIndex = 3;
            this.picBoxSpain.TabStop = false;
            // 
            // picBoxUk
            // 
            this.picBoxUk.Image = global::Projet_UX.Properties.Resources.UkFlag;
            this.picBoxUk.Location = new System.Drawing.Point(328, 249);
            this.picBoxUk.Name = "picBoxUk";
            this.picBoxUk.Size = new System.Drawing.Size(127, 82);
            this.picBoxUk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUk.TabIndex = 2;
            this.picBoxUk.TabStop = false;
            // 
            // picBoxFrance
            // 
            this.picBoxFrance.Image = global::Projet_UX.Properties.Resources.FranceFlag;
            this.picBoxFrance.Location = new System.Drawing.Point(328, 140);
            this.picBoxFrance.Name = "picBoxFrance";
            this.picBoxFrance.Size = new System.Drawing.Size(127, 82);
            this.picBoxFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFrance.TabIndex = 1;
            this.picBoxFrance.TabStop = false;
            this.picBoxFrance.Click += new System.EventHandler(this.picBoxFrance_Click);
            // 
            // lblFrench
            // 
            this.lblFrench.AutoSize = true;
            this.lblFrench.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrench.Location = new System.Drawing.Point(510, 162);
            this.lblFrench.Name = "lblFrench";
            this.lblFrench.Size = new System.Drawing.Size(119, 31);
            this.lblFrench.TabIndex = 6;
            this.lblFrench.Text = "Français";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(510, 273);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(103, 31);
            this.lblEnglish.TabIndex = 7;
            this.lblEnglish.Text = "English";
            // 
            // lblSpanish
            // 
            this.lblSpanish.AutoSize = true;
            this.lblSpanish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpanish.Location = new System.Drawing.Point(510, 380);
            this.lblSpanish.Name = "lblSpanish";
            this.lblSpanish.Size = new System.Drawing.Size(112, 31);
            this.lblSpanish.TabIndex = 8;
            this.lblSpanish.Text = "Español";
            // 
            // lblGerman
            // 
            this.lblGerman.AutoSize = true;
            this.lblGerman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerman.Location = new System.Drawing.Point(510, 481);
            this.lblGerman.Name = "lblGerman";
            this.lblGerman.Size = new System.Drawing.Size(115, 31);
            this.lblGerman.TabIndex = 9;
            this.lblGerman.Text = "Deustch";
            // 
            // lblItalian
            // 
            this.lblItalian.AutoSize = true;
            this.lblItalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItalian.Location = new System.Drawing.Point(510, 597);
            this.lblItalian.Name = "lblItalian";
            this.lblItalian.Size = new System.Drawing.Size(102, 31);
            this.lblItalian.TabIndex = 10;
            this.lblItalian.Text = "Italiano";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.lblItalian);
            this.Controls.Add(this.lblGerman);
            this.Controls.Add(this.lblSpanish);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblFrench);
            this.Controls.Add(this.picBoxItaly);
            this.Controls.Add(this.picBoxGermany);
            this.Controls.Add(this.picBoxSpain);
            this.Controls.Add(this.picBoxUk);
            this.Controls.Add(this.picBoxFrance);
            this.Controls.Add(this.lblLanguage);
            this.Name = "Home";
            this.Click += new System.EventHandler(this.lblLanguage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxItaly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSpain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.PictureBox picBoxFrance;
        private System.Windows.Forms.PictureBox picBoxUk;
        private System.Windows.Forms.PictureBox picBoxSpain;
        private System.Windows.Forms.PictureBox picBoxGermany;
        private System.Windows.Forms.PictureBox picBoxItaly;
        public System.Windows.Forms.Label lblFrench;
        public System.Windows.Forms.Label lblEnglish;
        public System.Windows.Forms.Label lblSpanish;
        public System.Windows.Forms.Label lblGerman;
        public System.Windows.Forms.Label lblItalian;
    }
}

