﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class VideoDocument : MultimediaDocument
{
    public long? FrameRate { get; protected set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
        {
            this.FrameRate = long.Parse(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }

    }
    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        var charset = new KeyValuePair<string, object>("framerate", this.FrameRate);
        output.Add(charset);
        base.SaveAllProperties(output);
    }
}
