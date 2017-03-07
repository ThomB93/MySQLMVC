using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySQLMVC.Startup))]
namespace MySQLMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
