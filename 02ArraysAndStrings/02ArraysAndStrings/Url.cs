using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ArraysAndStrings
{
    public class Url
    {
        public static void Parse(string s)
        {
            string[] sb = s.Split(':');
            string protocol = "";
            string resource = "";
            string server = "";
            string[] servers = new string[2];
            if (sb.Length > 1)
            {
                protocol = sb[0];
                sb[1] = sb[1].Trim('/');
                servers = sb[1].Split("/");
            }
            else
            {
                sb[0] = sb[0].Trim('/');
                //Console.WriteLine(sb[1]);
                servers = sb[0].Split("/");
            }
            server = servers[0];
            if (servers.Length >= 2) { resource = servers[1]; }
            Console.WriteLine($"[protocol] = \"{protocol }\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}
