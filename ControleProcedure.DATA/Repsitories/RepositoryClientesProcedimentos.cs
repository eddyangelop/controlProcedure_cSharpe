using ControleProcedure.DATA.Interfaces;
using ControleProcedure.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleProcedure.DATA.Repsitories
{
    public class RepositoryClientesProcedimentos : RepositoryBase<ClientesProcedimentos>, IRepositoryClientesProcedimentos
    {
        public RepositoryClientesProcedimentos(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}
