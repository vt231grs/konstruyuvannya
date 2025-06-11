using System;
using System.Collections.Generic;

namespace Components
{
    public class LightElementNode : LightNode
    {
        private readonly List<LightNode> _children = new List<LightNode>();
        private readonly Dictionary<string, List<Action>> _eventListeners = new Dictionary<string, List<Action>>();

        public string TagName { get; }
        public bool IsBlock { get; }
        public bool IsSelfClosing { get; }

        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            TagName = tagName;
            IsBlock = isBlock;
            IsSelfClosing = isSelfClosing;
        }

        public void AddChild(LightNode child)
        {
            _children.Add(child);
        }

        public void AddEventListener(string eventType, Action handler)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<Action>();
            }
            _eventListeners[eventType].Add(handler);
        }

        public void TriggerEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                foreach (var handler in _eventListeners[eventType])
                {
                    handler.Invoke();
                }
            }
        }

        public override string OuterHtml => $"<{TagName}>{InnerHtml}</{TagName}>";
        public override string InnerHtml => string.Join("", _children.ConvertAll(c => c.OuterHtml));
    }
}