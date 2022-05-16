using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesDonaMarina.Dominio.ModuloQuestao
{
    public class AlternativasQuestao
    {
        public string Descricao { get; set; }

        public bool Correta { get; set; }
        
        public override string ToString()
        {
            return Descricao;
        }

        public void Concluir()
        {
            Correta = true;
        }

        //internal void MarcarPendente()
        //{
        //    Correta = false;
        //}
    }
}
