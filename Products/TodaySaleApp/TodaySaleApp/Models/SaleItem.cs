using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Text;

namespace TodaySaleApp.Models
{
    public class SaleItem
    {
        public int VisibleChildCount { get; private set; }

        public Size CellSize { get; private set; }

        public int Rows { get; private set; }

        public int Columns { get; private set; }

        public SaleItem()
        {

        }

        public SaleItem(int visibleChildCount, Size cellSize, int rows, int columns) : this()
        {
            VisibleChildCount = visibleChildCount;
            CellSize = cellSize;
            Rows = rows;
            Columns = columns;
        }
    }
}
