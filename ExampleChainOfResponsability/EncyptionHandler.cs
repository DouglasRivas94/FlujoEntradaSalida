using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleChainOfResponsability
{
    public class EncyptionHandler : FileHandler
    {
        public override void Handler(string filePath, string data)
        {
            string encryptedData = Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }
    }
}
