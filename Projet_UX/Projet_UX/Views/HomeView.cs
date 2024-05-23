using Projet_UX.Controller;
using Projet_UX.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projet_UX.HomeView;

namespace Projet_UX
{
    public partial class HomeView : Form
    {
        /// <summary>
        /// Déclaration du controller pour lier la vu au controller 
        /// </summary>
        public TermController Controller {  get; set; }

        /// <summary>
        /// constructeur
        /// </summary>
        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {

        }

        #region btnFlags
        private void btnFrenchFlag_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Franch);
        }

        private void btnUkFlag_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.English);
        }
        private void btnSpanishFlag_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Spanish);
        }

        private void btnGermanyFlag_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Deustch);
        }

        private void btnItalianFlag_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Italian);
        }
        #endregion


        private void btnFrench_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Franch);
        }

        private void btnUk_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.English);
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Spanish);
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Deustch);
        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            Controller.ShowTicket();
            Controller.SelectLanguage(lang: TermController.Language.Italian);
        }

        /// <summary>
        /// méthode pour traduire la langue selon le fichier ressourse
        /// </summary>
        /// <param name="resource">fichier ressource</param>
        public void UpdateLanguage(ResourceManager resource)
        {
            // parcourrir chaque element du fichier ressource
            foreach (Control c in Controls)
            {
                // si l'element n'est pas vide alors on ecrit sa valeur 
                if (resource.GetString(c.Name) != null)
                {
                    c.Text = resource.GetString(c.Name);
                }
            }
        }
    }
}
