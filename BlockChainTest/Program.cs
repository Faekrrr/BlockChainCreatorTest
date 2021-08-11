using Newtonsoft.Json;
using System;

namespace BlockChainTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string sender, receiver; 
            float amount;
            bool ifLoop = true;

            ChainMaker chainmaker = new ChainMaker();

            // Get Data Section
            sender = (string)chainmaker.GetValues("sender");
            receiver = (string)chainmaker.GetValues("receiver");
            amount = float.Parse((string)chainmaker.GetValues("amount"));

            
            
            // BlockChain Creator --- Initializtion & Genesis Block & First Block
            Blockchain newBlockChain = chainmaker.addToChain(chainmaker.createChain(), sender, receiver, amount);
            newBlockChain = chainmaker.addToChain(newBlockChain, sender, receiver, amount);

            ifLoop = (bool)chainmaker.GetValues("ifLoop");

            while (ifLoop)
            {
                sender = (string)chainmaker.GetValues("sender");
                receiver = (string)chainmaker.GetValues("receiver");
                amount = float.Parse((string)chainmaker.GetValues("amount"));

                newBlockChain = chainmaker.addToChain(newBlockChain, sender, receiver, amount);

                ifLoop = (bool)chainmaker.GetValues("ifLoop");
            }

            // Displaying BlockChain
            Displayer Display = new Displayer();
            Display.ShowChain(newBlockChain);

        }
    }
}
