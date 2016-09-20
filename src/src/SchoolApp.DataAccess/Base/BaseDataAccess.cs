using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using SchoolApp.DataAccess.Base;
using SchoolApp.Data.Base;

namespace SchoolApp.DataAccess
{
    public class BaseDataAccess
    {
        protected MongoClient _client;
        protected IMongoDatabase mongoDatbase = null;

        public BaseDataAccess()
        {
            InitializeMongoDatabase();
        }


        private void InitializeMongoDatabase()
        {
            try
            {
                var mongoDbConnString = ConnectionSettingsReader.ReadConnectionSettings();
                var client = new MongoClient(GetConnectionString(mongoDbConnString));
                mongoDatbase = client.GetDatabase(mongoDbConnString.DatabaseName);
            }
            catch (Exception ex) { /*Logger.Error(ex, "InitializeMongoDatabase");*/ mongoDatbase = null; throw; }
        }

        protected string GetConnectionString(ConnectionSettings mongoDbConnString )
        {

            if (!(string.IsNullOrEmpty(mongoDbConnString.UserName) || string.IsNullOrEmpty(mongoDbConnString.Password)
            || string.IsNullOrEmpty(mongoDbConnString.MongoDBClusterIP) || string.IsNullOrEmpty(mongoDbConnString.DatabaseName)))
            {
                string _connectionString = string.Format("mongodb://{0}:{1}@{2}:{3}/{4}", mongoDbConnString.UserName, mongoDbConnString.Password,
                mongoDbConnString.MongoDBClusterIP, mongoDbConnString.PortNumber, mongoDbConnString.DatabaseName);

                return _connectionString;
            }
            else { throw new Exception("MongoDB Cluster IP is not set."); }
        }

   
    }
}
