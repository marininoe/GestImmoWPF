using GestImmoWPF.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TP.Data.Models;

namespace GestImmoWPF.Data.DAO
{
    internal class DAOBien
    {
        public List<Biens> getBeinAvecPret()
        {
            List<Biens> biens;

            ImmoContext context = ImmoContext.getInstace();
            var rows = from b in context.Biens
                       where b != null
                       select b;

            biens = rows.ToList();

            return biens;
        }
    }
}
