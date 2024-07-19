// using Microsoft.AspNetCore.Mvc;

// // Assuming your controllers are in a namespace called "APO.Controllers"
// namespace c_api.Controllers
// {
//   [ApiController]
//   [Route("[controller]")]
//   public class UserController : ControllerBase
//   {
//     // Ideally, inject a service related to user management here
//     private readonly UserService _userService = new UserService();

//     // public UserController()  // Constructor with dependency injection
//     // {

//     // }

//     [HttpGet(Name = "gas")]
//     public User[] Get()
//     {
//       return _userService.GetAllUsers();
//     }
//   }
// }
