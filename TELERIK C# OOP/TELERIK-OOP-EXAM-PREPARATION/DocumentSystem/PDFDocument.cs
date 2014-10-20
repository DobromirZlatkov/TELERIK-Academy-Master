using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PDFDocument : global::EncryptableDocument
{
    public long? Pages { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
        {
            this.Size = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }

    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        var charset = new KeyValuePair<string, object>("pages", this.Pages);
        output.Add(charset);
        base.SaveAllProperties(output);
    }
}

