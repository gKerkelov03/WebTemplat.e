namespace Template.Services;

using System;
using Template.Services.Contracts;

public class RandomService : IRandomService
{
    private Random randomGenerator;

    public RandomService() => this.randomGenerator = new Random();
    
    public int Next() => this.randomGenerator.Next();

    public int Next(int min, int max) => this.randomGenerator.Next(min, max);
    
    public double NextDouble(int min, int max) 
        => min + this.randomGenerator.NextDouble() * (max - min);
}
