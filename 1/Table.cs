using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLRenderer
{
    class Table : Element, ITable
    {

        private int rows;
        private int cols;
        private IElement[,] cells;


        public Table(int rows, int cols)
            :base("table",null)
        {
            this.Cols = cols;
            this.Rows = rows;
            this.cells = new IElement[this.Rows,this.Cols];
        }



        public IElement this[int row, int col]
        {
            get
            {
                ValidIndeces(row, col);
                return this.cells[row, col];
            }

            set
            {
                ValidIndeces(row, col);
                if (value==null)
                {
                    throw new ArgumentNullException();
                }

                this.cells[row, col] = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.cols = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.rows = value;
            }
        }

        private void ValidIndeces(int row, int col)
        {
            if (row<0 || col<0 || row>=this.Rows || col>=this.Cols )
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException();
        }

        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException();
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException();
            }

            set
            {
                throw new InvalidOperationException();
            }
        }

        public override void Render(StringBuilder output)
        {

            output.AppendFormat("<{0}>", this.Name);

            for (int row = 0; row < this.Rows; row++)
            {
                output.AppendFormat("<tr>");

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");

                    output.Append(this.cells[row, col].ToString());

                    output.Append("</td>");

                }

                output.AppendFormat("</tr>");


            }


            output.AppendFormat("<{/0}>", this.Name);


        }
    }
}
