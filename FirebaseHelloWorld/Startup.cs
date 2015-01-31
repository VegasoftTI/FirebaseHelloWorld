using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirebaseHelloWorld.Startup))]
namespace FirebaseHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
