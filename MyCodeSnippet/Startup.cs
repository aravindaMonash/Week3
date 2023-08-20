using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyCodeSnippet.Startup))]
namespace MyCodeSnippet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
