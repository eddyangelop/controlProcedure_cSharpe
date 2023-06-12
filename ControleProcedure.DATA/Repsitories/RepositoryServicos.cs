using ControleProcedure.DATA.Interfaces;
using ControleProcedure.DATA.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleProcedure.DATA.Repsitories
{
    public class RepositoryServicos : RepositoryBase<Servicos>, IRepositoryServicos
    {
        public RepositoryServicos(bool SaveChanges = true) : base(SaveChanges)
        {
        }
    }
}
