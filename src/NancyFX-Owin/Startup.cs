using Owin;

namespace NancyFX_Owin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Configure diagnostics
#if DEBUG
            app.UseErrorPage();
#endif

            // Configure Nancy
            app.UseNancy();
        }
    }
}