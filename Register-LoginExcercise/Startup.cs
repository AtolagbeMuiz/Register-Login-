using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Register_LoginExcercise.Startup))]
namespace Register_LoginExcercise
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
