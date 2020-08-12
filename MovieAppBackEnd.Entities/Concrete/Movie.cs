using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MovieAppBackEnd.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MovieAppBackEnd.Core.Settings;

namespace MovieAppBackEnd.Entities.Concrete
{
    [System.Serializable]
    [BsonCollection("Movie")]
    public class Movie : IDocument
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("title")]
        public string title { get; set; }
        [BsonElement("cover")]
        public string cover { get; set; }
    }
}
