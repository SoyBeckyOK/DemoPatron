using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoPatron.RepositoryDapper
{
    class Helper
    {
        private readonly string KeyName;
        public Helper(string keyName) //nos obtendra el  valor de la llave
        {
            this.KeyName = keyName;
        }


        //configuration Builder 
        public string GetConnectionString()
        {
            var Configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return Configuration.GetConnectionString(KeyName);
        }
    }
}
