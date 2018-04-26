using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace MongoInserter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            IMongoDatabase db = client.GetDatabase("DotNetCore");

            IMongoCollection<BsonDocument> collection = db.GetCollection<BsonDocument>("docs");

            var document = new BsonDocument
            {
                {"theKey", "theValue" }
            };

            collection.InsertOne(document);
        }
    }
}
