using System;
using System.Collections.Generic;
using MongoDB.Driver;
using test4.Models;

namespace test4.Services
{
    public class PressureService
    {
        private readonly IMongoCollection<Pressures> _pressures;

        public PressureService(Models.IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _pressures = database.GetCollection<Pressures>("Pressure");
        }
        public Pressures Create(Pressures pressures)
        {
            _pressures.InsertOne(pressures);
            return pressures;
        }

        public IList<Pressures> Read() =>
                _pressures.Find(pres=>true).ToList();

        
    }
}

