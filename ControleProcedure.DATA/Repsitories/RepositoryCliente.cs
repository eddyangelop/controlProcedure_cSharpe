using ControleProcedure.DATA.Interfaces;
using ControleProcedure.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleProcedure.DATA.Repsitories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}
