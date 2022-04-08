using EAProductService.Application.Common.Interfaces;
using System;

namespace EAProductService.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
