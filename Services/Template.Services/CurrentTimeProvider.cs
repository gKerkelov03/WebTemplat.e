using System;
using Template.Services.Common;
using Template.Services.Contracts;

namespace Template.Services
{
    public class CurrentTimeProvider : ICurrentTimeProvider
    {
        public DateTime Now => DateTime.Now;
    }
}
