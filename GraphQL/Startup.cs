using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GraphQL.Startup))]
namespace GraphQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
