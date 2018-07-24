using Owin;
using System.Web.Http;

namespace Mentorship.Automation.Jobs
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            app.MapSignalR();
        }
    }
}
