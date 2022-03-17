namespace Template.Services.Contracts;

using System;
using Template.Services.Common;

public interface ICurrentTimeProvider : ITransientService
{
    DateTime Now { get; }
}
