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

namespace AzureAI.XamarinDemo
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CrashAppButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton LogTraceButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TrackEventButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TrackManagedExceptionButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TrackMetricButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TrackPageButton { get; set; }

		[Action ("CrashAppButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CrashAppButton_TouchUpInside (UIButton sender);

		[Action ("LogTraceButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void LogTraceButton_TouchUpInside (UIButton sender);

		[Action ("TrackEventButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void TrackEventButton_TouchUpInside (UIButton sender);

		[Action ("TrackManagedExceptionButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void TrackManagedExceptionButton_TouchUpInside (UIButton sender);

		[Action ("TrackMetricButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void TrackMetricButton_TouchUpInside (UIButton sender);

		[Action ("TrackPageButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void TrackPageButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CrashAppButton != null) {
				CrashAppButton.Dispose ();
				CrashAppButton = null;
			}
			if (LogTraceButton != null) {
				LogTraceButton.Dispose ();
				LogTraceButton = null;
			}
			if (TrackEventButton != null) {
				TrackEventButton.Dispose ();
				TrackEventButton = null;
			}
			if (TrackManagedExceptionButton != null) {
				TrackManagedExceptionButton.Dispose ();
				TrackManagedExceptionButton = null;
			}
			if (TrackMetricButton != null) {
				TrackMetricButton.Dispose ();
				TrackMetricButton = null;
			}
			if (TrackPageButton != null) {
				TrackPageButton.Dispose ();
				TrackPageButton = null;
			}
		}
	}
}
