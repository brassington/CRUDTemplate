using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDTemplate.Startup))]
namespace CRUDTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
