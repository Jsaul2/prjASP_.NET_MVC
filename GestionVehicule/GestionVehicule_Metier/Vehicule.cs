using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicule_Metier
{
    public class Vehicule
    {
        #region Attributs et accesseurs
        [Key]
        public int Identifiant { get; set; }

        [Required]
        public string Numero_immatriculation { get; set; }

        [Required]
        public string Marque { get; set; }
        #endregion

        #region Constructeurs
        public Vehicule(string aNumero_immatriculation, string aMarque)
        {
            this.Numero_immatriculation = aNumero_immatriculation;
            this.Marque = aMarque;
        }
        #endregion

        #region Méthodes

        #endregion
    }
}
