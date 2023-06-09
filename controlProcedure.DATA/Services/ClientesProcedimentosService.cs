using controlProcedure.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlProcedure.DATA.Services
{
    public class ClientesProcedimentosService
    {
        public RepositoryClientesProcedimentos oRepositoryClientesProcedimentos { get; set; }
     
        public ClientesProcedimentosService() 
        {
            oRepositoryClientesProcedimentos = new RepositoryClientesProcedimentos();          
        }

    }
}