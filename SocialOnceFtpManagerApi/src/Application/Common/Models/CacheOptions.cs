using System;

namespace Xmigrations.Application.Common.Models
{
    public class CacheOptions
    {
        public string CacheKey { get; set; }
        public TimeSpan ExpirationRelativeToNow { get; set; }
    }
}