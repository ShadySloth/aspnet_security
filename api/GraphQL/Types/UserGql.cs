namespace api.GraphQL.Types;

[GraphQLName("User")]
public class UserGql
{
    public int Id { get; set; }
    public String FullName { get; set; }
    public String Email { get; set; }
    public String? AvatarUrl { get; set; }
    public required bool IsAdmin { get; set; }
}