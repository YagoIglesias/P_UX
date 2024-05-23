/// ETML
/// Auteur : Yago Iglesias Rodriguez 
/// Date : 25.04.2024
/// Description : Classe qui va permetre de relier le model et les vues afin de gerer les interactions

using Projet_UX.Models;
using Projet_UX.Properties;
using Projet_UX.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projet_UX.HomeView;

namespace Projet_UX.Controller
{
    public class TermController
    {
        /// <summary>
        /// declarer le model pour qu'il puissent communiquer
        /// </summary>
        private TermModel _model;

        /// <summary>
        /// declarerla vue pour qu'il puissent communiquer
        /// </summary>
        private HomeView _view;

        /// <summary>
        /// 
        /// </summary>
        private TicketView _ticket;

        /// <summary>
        /// declaration des languens a disposition 
        /// </summary>
        public enum Language
        {
            Franch, English, Deustch, Italian, Spanish
        }

        // crer un etat de langue courrante
        private Language _currentLangue;

        // creation de la resource avec la langue
        ResourceManager rManager = new ResourceManager(typeof(Resources.FR));

        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="model"> base de donnes </param>
        /// <param name="view"> vue </param>
        public TermController(TermModel model, HomeView view, TicketView ticketView)
        {
            _view = view;
            _ticket = ticketView;   
            _model = model;
            _view.Controller = this;
            _model.Controller = this;
            _ticket.Controller = this;  
            
        }

        /// <summary>
        /// méthode pour changer la langue 
        /// </summary>
        /// <param name="lang"> langue choisi </param>
        public void SelectLanguage(Language lang)
        {
            _currentLangue = lang;
            // switch pour aller chercher le bon fichier ressource selon la langue 
            switch (_currentLangue)
            {
                case Language.Franch:
                    rManager = new ResourceManager(typeof(Resources.FR));
                    //UpdateViews();
                    break;
                case Language.Italian:
                    rManager = new ResourceManager(typeof(Resources.IT));
                    //UpdateViews();
                    break;
                case Language.Spanish:
                    rManager = new ResourceManager(typeof(Resources.ES));
                    //UpdateViews();
                    break;
                case Language.English:
                    rManager = new ResourceManager(typeof(Resources.EN));
                    //UpdateViews();
                    break;
                case Language.Deustch:
                    rManager = new ResourceManager(typeof(Resources.DE));

                    break;

                default:
                    break;    
            }
            UpdateViews();
        }

        /// <summary>
        /// méthode pour mettre a jour la langue pour toutes les vues 
        /// </summary>
        public void UpdateViews()
        {
            _view.UpdateLanguage(rManager);
            _ticket.UpdateLanguage(rManager);

        }

        /// <summary>
        /// méthode pour afficher la vue des tickets a choisir
        /// </summary>
        public void ShowTicket()
        {
            CloseOpen(_view,_ticket);
        }

        public void CloseTicket()
        {
            CloseOpen(_ticket,_view);
        }

        /// <summary>
        /// méthode pour ouvrire et fermer les views
        /// </summary>
        /// <param name="formToHide"></param>
        /// <param name="formToShow"></param>
        public void CloseOpen(Form formToHide, Form formToShow)
        {
            formToHide.Hide();
            formToShow.Show();
        }












    }
}
