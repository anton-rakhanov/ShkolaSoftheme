using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsignarDataAccessLayer.AzureSQLRepository;
using AsignarDataAccessLayer.AzureADBModel;
using DTOModels.DTOs;

namespace AsignarBusinessLayer
{
    public class TestRoute
    {
        public void ChectRouteFromViewToDAL()
        {
            var projectRep = new ProjectRepository();

            var proj4 = new Project();
            proj4.Name = "The Deep";
            proj4.Prefix = "TDP";
            proj4.IsDeleted = false;

            var proj5 = new Project();
            proj5.Name = "The Fell Land";
            proj5.Prefix = "TFL";
            proj5.IsDeleted = false;

            var proj6 = new Project();
            proj6.Name = "The Helium Expo";
            proj6.Prefix = "THE";
            proj6.IsDeleted = false;

            var result1 = projectRep.GetItem(1);
            var result2 = projectRep.GetItem(2);
            var result3 = projectRep.GetItem(3);

            projectRep.Create(proj4);
            projectRep.Create(proj5);
            projectRep.Create(proj6);

            var proj7 = new Project();
            proj7.Name = "The Omnonmomus";
            proj7.Prefix = "TFL";
            proj7.IsDeleted = false;

            projectRep.Update(proj7);

            projectRep.Delete(6);

            var listResult = projectRep.GetItemsList();
        }
    }
}
