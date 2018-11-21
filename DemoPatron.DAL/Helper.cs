using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoPatron.DAL
{
    class Helper
    {
        private readonly string KeyName;
        //nos obtendra el  valor de la llave
        public Helper(string KeyName)
        {
            this.KeyName = KeyName;
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
