using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    public class Element : IElement
    {
        private IEnumerable<IElement> childElements;
       // private string name;
        //private string textContent;

             
        public Element(string name, string textContent):this(name)
        {
           
            this.TextContent = textContent;

        }

        public Element(string name)
            
        {
            this.Name = name;
            this.childElements = new List<IElement>();

        }



        public virtual IEnumerable<IElement> ChildElements
        {
            get
            {
                return new List<IElement>(this.childElements);

            }
        }

        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public virtual  void AddElement(IElement element)
        {
            if (element==null)
            {
                throw new ArgumentNullException(); 
            }

            ((ICollection<IElement>)this.childElements).Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);

            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {

                foreach (var item in this.TextContent)
                {
                    switch (item)
                    {
                        case '<': output.Append("&lt;");break;
                        case '>': output.Append("&gt;"); break;

                        case '&': output.Append("&amp;"); break;



                        default:
                            break;
                    }
                }

                output.Append( this.TextContent);

            }

            foreach (var item in this.childElements)
            {
                output.Append(item.ToString());
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);

            }
        }


        public override string ToString()
        {
            var output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }
    }
}
