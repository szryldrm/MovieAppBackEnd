using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.Core.Settings
{
    public class RedisSettings : IRedisSettings
    {
        public string RedisHostIP { get; set; }
        public string RedisPort { get; set; }
    }
}
