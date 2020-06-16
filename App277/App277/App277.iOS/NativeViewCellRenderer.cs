using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App277.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(NativeViewCellRenderer))]
namespace App277.iOS
{
    public class NativeViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            // removes default selection style (gray background color on tapped event)
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}