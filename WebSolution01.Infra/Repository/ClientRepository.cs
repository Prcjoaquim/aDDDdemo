using System;
using System.Collections.Generic;
using System.Text;
using WebSolution01.Domain.Models;
using WebSolution01.Domain.Repository;

namespace WebSolution01.Infra.Repository
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> GetAll()
        {
            return BaseDados.GetInstance().Clients;
        }

        public Client Save(Client client)
        {
            BaseDados.GetInstance().Clients.Add(client);
            return client;
        }
    }

    public class BaseDados
    {
        private static BaseDados _instance;

        public List<Client> Clients { get; set; }
        private BaseDados()
        {  
            this.Clients = new List<Client>();
        }

        public static BaseDados GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BaseDados();
            }
            return _instance;
        }

    }
}
