using System;

namespace AspNetCoreIntroduction.Services
{
    public sealed class RandomGeneratorService
    {
        private readonly int _randomValue;

        public RandomGeneratorService()
        {
            var random = new Random();

            this._randomValue = random.Next();
        }

        public int GetValue()
        {
            return this._randomValue;
        }
    }
}
