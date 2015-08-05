using System;
using AI.Xamarin.Abstractions;

namespace AzureAI.XamarinDemo
{
	public static class AzureAIManager
	{
		public static void Setup(string appKey = "2ca3d2c9-6caf-4a63-b451-1fa7f346dc20") // "your-azure-AI-instrumentation-key")
		{
			AI.Xamarin.iOS.ApplicationInsights.Init();

			var ai = new AI.Xamarin.iOS.ApplicationInsights ();
			ApplicationInsights.Init (ai);

			TelemetryManager.Init(new AI.Xamarin.iOS.TelemetryManager());
			ApplicationInsights.Setup(appKey);

		}

		public static void Start()
		{
			ApplicationInsights.Start();
		}

		public static void Configure(string userId = "" )
		{
			ApplicationInsights.SetAutoPageViewTrackingDisabled(true);

			if (string.IsNullOrEmpty(userId))
				ApplicationInsights.SetUserId(userId);
		}

		public static void RenewSession()
		{
			ApplicationInsights.StartNewSession();
		}

	}
}

