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
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Payworks {
	[Register("MPProviderOptionsFactory", true)]
	public unsafe partial class MPProviderOptionsFactory : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPProviderOptionsFactory");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPProviderOptionsFactory () : base (NSObjectFlag.Empty)
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
		protected MPProviderOptionsFactory (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPProviderOptionsFactory (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("mockOptionsWithSupportedActions:")]
		[CompilerGenerated]
		public virtual MPProviderOptions MockOptionsWithSupportedActions (NSObject supportedActions)
		{
			if (supportedActions == null)
				throw new ArgumentNullException ("supportedActions");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MPProviderOptions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("mockOptionsWithSupportedActions:"), supportedActions.Handle));
			} else {
				return  Runtime.GetNSObject<MPProviderOptions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("mockOptionsWithSupportedActions:"), supportedActions.Handle));
			}
		}
		
		[Export ("providerOptionsWithMode:merchantIdentifer:merchantSecretKey:supportedActions:")]
		[CompilerGenerated]
		public virtual MPProviderOptions ProviderOptionsWithMode (MPProviderMode mode, string merchantIdentifier, string merchantSecretKey, NSObject supportedActions)
		{
			if (merchantIdentifier == null)
				throw new ArgumentNullException ("merchantIdentifier");
			if (merchantSecretKey == null)
				throw new ArgumentNullException ("merchantSecretKey");
			if (supportedActions == null)
				throw new ArgumentNullException ("supportedActions");
			var nsmerchantIdentifier = NSString.CreateNative (merchantIdentifier);
			var nsmerchantSecretKey = NSString.CreateNative (merchantSecretKey);
			
			MPProviderOptions ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<MPProviderOptions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("providerOptionsWithMode:merchantIdentifer:merchantSecretKey:supportedActions:"), (Int64)mode, nsmerchantIdentifier, nsmerchantSecretKey, supportedActions.Handle));
				} else {
					ret =  Runtime.GetNSObject<MPProviderOptions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("providerOptionsWithMode:merchantIdentifer:merchantSecretKey:supportedActions:"), (int)mode, nsmerchantIdentifier, nsmerchantSecretKey, supportedActions.Handle));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret =  Runtime.GetNSObject<MPProviderOptions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("providerOptionsWithMode:merchantIdentifer:merchantSecretKey:supportedActions:"), (Int64)mode, nsmerchantIdentifier, nsmerchantSecretKey, supportedActions.Handle));
				} else {
					ret =  Runtime.GetNSObject<MPProviderOptions> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("providerOptionsWithMode:merchantIdentifer:merchantSecretKey:supportedActions:"), (int)mode, nsmerchantIdentifier, nsmerchantSecretKey, supportedActions.Handle));
				}
			}
			NSString.ReleaseNative (nsmerchantIdentifier);
			NSString.ReleaseNative (nsmerchantSecretKey);
			
			return ret;
		}
		
	} /* class MPProviderOptionsFactory */
}
