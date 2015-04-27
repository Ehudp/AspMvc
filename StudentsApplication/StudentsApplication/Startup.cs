using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentsApplication.Startup))]
namespace StudentsApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
