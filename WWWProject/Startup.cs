using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WWWProject.Startup))]
namespace WWWProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
