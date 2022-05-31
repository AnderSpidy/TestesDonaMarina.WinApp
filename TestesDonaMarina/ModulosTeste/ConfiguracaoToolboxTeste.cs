using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesDonaMarina.Compartilhado;

namespace TestesDonaMarina.ModulosTeste
{
    public class ConfiguracaoToolboxTeste : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Testes";

        public override string TooltipInserir { get { return "Gerar um teste"; } }

        public override string TooltipExcluir { get { return "Excluir um teste"; } }

        public override bool EditarHabilitado => false;

        public override bool VisualizarDetalhesHabilitado => true;

        public override bool DuplicarHabilitado => true;

        public override bool GerarPdfHabilitado => true;

        public override string TooltipDuplicar { get { return "Duplicar um teste"; } }

        public override string TooltipGerarPdf { get { return "Gerar PDF"; } }

        public override string TooltipEditar { get { return "Editar Teste"; } }
    }
}
