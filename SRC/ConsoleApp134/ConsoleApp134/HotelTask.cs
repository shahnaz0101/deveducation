using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp134
{
    public class Hotel
    {
        public string Name { get; set; }
        public List <Client> clients { get; set; }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
        public void SaveToFile()
        {

        }
    }
    public class Client
    {        

    }
    public class PremiumClient : Client
    {

    }
    public class StandartClient : Client
    {

    }
}
