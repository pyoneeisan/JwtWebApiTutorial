using System.Security.Claims;

namespace JwtWebApiTutorial.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor1)
        {
            _httpContextAccessor = httpContextAccessor1;
        }
        public string GetMyName()
        {
            var result = string.Empty;
            if(_httpContextAccessor.HttpContext!=null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
