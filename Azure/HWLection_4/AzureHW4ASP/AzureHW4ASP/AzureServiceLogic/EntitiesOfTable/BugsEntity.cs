using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureHW4ASP.AzureServiceLogic.EntitiesOfTable
{
    public class BugsEntity : TableEntity
    {

        public string Description { get; set; }

        public BugsEntity(string bugName, string bugDescription, string assigneeEmail)
        {
            this.PartitionKey = bugName;
            this.RowKey = assigneeEmail;
            this.Description = bugDescription;
        }

        public BugsEntity()
        {

        }
    }
}