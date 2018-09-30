using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simasoft.HangfirePoc.Tarefas.Concessionarias.Interfaces
{
    public interface ITarefasCAA
    {
        DateTime ExecutaHoraDoDia();

        int SomaMais(int valor);

    }
}
