using Entities.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(UserDtoForRegistration userDto);
    }
}
