using ECommerceApi.Application.Interfaces.RedisCache;
 using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Infrastructure.RedisCache
{
    public class RedisCacheService : IRedisCacheService
    {
        private readonly ConnectionMultiplexer connectionMultiplexer;

        private readonly IDatabase database;

        private readonly RedisCacheSettings cacheSettings;
        public RedisCacheService(IOptions<RedisCacheSettings> options)
        {
            cacheSettings = options.Value;
            var opt = ConfigurationOptions.Parse(cacheSettings.ConnectionString);
            connectionMultiplexer=ConnectionMultiplexer.Connect(opt);
            database= connectionMultiplexer.GetDatabase();
        }
         
        public async Task<T> GetAsync<T>(string key)
        {
          var value=await database.StringGetAsync(key);
            if (value.HasValue)
                return  JsonConvert.DeserializeObject<T>(value);
            return default; 
        }

        public async Task SetAsync<T>(string key, T value, DateTime? expirationTime)
        {
              TimeSpan expirationTimeUnit = expirationTime.Value - DateTime.Now;

             await database.StringSetAsync(key,JsonConvert.SerializeObject(value), expirationTimeUnit);
        }
    }
}
