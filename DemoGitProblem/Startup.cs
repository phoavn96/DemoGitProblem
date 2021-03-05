using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoGitProblem.Startup))]
namespace DemoGitProblem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
