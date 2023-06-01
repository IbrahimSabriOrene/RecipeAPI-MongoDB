using DBContext.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.DbConnections;
public class DBConnection
{
    private readonly IConfiguration _configuration;
    private IMongoDatabase _db;
    public DBConnection( IConfiguration configuration )
    {
        _configuration = configuration;
        var connectionString = _configuration.GetConnectionString( "Database:DefaultConnection" );
        var databaseName = _configuration["Database:dbName"];
        var collectionName = _configuration[ "Database:dbCollectionName" ];

        var client = new MongoClient( connectionString );
        _db = client.GetDatabase( databaseName );
        _db.GetCollection<Recipe>( collectionName );

    }
    //TODO: CRUD Operaions connected to MongoDB => API


}