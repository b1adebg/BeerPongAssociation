using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeerPongAssociation.Startup))]
namespace BeerPongAssociation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
