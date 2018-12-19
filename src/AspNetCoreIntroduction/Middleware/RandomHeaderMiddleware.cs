using AspNetCoreIntroduction.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace AspNetCoreIntroduction.Middleware
{
    public class RandomHeaderMiddleware
    {
        private readonly RequestDelegate _nextMiddleware;
        private RandomGeneratorService _randomGenerator;

        public RandomHeaderMiddleware(RequestDelegate next, RandomGeneratorService randomGenerator)
        {
            this._nextMiddleware = next;
            this._randomGenerator = randomGenerator ?? throw new ArgumentNullException(nameof(randomGenerator));
        }

        public async Task Invoke(HttpContext context)
        {
            context.Response.Headers.Add("x-Random", this._randomGenerator.GetValue().ToString());

            await this._nextMiddleware?.Invoke(context);
        }
    }
}
