using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Todo.MVC.Startup))]
namespace Todo.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
