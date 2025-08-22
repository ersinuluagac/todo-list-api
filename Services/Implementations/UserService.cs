using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Services.Contracts;

namespace Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> RegisterUserAsync(UserDtoForRegistration userDto)
        {
            var entity = new User()
            {
                Email = userDto.Email,
                UserName = userDto.UserName,
            };

           var result = await _userManager
                .CreateAsync(entity, userDto.Password);

            await _userManager
                .AddToRolesAsync(entity, new List<string> { "User" });

            return result;
        }
    }
}
