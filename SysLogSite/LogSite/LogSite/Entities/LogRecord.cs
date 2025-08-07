using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogSite.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instante { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = (LogRecord)obj;
            return Username.Equals(other.Username);
        }
    }
}
