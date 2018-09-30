using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hangfire.Annotations;
using Hangfire.Dashboard;

namespace Simasoft.HangfirePoc.Web.Mvc5.Models
{
    internal sealed class HangfireAuthorizationFilter: IDashboardAuthorizationFilter
    {
        //TODO: Criar classes que façam uso de PrincipalContext para que possamos:
        //1. Autenticar de uma máquina local
        //2. Autenticar de um Active Directory

        public bool Authorize([NotNull]DashboardContext context)
        {
            return HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}