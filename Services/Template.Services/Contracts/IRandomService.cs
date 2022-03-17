namespace Template.Services.Contracts;

using Template.Services.Common;

public interface IRandomService : ITransientService
{
    int Next();
    int Next(int min, int max);
    double NextDouble(int min, int max);
}
