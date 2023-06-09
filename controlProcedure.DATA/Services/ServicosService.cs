using controlProcedure.DATA.Interfaces;
using controlProcedure.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlProcedure.DATA.Services
{
    public class ServicosService
    {
        public RepositoryServicos oRepositoryServicos { get; set; }

        public ServicosService()
        {
            oRepositoryServicos = new RepositoryServicos();
        }
    }
}
