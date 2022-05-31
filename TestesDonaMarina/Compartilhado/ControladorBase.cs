
using System.Windows.Forms;

namespace TestesDonaMarina.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract void Inserir();
        public virtual void Editar() { }
        public abstract void Excluir();
        public abstract UserControl ObtemListagem();

        public abstract ConfiguracaoToolboxBase ObtemConfiguracaoToolbox();
    }
}
