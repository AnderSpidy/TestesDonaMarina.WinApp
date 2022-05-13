using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMarina.Compartilhado;

namespace TestesDonaMarina.ModuloMateria
{
    public class ConfiguracaoToolboxMateria :  ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Materia";

    public override string TooltipInserir { get { return "Inserir uma nova Materia"; } }

    public override string TooltipEditar { get { return "Editar uma Materia existente"; } }

    public override string TooltipExcluir { get { return "Excluir uma Materia existente"; } }

}
}
