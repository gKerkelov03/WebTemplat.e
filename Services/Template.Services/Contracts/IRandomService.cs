
using Template.Services.Common;

namespace Template.Services.Contracts
{
    public interface IRandomService : ITransientService
    {
        int Next();
        int Next(int min, int max);
        double NextDouble(int min, int max);
    }
}
