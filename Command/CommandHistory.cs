using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class CommandHistory
    {
        private Stack<Command> history = new Stack<Command>();

        public void push(Command command)
        {
            history.Push(command);
        }

        public void pop()
        {
            history.Pop();
        }


        public bool isEmpty()
        {
            return history.Count == 0;
        }
    }
}
