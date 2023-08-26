using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class PasteCommand : Command
    {
        public PasteCommand(Editor editor) : base(editor) { 
        }

        public override void Execute()
        {
            Console.WriteLine("Pase command!");
        }
    }
}
