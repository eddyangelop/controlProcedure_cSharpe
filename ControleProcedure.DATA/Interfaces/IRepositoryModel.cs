using System;
using System.Collections.Generic;
using System.Text;

namespace ControleProcedure.DATA.Interfaces
{
    public interface IRepositoryModel<T> where T : class
    {
        List<T> SelecionarTodos(params object [] variavel);
        T SelecionarPk(params object[] variavel);
        T Alterar(T objeto);
        T Incluir(T objeto);
        void Excluir(T objeto);
        void Excluir(params object[] variavel);
        void SaveChanges();
    }
}
