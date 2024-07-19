using RandomNameGeneratorLibrary;
using System.Text.Json;

public class UserService
{

  public User[] GetAllUsers()
  {
    var forecast = Enumerable.Range(1, 5).Select(index =>
    {
      var userName = new PersonNameGenerator().GenerateRandomFirstName();
      var email = userName + "@email.com";
      return new User(Random.Shared.Next(1, 55), userName, email);
    })
    .ToArray();

    return forecast;
  }
}
