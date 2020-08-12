using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppBackEnd.Core.Settings.MSSQLDbSettings
{
    public class MSSQLDbSettings : IMSSQLDbSettings
    {
        public string ConnectionString { get; set; }
    }
}
