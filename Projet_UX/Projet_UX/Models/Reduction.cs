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
    internal class Reduction : Ticket
    {

        public Reduction(int id, string name, DateTime valide, DateTime expires, double price) : base(id, name, valide,expires,price)
        {
            
        }

    }
}
