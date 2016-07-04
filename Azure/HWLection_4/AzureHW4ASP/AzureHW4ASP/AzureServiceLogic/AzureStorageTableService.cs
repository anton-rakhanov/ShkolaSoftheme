using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using AzureHW4ASP.AzureServiceLogic.EntitiesOfTable;

namespace AzureHW4ASP.AzureServiceLogic
{
    public class AzureStorageTableService
    {

        public CloudTable Table { get; set; }

        public AzureStorageTableService()
        {
            string appSetting = CloudConfigurationManager.GetSetting("AzureHW4Storage");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(appSetting);

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            Table = tableClient.GetTableReference("Bugs");
            Table.CreateIfNotExists();
        }

        public void InsertEntity(BugsEntity newBug)
        {
            var insertOperation = TableOperation.Insert(newBug);
            Table.Execute(insertOperation);
        }
    }
}