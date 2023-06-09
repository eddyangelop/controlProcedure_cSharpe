using controlProcedure.DATA.Interfaces;
using controlProcedure.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlProcedure.DATA.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {

        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
