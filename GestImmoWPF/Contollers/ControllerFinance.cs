using GestImmoWPF.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TP.Data.Models;

namespace GestImmoWPF.Contollers
{
     class ControllerFinance
    {
        public int calculerRentabiliteNetMensuelGlobale()
        {
            ImmoContext ctx = ImmoContext.getInstace();
            List<Biens>biens= ctx.Biens.ToList();

            int revenuGlobal = 0;

            foreach (Biens bien in biens)
            {
                revenuGlobal = revenuGlobal + bien.calculerRentabiliteNetMensuel();
            }
            return revenuGlobal;
        }

    }
}
