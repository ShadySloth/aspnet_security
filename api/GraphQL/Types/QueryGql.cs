namespace api.GraphQL.Types;

[GraphQLName("Query")]
public class QueryGql
{
    public UserGql GetMe() =>
        new UserGql()
        {
            Id = 1,
            FullName = "Alice Smith",
            Email = "alice@example.com",
            AvatarUrl = "https://robohash.org/alice@example.com",
            IsAdmin = true
        };

    public IEnumerable<PostGql> GetPosts([Service] PostService service)
    {
        
    }
}