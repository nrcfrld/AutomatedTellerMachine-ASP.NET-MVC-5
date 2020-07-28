using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATMBankMVC.Startup))]
namespace ATMBankMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
