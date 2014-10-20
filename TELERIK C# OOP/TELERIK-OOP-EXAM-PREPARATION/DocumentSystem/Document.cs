
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Document : IDocument
{
    public string Name{ get; protected set;}

    public string Content{get;protected set;}

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
        {
            this.Name = value;
        }
        else if (key == "content")
        {
            this.Content = value;
        }
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        var name = new KeyValuePair<string, object>("name", this.Name);
        var content = new KeyValuePair<string, object>("content", this.Content);
        output.Add(name);
        output.Add(content);
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.Append(this.GetType().Name);
        result.Append("[");
        IList<KeyValuePair<string, object>> attributes =
            new List<KeyValuePair<string, object>>();
        SaveAllProperties(attributes);
        var sortedAttributes = attributes.OrderBy(atr => atr.Key);
       
        foreach (var atribute in sortedAttributes)
        {
            if (atribute.Value != null)
            {
              result.Append(atribute.Key);
                result.Append("=");
                result.Append(atribute.Value);
                result.Append(";");  
            }            
        }
        result.Length--;
        result.Append("]");

        return result.ToString();
    }
}

