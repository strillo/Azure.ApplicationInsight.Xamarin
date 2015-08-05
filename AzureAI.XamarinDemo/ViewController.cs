using System;

using UIKit;
using AI.Xamarin.Abstractions;
using System.Collections.Generic;

namespace AzureAI.XamarinDemo
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void TrackEventButton_TouchUpInside (UIButton sender)
		{
			TelemetryManager.TrackEvent("my-Event1");
			TelemetryManager.TrackEvent("my-Event2", new Dictionary<string, string>{ { "tag1", "hello-world" } });
		}

		partial void LogTraceButton_TouchUpInside (UIButton sender)
		{
			TelemetryManager.TrackTrace("my-trace1");
			TelemetryManager.TrackTrace("my-trace2", new Dictionary<string, string>{ { "tag1", "hello-world" } });
		}

		partial void TrackPageButton_TouchUpInside (UIButton sender)
		{
			TelemetryManager.TrackPageView("my page name");
//			TelemetryManager.TrackPageView("page name with prop", new Dictionary<string, string>{ { "tag1", "hello-world" } });
		}

		partial void TrackMetricButton_TouchUpInside (UIButton sender)
		{
			TelemetryManager.TrackMetric("my metric name", /* metric value */ 20);
		}

		partial void TrackManagedExceptionButton_TouchUpInside (UIButton sender)
		{
			try {
				throw new Exception("my managed exception");
			} 
			catch (Exception e){
				TelemetryManager.TrackManagedException(e, true);
			}
		}

		partial void CrashAppButton_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}
	}
}

