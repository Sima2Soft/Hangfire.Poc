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
    public class TarefasController : Controller
    {
        private readonly ITarefasCAA tarefasCaa = new TarefasCAA();
        //
        // GET: /Tarefas/
        public ActionResult Index()
        {
            return View();
        }

        public void TarefasExecuteEEsqueca()
        {
            BackgroundJob.Enqueue(() => tarefasCaa.ExecutaHoraDoDia());            
        }

        internal void TarefasComRetardo()
        {
            
        }

        internal void TarefasRecorrentes()
        {
            RecurringJob.AddOrUpdate(() => tarefasCaa.SomaMais(10), "*/5 * * * *", null);
        }

        internal void TarefasContinuadasComplexas()
        {
            var etapa1 = BackgroundJob.Enqueue(() => tarefasCaa.SomaMais(300));
            var etapa2 = BackgroundJob.ContinueWith(etapa1,() => tarefasCaa.SomaMais(301));
        }
    }
}