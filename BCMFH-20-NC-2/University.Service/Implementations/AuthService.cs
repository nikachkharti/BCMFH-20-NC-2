using University.Models.Dtos.Identity;
using University.Service.Interfaces;

namespace University.Service.Implementations
{
    public class AuthService : IAuthService
    {
        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task Register(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task RegisterAdmin(RegistrationRequestDto registrationRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
