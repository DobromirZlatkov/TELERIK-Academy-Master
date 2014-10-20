using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface IElementFactory
{
    IElement CreateElement(string name);
    IElement CreateElement(string name, string content);
    ITable CreateTable(int rows, int cols);
}
