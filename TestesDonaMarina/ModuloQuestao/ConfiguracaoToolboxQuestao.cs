using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMarina.Compartilhado;

namespace TestesDonaMarina.ModuloQuestao
{
    public class ConfiguracaoToolboxQuestao : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Cadastro de Questão";

        public override string TooltipInserir { get { return "Inserir uma nova Qusestão"; } }

        public override string TooltipEditar { get { return "Editar Questões de uma Matéria"; } }

        public override string TooltipExcluir { get { return "Excluir Questões de uma Matéria "; } }

    }
}
