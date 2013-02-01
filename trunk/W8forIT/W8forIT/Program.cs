using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8forIT
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            if (args.Length > 0)
            {
                client.ConnectToServer(args[0], "{\"turn\":0,\"hire\":[0,0,0],\"move\":[],\"dojob\":[],\"fire\":[]}");
                //client.ConnectToServer("{\"turn\":0,\"hire\":[0,0,0],\"move\":[],\"dojob\":[],\"fire\":[]}");
                Console.ReadKey();
            }
        }
    }
}
