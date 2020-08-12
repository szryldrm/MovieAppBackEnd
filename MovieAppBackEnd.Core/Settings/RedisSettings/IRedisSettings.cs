using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.Core.Settings
{
    public interface IRedisSettings
    {
        string RedisHostIP { get; set; }
        string RedisPort { get; set; }
    }
}
