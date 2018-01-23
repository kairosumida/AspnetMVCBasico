using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aula08.Startup))]
namespace Aula08
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
