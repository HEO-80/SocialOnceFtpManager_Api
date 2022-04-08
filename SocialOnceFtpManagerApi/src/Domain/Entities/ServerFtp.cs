using System;
using System.Collections.Generic;
using System.Text;

namespace EAProductService.Domain.Entities
{
    public class ServerFtp
    {

        public int Id { get; set; }
        
        public string Host { get; set; }

        public int Port { get; set; }

        public string Password { get; set; }

        public string ConnectionStatus { get; set; }

        public bool IsConnected { get; set; }

        public string ConnectionName { get; set; }
        private string _connectionName { get; set; }
        public string ConnectionNameTo { get { return _connectionName; } set { _connectionName = value; } }
        public string ConnectionType { get; set; }


    }
}
