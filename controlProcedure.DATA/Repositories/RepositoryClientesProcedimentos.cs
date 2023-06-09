using controlProcedure.DATA.Interfaces;
using controlProcedure.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlProcedure.DATA.Repositories
{
    public class RepositoryClientesProcedimentos : RepositoryBase<ClientesProcedimentos>, IRepositoryClientesProcedimentos
    {
        public RepositoryClientesProcedimentos(bool SaveChanges = true) : base(SaveChanges)
        {
        
        }
    }
}
