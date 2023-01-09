using DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA.Providers
{
    public class TestProvider
    {
        public async Task<IEnumerable<vTimeSeries>> LeerVista() 
        {
            try 
            {
                using (AdventureWorksEntities context = new AdventureWorksEntities())
                {
                    return await context.vTimeSeries.ToListAsync();
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }
    }
}
