using JsonWebTokens.Core.Models.Dtos;
using JsonWebTokens.Core.Services;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonWebTokens.Service.Services
{
    public class UserService : IUserService
    {
        public Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            throw new NotImplementedException();
        }

        public Task<Response<UserAppDto>> GetUserByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
