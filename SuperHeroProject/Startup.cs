using Microsoft.Owin;
using Owin;
using SuperHeroProject.Models;

[assembly: OwinStartupAttribute(typeof(SuperHeroProject.Startup))]
namespace SuperHeroProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
        }
    }
}
