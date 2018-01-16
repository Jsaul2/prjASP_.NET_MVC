using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVehicule_Metier
{
    public class ParcAuto_DataContexte : DbContext
    {
        #region Attributs et accesseurs
        public DbSet<Personne> ListePersonnes { get; set; }
        public DbSet<Vehicule> ListeVehicules { get; set; }
        #endregion

        #region Constructeurs
        public ParcAuto_DataContexte()
            : base("CS_ParcAuto")
        {

        }
        #endregion

        #region Méthodes

        #endregion
    }
}
