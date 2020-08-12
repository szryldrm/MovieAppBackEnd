using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.Core.Settings.MSSQLDbSettings
{
    public interface IMSSQLDbSettings
    {
        public string ConnectionString { get; set; }
    }
}
