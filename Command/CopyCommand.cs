using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CopyCommand : Command
    {
        public CopyCommand(Editor editor) : base(editor)
        {
        }

        public override void Execute()
        {
            Console.WriteLine("Execute copy command!");
        }
    }
}
