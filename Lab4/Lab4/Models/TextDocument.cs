using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextEditor.Models;

namespace TextEditor.Models
{
    public class TextDocument
    {
        public string Content { get; private set; }

        public TextDocument(string content)
        {
            Content = content;
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
        }

        public TextDocumentMemento CreateMemento()
        {
            return new TextDocumentMemento(Content);
        }

        public void RestoreFromMemento(TextDocumentMemento memento)
        {
            Content = memento.GetSavedContent();
        }
    }
}