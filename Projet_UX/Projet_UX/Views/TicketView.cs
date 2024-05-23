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
using Projet_UX.Controller;

namespace Projet_UX.Views
{
    public partial class TicketView : Form
    {
        public TermController Controller {  get; set; } 

        public TicketView()
        {
            InitializeComponent();
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

        /// <summary>
        /// méthode pour traduire la langue selon le fichier sourcce
        /// </summary>
        /// <param name="resource"> fichier ressource </param>
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            Controller.CloseTicket();
        }





    }
}
