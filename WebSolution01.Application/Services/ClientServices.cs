using System.Collections.Generic;
using WebSolution01.Application.Interfaces;
using WebSolution01.Domain.Models;
using WebSolution01.Domain.Repository;

namespace WebSolution01.Application.Services
{
    public class ClientServices : IClientServices
    {
        private readonly IClientRepository _clientRepository;

        public ClientServices(IClientRepository clientRepository)
        {
            this._clientRepository = clientRepository;
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }

        public Client Save(Client client)
        {
            return _clientRepository.Save(client);
        }
    }
}
