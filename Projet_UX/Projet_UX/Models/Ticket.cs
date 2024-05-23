/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date   : 23.05.2024
/// Description : Classe pour créér les tickets disponibles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UX.Models
{
    internal class Ticket
    {
        /// <summary>
        /// identifiant du billet
        /// </summary>
        private int _id;

        /// <summary>
        /// nom du billet
        /// </summary>
        private string _name;

        /// <summary>
        /// date valide du billet
        /// </summary>
        private DateTime _valid;

        /// <summary>
        /// date d'expiration
        /// </summary>
        private DateTime _expires;

        /// <summary>
        /// prix du billet
        /// </summary>
        private double _price;

        /// <summary>
        /// recuperer ou mettre à jour l'identifiant du billet
        /// </summary>
        public int Id { get { return _id; } private set {_id = value; } }

        /// <summary>
        /// recuperer ou mettre à jour le nom du billet
        /// </summary>
        public string Name { get { return _name; } private set { _name = value; } }

        /// <summary>
        /// recuperer ou mettre à jour la date de validite du billet 
        /// </summary>
        public DateTime Valid { get { return _valid; } set { _valid = value; } }

        /// <summary>
        /// recuperer ou mettre à jour la date d'expiration du billet
        /// </summary>
        public DateTime Expires { get { return _expires; } set { _expires = value; } }

        /// <summary>
        /// recuperer ou mettre à jour le prix du billet 
        /// </summary>
        public double Price { get { return _price; } private set { _price = value; } }

        /// <summary>
        /// contructeur du billet 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="valide"></param>
        /// <param name="expire"></param>
        /// <param name="price"></param>
        public Ticket(int id, string name, DateTime valide, DateTime expire, double price)
        {
            _id = id;
            _name = name;
            _valid = valide;
            _expires = expire;
            _price = price;
        }
    }
}
