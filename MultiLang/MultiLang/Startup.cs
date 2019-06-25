using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiLang.Startup))]
namespace MultiLang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
