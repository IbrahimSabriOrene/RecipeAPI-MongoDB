using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext.Models;
public class Categories
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public int Id { get; set; }
    public string Dishes { get; set; }
    public string Desserts { get; set; }
    public string Soups { get; set; }

}
