using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaintBallManager.Startup))]
namespace PaintBallManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
