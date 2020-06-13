using System;
using System.Collections.Generic;
using System.Text;
using WebSolution01.Domain.Models;

namespace WebSolution01.Application.Interfaces
{
    public interface IClientServices
    {
        List<Client> GetAll();

        Client Save(Client client);
    }
}
