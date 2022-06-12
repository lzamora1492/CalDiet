using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalDiet.Startup))]
namespace CalDiet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
