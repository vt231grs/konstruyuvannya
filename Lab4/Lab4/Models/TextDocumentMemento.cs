using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Models
{
    public class TextDocumentMemento
    {
        private readonly string _content;
        private readonly DateTime _createdAt;

        public TextDocumentMemento(string content)
        {
            _content = content;
            _createdAt = DateTime.Now;
        }

        public string GetSavedContent()
        {
            return _content;
        }

        public DateTime GetSaveTime()
        {
            return _createdAt;
        }
    }
}
