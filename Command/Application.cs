using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Editor editor = new Editor();
            CommandHistory history = new CommandHistory();

            CopyCommand btnCopy = new CopyCommand(editor);
            btnCopy.Execute();
            history.push(btnCopy);

            PasteCommand btnPaste = new PasteCommand(editor);
            btnPaste.Execute();
            history.push(btnPaste);
        }
    }
    
}
