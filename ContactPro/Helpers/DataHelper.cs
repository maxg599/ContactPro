using ContactPro.Data;
using Microsoft.EntityFrameworkCore;

namespace ContactPro.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //get an instance of db application context//
            var dbContextSvc = svcProvider.GetRequiredService<Data.ApplicationDbContext>();

            //migration: this is equivalent to update-database in nuget//
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
