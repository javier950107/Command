using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Editor
    {
        private string _text;

        public string getText()
        {
            return this._text;
        }

        public void setText(string text)
        {
            this._text = text; 
        }
    }
}
