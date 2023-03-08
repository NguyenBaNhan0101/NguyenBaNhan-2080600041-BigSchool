using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenBaNhan_2080600041.Startup))]
namespace NguyenBaNhan_2080600041
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
