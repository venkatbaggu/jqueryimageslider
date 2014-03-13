using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JQueryImageSlider.Startup))]
namespace JQueryImageSlider
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
