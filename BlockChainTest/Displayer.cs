using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainTest
{
    public class Displayer
    {
        public void ShowChain(Blockchain BlockChain)
        => Console.WriteLine(JsonConvert.SerializeObject(value: BlockChain, Formatting.Indented));
    }
}
