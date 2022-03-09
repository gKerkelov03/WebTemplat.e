using System;
using Template.Services.Common;

namespace Template.Services.Contracts
{
    public interface ICurrentTimeProvider : ITransientService
    {
        DateTime Now { get; }
    }
}
