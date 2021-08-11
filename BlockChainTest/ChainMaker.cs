using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainTest
{
    public class ChainMaker
    {
        public Blockchain createChain()
        {
            Blockchain newChain = new Blockchain();
            return newChain;
        }

        public Blockchain addToChain(Blockchain newChain, string sender, string receiver, float amount)
        {
            string chainDetails;
            chainDetails = "{sender: " + sender + ", receiver: " + receiver + ", amount: " + amount + "}";
            newChain.AddBlock(new Block(DateTime.Now, null, chainDetails));
            return newChain;
        }

        public object GetValues(string option)
        {
            if (option == "sender") 
            { 
                Console.WriteLine("Who is the sender?");
                string sender = Console.ReadLine();
                
                return sender;
            }

            if(option == "receiver")
            {
                Console.WriteLine("Who is the receiver?");
                string receiver = Console.ReadLine();

                return receiver;
            }

            if(option == "amount")
            {
                Console.WriteLine("What is the amount you want to transfer?");
                string amount = Console.ReadLine();

                return amount;
            }

            if(option == "ifLoop")
            {
                Console.WriteLine("Do you wish still to continue? y/N");
                string ifLoop = Console.ReadLine();
                if(ifLoop == "y" || ifLoop == "Y" || ifLoop == "N" || ifLoop == "n")
                    {
                    if (ifLoop == "Y" || ifLoop == "y")
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    Console.WriteLine("Wrong option, quitting");
                }
            }

            return 0;
        }

    }
}