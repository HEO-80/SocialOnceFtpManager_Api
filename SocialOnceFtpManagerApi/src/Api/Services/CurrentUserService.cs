using EAProductService.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace EAProductService.Api.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private const string ClaimTypeUserId = "http://schemas.microsoft.com/identity/claims/objectidentifier";
        private const string ClaimTypeEmail = "emails";
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserId { get { return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypeUserId); } }
        public string SessionId { get { return _httpContextAccessor.HttpContext?.Session?.Id; } }
        public string Email { get { return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypeEmail); } }
        //public string UserId { get; }
    }
}
