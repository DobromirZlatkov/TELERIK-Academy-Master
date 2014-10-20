using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLElement : IElement
    {
        private ICollection<IElement> childElements;

        public HTMLElement(string name)            
        {
            this.Name = name;   
            this.childElements = new List<IElement>();
        }

        public HTMLElement(string name, string textContent) 
            :this(name)
        {            
            this.TextContent = textContent;  
        }      

        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public virtual IEnumerable<IElement> ChildElements
        {
            get { return this.childElements; }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrEmpty(this.Name))
            {
                output.Append(string.Format("<{0}>", this.Name));
            }

            if (!string.IsNullOrEmpty(this.TextContent))
            {
                foreach (var symbol in this.TextContent)
                {
                    switch (symbol)
                    {
                        case'<':
                            output.Append("&lt;");
                            break;
                        case '>':
                            output.Append("&gt;");
                            break;
                        case '&':
                            output.Append("&amp;");
                            break;
                        default:
                            
                            break;
                    } 
                   
                }
                output.Append(string.Format("{0}", this.TextContent));
                
            }

            foreach (var childElement in this.ChildElements)
            {

                output.Append(childElement.ToString());
            }

            if (!string.IsNullOrEmpty(this.Name))
            {
                output.Append(string.Format("</{0}>", this.Name));
            }
        }
       
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }
    }
}
