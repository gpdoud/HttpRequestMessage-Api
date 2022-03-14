
var user = new User() {
    Id = 0, Username = "XX11", Password = "XX",
    Firstname = "XX", Lastname = "XX",
    Phone = "XX", Email = "XX",
    IsReviewer = false, IsAdmin = false
};

HttpRequestMessage request = new HttpRequestMessage {
    Method = HttpMethod.Post,

    RequestUri = new Uri("http://doudsystems.com/prs5db/api/users"),
    Content = new StringContent(System.Text.Json.JsonSerializer.Serialize<User>(user), 
                                System.Text.Encoding.UTF8,
                                "application/json")
};
using HttpClient client = new HttpClient();
var response = await client.SendAsync(request).ConfigureAwait(true);
response.EnsureSuccessStatusCode();
var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
Console.WriteLine(responseBody);