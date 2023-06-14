using ControleProcedure.DATA.Repsitories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleProcedure.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }
    }
}
