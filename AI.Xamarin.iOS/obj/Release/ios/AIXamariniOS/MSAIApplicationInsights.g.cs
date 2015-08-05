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
	[Register("MSAIApplicationInsights", true)]
	public unsafe partial class MSAIApplicationInsights : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MSAIApplicationInsights");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MSAIApplicationInsights () : base (NSObjectFlag.Empty)
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
		protected MSAIApplicationInsights (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MSAIApplicationInsights (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("renewSessionWithId:")]
		[CompilerGenerated]
		public static void RenewSessionWithId (string sessionId)
		{
			if (sessionId == null)
				throw new ArgumentNullException ("sessionId");
			var nssessionId = NSString.CreateNative (sessionId);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("renewSessionWithId:"), nssessionId);
			NSString.ReleaseNative (nssessionId);
			
		}
		
		[Export ("setAppBackgroundTimeBeforeSessionExpires:")]
		[CompilerGenerated]
		public static void SetAppBackgroundTimeBeforeSessionExpires (global::System.nuint appBackgroundTimeBeforeSessionExpires)
		{
			ApiDefinition.Messaging.void_objc_msgSend_nuint (class_ptr, Selector.GetHandle ("setAppBackgroundTimeBeforeSessionExpires:"), appBackgroundTimeBeforeSessionExpires);
		}
		
		[Export ("setAutoPageViewTrackingDisabled:")]
		[CompilerGenerated]
		public static void SetAutoPageViewTrackingDisabled (bool autoPageViewTrackingDisabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAutoPageViewTrackingDisabled:"), autoPageViewTrackingDisabled);
		}
		
		[Export ("setAutoSessionManagementDisabled:")]
		[CompilerGenerated]
		public static void SetAutoSessionManagementDisabled (bool autoSessionManagementDisabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setAutoSessionManagementDisabled:"), autoSessionManagementDisabled);
		}
		
		[Export ("setCrashManagerDisabled:")]
		[CompilerGenerated]
		public static void SetCrashManagerDisabled (bool crashManagerDisabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setCrashManagerDisabled:"), crashManagerDisabled);
		}
		
		[Export ("setTelemetryManagerDisabled:")]
		[CompilerGenerated]
		public static void SetTelemetryManagerDisabled (bool telemetryManagerDisabled)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool (class_ptr, Selector.GetHandle ("setTelemetryManagerDisabled:"), telemetryManagerDisabled);
		}
		
		[Export ("setupWithInstrumentationKey:")]
		[CompilerGenerated]
		public static void Setup (string instrumentationKey)
		{
			if (instrumentationKey == null)
				throw new ArgumentNullException ("instrumentationKey");
			var nsinstrumentationKey = NSString.CreateNative (instrumentationKey);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setupWithInstrumentationKey:"), nsinstrumentationKey);
			NSString.ReleaseNative (nsinstrumentationKey);
			
		}
		
		[Export ("setUserId:")]
		[CompilerGenerated]
		public static void SetUserId (string userId)
		{
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsuserId = NSString.CreateNative (userId);
			
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("setUserId:"), nsuserId);
			NSString.ReleaseNative (nsuserId);
			
		}
		
		[Export ("start")]
		[CompilerGenerated]
		public static void Start ()
		{
			ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("start"));
		}
		
		[Export ("startNewSession")]
		[CompilerGenerated]
		public static void StartNewSession ()
		{
			ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("startNewSession"));
		}
		
		[CompilerGenerated]
		public virtual bool DebugLogEnabled {
			[Export ("isDebugLogEnabled")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDebugLogEnabled"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDebugLogEnabled"));
				}
			}
			
			[Export ("setDebugLogEnabled:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDebugLogEnabled:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDebugLogEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ServerURL {
			[Export ("serverURL", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serverURL")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serverURL")));
				}
			}
			
			[Export ("setServerURL:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setServerURL:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setServerURL:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		static object __mt_SharedInstance_var_static;
		[CompilerGenerated]
		public static MSAIApplicationInsights SharedInstance {
			[Export ("sharedInstance")]
			get {
				MSAIApplicationInsights ret;
				ret =  Runtime.GetNSObject<MSAIApplicationInsights> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_SharedInstance_var_static = ret;
				return ret;
			}
			
		}
		
	} /* class MSAIApplicationInsights */
}
