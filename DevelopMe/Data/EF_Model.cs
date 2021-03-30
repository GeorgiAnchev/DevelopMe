using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopMe.Data
{
    public static class EF_Model
    {

        public static ApplicationDbContext dbContext = null;

        public static void Initialize_DbContext_in_Startup(IServiceProvider serviceProvider)

        {
            IServiceScope serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();

            dbContext = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

            //--------< Initialize_DbContext_in_Startup() >--------

        }
    }
}
