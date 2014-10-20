using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public class HTMLTable : HTMLElement, ITable
    {
        private const string TableName = "table";
        private const string TableOpeningTag = "<tr>";
        private const string TableClosingTag = "</tr>";
        private const string TableCellOpeningTag = "<td>";
        private const string TableCellClosingTag = "</td>";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public HTMLTable(int rows, int cols)
            : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get { return rows; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be positive");
                }
                this.rows = value;
            }
        }

        public int Cols
        {
            get { return cols; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be positive");
                }
                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                this.ValidateIndexes(row, col);
                return this.cells[row, col];
            }
            set
            {
                this.ValidateIndexes(row, col);
                if (value == null)
                {
                    throw new ArgumentNullException("Value vannot be null");
                }
                this.cells[row, col] = value;
            }
        }

        private void ValidateIndexes(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("Provided row is out of the boundaries in the HTML table");
            }
            if (col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Provided col is out of the boundaries in the HTML table");
            }

        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("HTML tables do not have child elements so cannot add");
        }

        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have child elements so cannot add");
            }
        }
        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("HTML tables do not have child elements so cannot add");
            }
        }
        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);
            for (int row = 0; row < this.Rows; row++)
            {
                output.AppendFormat("{0}", TableOpeningTag);
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TableCellOpeningTag);
                    output.Append(this.cells[row,col].ToString());
                    output.Append(TableCellClosingTag);
                }
                output.AppendFormat("{0}", TableClosingTag);
            }
            output.AppendFormat("</{0}>", this.Name);
        }
    }
}
