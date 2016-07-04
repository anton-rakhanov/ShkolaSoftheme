using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace AzureHW4ASP.AzureServiceLogic
{
    public class AzureStorageQueueService
    {
        public CloudQueue Queue { get; set; }

        public AzureStorageQueueService()
        {
            string appSetting = CloudConfigurationManager.GetSetting("AzureHW4Storage");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(appSetting);

            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            Queue = queueClient.GetQueueReference("BugMessages");
            Queue.CreateIfNotExists();
        }

        public void AddMessage(string emailAdress)
        {
            var message = new CloudQueueMessage(emailAdress);
            Queue.AddMessage(message);
        }
    }
}