namespace Template.Services;

using System;
using Template.Services.Contracts;

public class CurrentTimeProvider : ICurrentTimeProvider
{
    public DateTime Now => DateTime.Now;
}
