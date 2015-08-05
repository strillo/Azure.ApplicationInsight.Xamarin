//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace AI.Xamarin.iOS {
	[Register("MSAITelemetryManager", true)]
	public unsafe partial class MSAITelemetryManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MSAITelemetryManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MSAITelemetryManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MSAITelemetryManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MSAITelemetryManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("trackEventWithName:")]
		[CompilerGenerated]
		public static void TrackEvent (string eventName)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			var nseventName = NSString.CreateNative (eventName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("trackEventWithName:"), nseventName);
			NSString.ReleaseNative (nseventName);
			
		}
		
		[Export ("trackEventWithName:properties:")]
		[CompilerGenerated]
		public static void TrackEvent (string eventName, NSDictionary properties)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nseventName = NSString.CreateNative (eventName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("trackEventWithName:properties:"), nseventName, properties.Handle);
			NSString.ReleaseNative (nseventName);
			
		}
		
		[Export ("trackManagedExceptionWithType:message:stacktrace:handled:")]
		[CompilerGenerated]
		public static void TrackManagedException (string type, string message, string stacktrace, bool handled)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (stacktrace == null)
				throw new ArgumentNullException ("stacktrace");
			var nstype = NSString.CreateNative (type);
			var nsmessage = NSString.CreateNative (message);
			var nsstacktrace = NSString.CreateNative (stacktrace);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (class_ptr, Selector.GetHandle ("trackManagedExceptionWithType:message:stacktrace:handled:"), nstype, nsmessage, nsstacktrace, handled);
			NSString.ReleaseNative (nstype);
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nsstacktrace);
			
		}
		
		[Export ("trackMetricWithName:value:")]
		[CompilerGenerated]
		public static void TrackMetric (string metricName, global::System.Double value)
		{
			if (metricName == null)
				throw new ArgumentNullException ("metricName");
			var nsmetricName = NSString.CreateNative (metricName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double (class_ptr, Selector.GetHandle ("trackMetricWithName:value:"), nsmetricName, value);
			NSString.ReleaseNative (nsmetricName);
			
		}
		
		[Export ("trackMetricWithName:value:properties:")]
		[CompilerGenerated]
		public static void TrackMetric (string metricName, global::System.Double value, NSDictionary properties)
		{
			if (metricName == null)
				throw new ArgumentNullException ("metricName");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nsmetricName = NSString.CreateNative (metricName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_Double_IntPtr (class_ptr, Selector.GetHandle ("trackMetricWithName:value:properties:"), nsmetricName, value, properties.Handle);
			NSString.ReleaseNative (nsmetricName);
			
		}
		
		[Export ("trackPageView:")]
		[CompilerGenerated]
		public static void TrackPageView (string pageName)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("trackPageView:"), nspageName);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("trackPageView:duration:")]
		[CompilerGenerated]
		public static void TrackPageView (string pageName, global::System.nint duration)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			var nspageName = NSString.CreateNative (pageName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint (class_ptr, Selector.GetHandle ("trackPageView:duration:"), nspageName, duration);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("trackPageView:duration:properties:")]
		[CompilerGenerated]
		public static void TrackPageView (string pageName, global::System.nint duration, NSDictionary properties)
		{
			if (pageName == null)
				throw new ArgumentNullException ("pageName");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nspageName = NSString.CreateNative (pageName);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_nint_IntPtr (class_ptr, Selector.GetHandle ("trackPageView:duration:properties:"), nspageName, duration, properties.Handle);
			NSString.ReleaseNative (nspageName);
			
		}
		
		[Export ("trackTraceWithMessage:")]
		[CompilerGenerated]
		public static void TrackTrace (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("trackTraceWithMessage:"), nsmessage);
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("trackTraceWithMessage:properties:")]
		[CompilerGenerated]
		public static void TrackTrace (string message, NSDictionary properties)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (properties == null)
				throw new ArgumentNullException ("properties");
			var nsmessage = NSString.CreateNative (message);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("trackTraceWithMessage:properties:"), nsmessage, properties.Handle);
			NSString.ReleaseNative (nsmessage);
			
		}
		
	} /* class MSAITelemetryManager */
}
