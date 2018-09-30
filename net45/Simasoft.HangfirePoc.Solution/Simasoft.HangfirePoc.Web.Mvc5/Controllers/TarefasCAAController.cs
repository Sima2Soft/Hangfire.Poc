using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hangfire;
using Simasoft.HangfirePoc.Tarefas.Concessionarias;
using Simasoft.HangfirePoc.Tarefas.Concessionarias.Interfaces;

namespace Simasoft.HangfirePoc.Web.Mvc5.Controllers
{
    [Queue("caa")]
    public class TarefasCAAController : Controller
    {
        private readonly ITarefasCAA tarefasCaa = new TarefasCAA();
        
        //
        // GET: /TarefasCAA/
        public ActionResult Index()
        {
            return View();
        }

        [Queue("caa")]    
        public void TarefasExecuteEEsqueca()
        {
            BackgroundJob.Enqueue(() => tarefasCaa.ExecutaHoraDoDia());
        }

        [Queue("caa")]
        internal void TarefasContinuadasComplexas()
        {
            var etapa1 = BackgroundJob.Enqueue(() => tarefasCaa.SomaMais(300));
            var etapa2 = BackgroundJob.ContinueWith(etapa1, () => tarefasCaa.SomaMais(301));
        }

        [Queue("caa")]
        internal void ExecutarTarefasComRetardo()
        {
            BackgroundJob.Schedule(() => tarefasCaa.SomaMais(2), TimeSpan.FromMinutes(30));
            BackgroundJob.Schedule(() => tarefasCaa.SomaMais(4), TimeSpan.FromMinutes(60));
            BackgroundJob.Schedule(() => tarefasCaa.SomaMais(3), TimeSpan.FromMinutes(91));
        }

        [Queue("caa")]
        internal void TarefasRecorrentes()
        {
            RecurringJob.AddOrUpdate(() => tarefasCaa.SomaMais(10), "*/5 * * * *");
        }
	}
}