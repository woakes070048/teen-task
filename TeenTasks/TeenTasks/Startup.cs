using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeenTasks.Startup))]
namespace TeenTasks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
