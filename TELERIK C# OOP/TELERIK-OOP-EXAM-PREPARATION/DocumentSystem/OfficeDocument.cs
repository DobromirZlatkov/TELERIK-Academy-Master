﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class OfficeDocument : global::EncryptableDocument
{
    public string Version { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "version")
        {
            this.Version = value;
        }
        else
        {
            base.LoadProperty(key, value);
        }

    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        var charset = new KeyValuePair<string, object>("version", this.Version);
        output.Add(charset);
        base.SaveAllProperties(output);
    }
}

