using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class MultimediaDocument : BinaryDocument
{
    public long? Lenght { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
        {
            this.Lenght = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }

    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        var charset = new KeyValuePair<string, object>("length", this.Lenght);
        output.Add(charset);
        base.SaveAllProperties(output);
    }
}

