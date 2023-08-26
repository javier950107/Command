using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal abstract class Command
    {
        private Editor _editor;
        private string _backup;

        public Command(Editor editor)
        {
            this._editor = editor;
            this._backup = "";
        }

        public void saveBackup()
        {
            this._backup = _editor.getText();
        }

        public void undo()
        {
            this._editor.setText(this._backup);
        }

        public abstract void Execute();
    }
}
