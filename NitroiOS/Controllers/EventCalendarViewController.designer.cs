// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace location2
{
    [Register ("EventCalendarViewController")]
    partial class EventCalendarViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNoEvents { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewCalendar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewDate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblNoEvents != null) {
                lblNoEvents.Dispose ();
                lblNoEvents = null;
            }

            if (tableView != null) {
                tableView.Dispose ();
                tableView = null;
            }

            if (viewCalendar != null) {
                viewCalendar.Dispose ();
                viewCalendar = null;
            }

            if (viewDate != null) {
                viewDate.Dispose ();
                viewDate = null;
            }
        }
    }
}