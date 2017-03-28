using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyDealUrlShortner.Startup))]
namespace MyDealUrlShortner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
