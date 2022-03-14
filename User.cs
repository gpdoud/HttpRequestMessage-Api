using System.Text.Json.Serialization;
public class User {
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("username")]
    public string? Username { get; set; }  
    [JsonPropertyName("password")]
public string? Password { get; set; }
        [JsonPropertyName("firstname")]

    public string? Firstname { get; set; }
        [JsonPropertyName("lastname")]

    public string? Lastname { get; set; }
        [JsonPropertyName("phone")]

    public string? Phone { get; set; }
        [JsonPropertyName("email")]

    public string? Email { get; set; }
        [JsonPropertyName("isReviewer")]

    public bool IsReviewer { get; set; }
        [JsonPropertyName("isAdmin")]

    public bool IsAdmin { get; set; }

}