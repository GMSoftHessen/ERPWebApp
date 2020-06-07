using System;
// These namespaces are required.  
using Microsoft.SqlServer.Replication;
using Microsoft.SqlServer.Management.Common;
using System.Data.Common;


namespace Business.Layer
{
    public class Replication
    {
        public void replication()
        {
            // Set the server and database names
            string distributionDbName = "TestDb";
            string publisherName = "DESKTOP-9UAIISP\\MSSQLSERVER2017";
            string publicationDbName = "TestMergeDb";

            DistributionDatabase distributionDb;
            ReplicationServer distributor;
            DistributionPublisher publisher;
            ReplicationDatabase publicationDb;

            // Create a connection to the server using Windows Authentication.
            ServerConnection conn = new ServerConnection(publisherName, "sa", "Ads78ghj@2");

            try
            {
                // Connect to the server acting as the Distributor 
                // and local Publisher.
                conn.Connect();

                // Define the distribution database at the Distributor,
                // but do not create it now.
                distributionDb = new DistributionDatabase(distributionDbName, conn);
                distributionDb.MaxDistributionRetention = 96;
                distributionDb.HistoryRetention = 120;

                // Set the Distributor properties and install the Distributor.
                // This also creates the specified distribution database.
                distributor = new ReplicationServer(conn);
                distributor.InstallDistributor("sa", distributionDb);

                // Set the Publisher properties and install the Publisher.
                publisher = new DistributionPublisher(publisherName, conn);
                publisher.DistributionDatabase = distributionDb.Name;
                publisher.WorkingDirectory = @"\\" + publisherName + @"\repldata";
                publisher.PublisherSecurity.WindowsAuthentication = true;
                publisher.Create();

                // Enable AdventureWorks2012 as a publication database.
                publicationDb = new ReplicationDatabase(publicationDbName, conn);

                publicationDb.EnabledTransPublishing = true;
                publicationDb.EnabledMergePublishing = true;
            }
            catch (Exception ex)
            {
                // Implement appropriate error handling here.
                throw new ApplicationException("An error occured when installing distribution and publishing.", ex);
            }
            finally
            {
                conn.Disconnect();
            }
        }
    }
}
