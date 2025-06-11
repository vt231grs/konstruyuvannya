using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextEditor.Models
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly Stack<TextDocumentMemento> _history = new Stack<TextDocumentMemento>();

        public TextEditor(string initialContent)
        {
            _document = new TextDocument(initialContent);
            Save();
        }

        public void Edit(string newContent)
        {
            Save();
            _document.UpdateContent(newContent);
        }

        public void Save()
        {
            _history.Push(_document.CreateMemento());
        }

        public void Undo()
        {
            if (_history.Count > 1) // Завжди залишаємо хоча б один елемент (початковий стан)
            {
                _history.Pop(); // Видаляємо поточний стан
                var previousState = _history.Peek();
                _document.RestoreFromMemento(previousState);
            }
        }

        public string GetContent()
        {
            return _document.Content;
        }

        public int GetHistoryCount()
        {
            return _history.Count;
        }
    }
}