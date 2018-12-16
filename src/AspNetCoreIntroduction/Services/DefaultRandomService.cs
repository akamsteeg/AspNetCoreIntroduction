using System;

namespace AspNetCoreIntroduction.Services
{
    public sealed class DefaultRandomService : IRandomService
    {
        private readonly int _randomValue;

        public DefaultRandomService()
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
