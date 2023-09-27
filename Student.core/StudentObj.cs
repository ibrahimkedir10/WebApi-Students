using MongoDB.Bson.Serialization.Attributes;


namespace Student.core
{
    public class StudentObj
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

    }
}
