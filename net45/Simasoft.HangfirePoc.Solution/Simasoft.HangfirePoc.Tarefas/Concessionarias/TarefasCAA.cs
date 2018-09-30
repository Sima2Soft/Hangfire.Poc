using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simasoft.HangfirePoc.Tarefas.Concessionarias.Interfaces;

namespace Simasoft.HangfirePoc.Tarefas.Concessionarias
{
    public class TarefasCAA : ITarefasCAA
    {

        private int soma = 0;
        
        public DateTime ExecutaHoraDoDia()
        {
            return DateTime.Now;
        }

        public int SomaMais(int valor)
        {
            return soma += valor;
        }
    }
}
