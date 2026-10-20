using System;
using System.Collections;
using System.Windows.Forms;

namespace GymMembershipSystem.Common
{
    /// <summary>
    /// Enables column sorting for WinForms ListView controls in ascending or descending order.
    /// Supports automatic numeric, date, and textual comparisons.
    /// </summary>
    public class ListViewItemComparer : IComparer
    {
        public int ColumnIndex { get; set; }
        public SortOrder Order { get; set; }

        public ListViewItemComparer(int columnIndex = 0, SortOrder order = SortOrder.Ascending)
        {
            ColumnIndex = columnIndex;
            Order = order;
        }

        public int Compare(object? x, object? y)
        {
            if (Order == SortOrder.None || x == null || y == null)
                return 0;

            var itemX = (ListViewItem)x;
            var itemY = (ListViewItem)y;

            var textX = ColumnIndex < itemX.SubItems.Count ? itemX.SubItems[ColumnIndex].Text : string.Empty;
            var textY = ColumnIndex < itemY.SubItems.Count ? itemY.SubItems[ColumnIndex].Text : string.Empty;

            int result;

            // Attempt numeric comparison
            if (long.TryParse(textX.Trim('#', ' ', '$'), out var numX) &&
                long.TryParse(textY.Trim('#', ' ', '$'), out var numY))
            {
                result = numX.CompareTo(numY);
            }
            // Attempt decimal comparison
            else if (decimal.TryParse(textX.Trim('$', ' '), out var decX) &&
                     decimal.TryParse(textY.Trim('$', ' '), out var decY))
            {
                result = decX.CompareTo(decY);
            }
            // Attempt date comparison
            else if (DateTime.TryParse(textX, out var dateX) &&
                     DateTime.TryParse(textY, out var dateY))
            {
                result = dateX.CompareTo(dateY);
            }
            // Fallback to alphabetical comparison
            else
            {
                result = string.Compare(textX, textY, StringComparison.CurrentCultureIgnoreCase);
            }

            return Order == SortOrder.Descending ? -result : result;
        }
    }
}
