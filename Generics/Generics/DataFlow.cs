using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class DataFlow : IDataFlow<string>
    {
        public List<IBlock<string>> Blocks = new List<IBlock<string>>();
        public void AddBlock(IBlock<string> block)
        {
            Blocks.Add(block);
        }

        public string RunFlow(string input)
        {
            if(Blocks.Count == 0)
            {
                return "No Blocks in DataFlow";
            }
            if(Blocks.Count == 1)
            {
                return Blocks[0].Process(input);
            }
            string output = String.Empty;
            for (int i = 0; i < Blocks.Count - 1; i++)
            {
                string temp = Blocks[i].Process(input);
                output = Blocks[i + 1].Process(temp);
            }

            return output;
        }
    }
}
