using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobCardV13.Startup))]
namespace JobCardV13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
