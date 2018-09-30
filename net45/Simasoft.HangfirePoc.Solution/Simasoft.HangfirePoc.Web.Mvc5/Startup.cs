using System;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.Owin;
using Owin;
using Simasoft.HangfirePoc.Web.Mvc5.Controllers;
using Simasoft.HangfirePoc.Web.Mvc5.Models;

[assembly: OwinStartup(typeof(Simasoft.HangfirePoc.Web.Mvc5.Startup))]

namespace Simasoft.HangfirePoc.Web.Mvc5
{
    public class Startup
    {
        //Seconds |Minutes| Hours	|Day Of Month|	Month|	Day Of Week|	Year
        //0/5 0 0 ? * * *
        //0/5 0 0 ? * * 2018        
        private readonly TarefasCAAController tarefasCaa = new TarefasCAAController();
        public void Configuration(IAppBuilder app)
        {
            var opcoes = new BackgroundJobServerOptions
            {
                Queues = new[] { "caa" }
            };

            GlobalConfiguration.Configuration
                .UseSqlServerStorage("HangFirePocMSSQL");

            /*
            app.UseHangfireDashboard("/MeuPrimeiroDashboard", new DashboardOptions()
            {            
                Authorization = new [] {new HangfireAuthorizationFilter()}
            });
             */

            app.UseHangfireServer(opcoes);
            
            tarefasCaa.TarefasExecuteEEsqueca();

            tarefasCaa.ExecutarTarefasComRetardo();
            tarefasCaa.TarefasRecorrentes();
            tarefasCaa.TarefasContinuadasComplexas();


            /**
            TarefasExecuteEEsqueca();
            TarefasComRetardo();
            TarefasRecorrentes();
            TarefasContinuadasComplexas();
             **/            
        }
    }
}
