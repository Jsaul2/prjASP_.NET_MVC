using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicule_Metier
{
    public class Personne
    {
        #region Attributs et accesseurs
        [Key]
        public int Identifiant { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        public List<Vehicule> ListeVehicules { get; set; }
        #endregion

        #region Constructeurs
        public Personne(string aNom, string aPrenom)
        {
            this.Nom = aNom;
            this.Prenom = aPrenom;
            this.ListeVehicules = new List<Vehicule>();
        }
        #endregion

        #region Méthodes

        #endregion
    }
}
