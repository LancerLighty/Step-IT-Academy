using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Interfaces
{
    internal interface IClianteService
    {
        Client Get(int id);
        List<Client> GetAll();
        List<Client> Create(Client client);
        List<Client> Delete(int id);
        List<Client> Update(Client client);

    }
}
