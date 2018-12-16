using System;

namespace AspNetCoreIntroduction.Services
{
    public sealed class DefaultRandomService : IRandomService
    {
        private readonly RandomGeneratorService _randomGenerator;

        public DefaultRandomService(RandomGeneratorService randomGenerator)
        {

            this._randomGenerator = randomGenerator ?? throw new ArgumentNullException(nameof(randomGenerator));
        }

        public int GetValue()
        {
            var result = this._randomGenerator.GetValue();

            return result;
        }
    }
}
