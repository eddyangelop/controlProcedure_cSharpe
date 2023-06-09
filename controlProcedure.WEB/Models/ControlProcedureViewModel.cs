using controlProcedure.DATA.Models;

namespace controlProcedure.WEB.Models
{
    public class ControlProcedureViewModel
    {

        public Cliente? oCliente { get; set; }
        public Servicos? oServicos { get; set; }
        public ClientesProcedimentos? oClientesProcedimentos { get; set; }

        public List<Cliente>? oListCliente { get; set; }
        public List<Servicos>? oListServicos { get; set; }

    }
}
