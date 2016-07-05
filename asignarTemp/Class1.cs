using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignarDataAccessLayer.AzureADBModel;

namespace AsignarBusinessLayer
{
    public class Class1
    {
        public void Do(int page)
        {
            var dbContext = new AsignarDBModel();

            dbContext.Projects.AsNoTracking().OrderBy(x => x.Name).Skip(9 * page).Take(9).ToList();
        }
    }
}
