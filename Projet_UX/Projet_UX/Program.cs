using Projet_UX.Controller;
using Projet_UX.Models;
using Projet_UX.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_UX
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // creation de la vue 
            HomeView aHome = new HomeView();
            TicketView aTicket = new TicketView();

            // creation du modele
            TermModel aModel = new TermModel();

            // creation du controleur
            TermController controller = new TermController(model: aModel, view: aHome,ticketView:aTicket);

            Application.Run(aHome);
            
        }
    }
}
