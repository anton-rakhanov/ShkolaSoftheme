using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender.AzureQueueService
{
    public class QueueService
    {
        public CloudQueue Queue { get; set; }

        public QueueService()
        {
            string appSetting = CloudConfigurationManager.GetSetting("AzureHW4Storage");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(appSetting);

            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            Queue = queueClient.GetQueueReference("BugMessages");
            Queue.CreateIfNotExists();
        }

        public string GetQueueSasUri(CloudQueue queue)
        {
            var sasConstraints = new SharedAccessQueuePolicy { SharedAccessExpiryTime = DateTime.UtcNow.AddHours(1), Permissions = SharedAccessQueuePermissions.ProcessMessages | SharedAccessQueuePermissions.Read };
            string sasContainerToken = queue.GetSharedAccessSignature(sasConstraints);

            return queue.Uri + sasContainerToken;
        }

        public CloudQueueMessage GetMessageBySAS(string sasUrl)
        {
            var queue = new CloudQueue(new Uri(sasUrl));
            CloudQueueMessage message = queue.GetMessage();

            return message;
        }
    }
}
