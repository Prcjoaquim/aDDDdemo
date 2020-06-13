using System;
using System.Collections.Generic;
using System.Text;
using WebSolution01.Domain.Models;

namespace WebSolution01.Domain.Repository
{
    public interface IClientRepository
    {
        List<Client> GetAll();

        Client Save(Client client);
    }
}
