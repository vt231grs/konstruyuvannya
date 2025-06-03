using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LightElementNode : LightNode
{
    public string Tag { get; }
    public string DisplayType { get; }
    public string ClosingType { get; }
    public List<string> CssClasses { get; }
    public List<LightNode> Children { get; }

    public LightElementNode(string tag, string displayType, string closingType,
                          List<string> cssClasses = null, List<LightNode> children = null)
    {
        Tag = tag;
        DisplayType = displayType;
        ClosingType = closingType;
        CssClasses = cssClasses ?? new List<string>();
        Children = children ?? new List<LightNode>();
    }

    public void AddChild(LightNode child)
    {
        Children.Add(child);
    }

    public override string OuterHTML
    {
        get
        {
            string classes = CssClasses.Any() ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";
            string openingTag = $"<{Tag}{classes}>";

            if (ClosingType == "single")
                return openingTag.Insert(openingTag.Length - 1, "/");

            return $"{openingTag}{InnerHTML}</{Tag}>";
        }
    }

    public override string InnerHTML => string.Join("", Children);
}