using ConsoleApp9.Interfaces;
using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Implemetations
{
    class ClientService : IClianteService
    {
        private List<Client> clients = new List<Client>();
        public List<Client> Create(Client client)
        {
            clients.Add(client);
            return clients;
        }

        public List<Client> Delete(int id)
        {
            Client? client = clients.FirstOrDefault(x => x.Id == id);
            if(client == null)
            {
                throw new Exception("client not found");
            }
            clients.Remove(client);
            return clients;
        }

        public Client Get(int id)
        {
            Client? client = clients.FirstOrDefault(x => x.Id == id);
            if (client == null)
            {
                throw new Exception("client not found");
            }
            return client;
        }

        public List<Client> GetAll()
        {
            return clients;
        }

        public List<Client> Update(Client client)
        {
            Client? client2 = clients.FirstOrDefault(x => x.Id == client.Id);
            if (client2 != null)
            {
                client2.FirstName = client.FirstName;
                client2.LastName = client.LastName;
            }
            return clients;
        }
    }
}
