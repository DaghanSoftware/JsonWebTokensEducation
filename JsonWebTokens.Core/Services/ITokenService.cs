using JsonWebTokens.Core.Configuration;
using JsonWebTokens.Core.Models.Dtos;
using JsonWebTokens.Core.Models.Entities;

namespace JsonWebTokens.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userapp);

        ClientTokenDto CreateTokenByClient(Client client);
    }
}
