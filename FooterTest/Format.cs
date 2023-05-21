using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooterTest
{
    internal struct CookieFormat
    {
        internal string Host;

        internal string Name;

        internal string Path;

        internal string Cookie;

        internal ulong Expiry;

        internal CookieFormat(string host, string name, string path, string cookie, ulong expiry)
        {
            Host = host;
            Name = name;
            Path = path;
            Cookie = cookie;
            Expiry = expiry;
        }
    }
}
