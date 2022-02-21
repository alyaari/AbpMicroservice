using Xunit;

namespace Tasky.Identity.MongoDB;

[CollectionDefinition(Name)]
public class MongoTestCollection : ICollectionFixture<MongoDbFixture>
{
    public const string Name = "MongoDB Collection";
}
