﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ICourse
{
    string Name { get; set; }
    ITeacher Teacher { get; set; }
    void AddTopic(string topic);
    string ToString();
}