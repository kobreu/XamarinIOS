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
	[Register("MPMpos", true)]
	public unsafe partial class MPMpos : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPMpos");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPMpos () : base (NSObjectFlag.Empty)
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
		protected MPMpos (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPMpos (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("providerWithOptions:")]
		[CompilerGenerated]
		public static MPProvider ProviderWithOptions (MPProviderOptions options)
		{
			if (options == null)
				throw new ArgumentNullException ("options");
			return  Runtime.GetNSObject<MPProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("providerWithOptions:"), options.Handle));
		}
		
		[Export ("transactionProviderForMode:merchantIdentifier:merchantSecretKey:")]
		[CompilerGenerated]
		public static MPTransactionProvider TransactionProviderForMode (MPProviderMode mode, string merchantIdentifier, string merchantSecretKey)
		{
			if (merchantIdentifier == null)
				throw new ArgumentNullException ("merchantIdentifier");
			if (merchantSecretKey == null)
				throw new ArgumentNullException ("merchantSecretKey");
			var nsmerchantIdentifier = NSString.CreateNative (merchantIdentifier);
			var nsmerchantSecretKey = NSString.CreateNative (merchantSecretKey);
			
			MPTransactionProvider ret;
			if (IntPtr.Size == 8) {
				ret =  Runtime.GetNSObject<MPTransactionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_Int64_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("transactionProviderForMode:merchantIdentifier:merchantSecretKey:"), (Int64)mode, nsmerchantIdentifier, nsmerchantSecretKey));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("transactionProviderForMode:merchantIdentifier:merchantSecretKey:"), (int)mode, nsmerchantIdentifier, nsmerchantSecretKey));
			}
			NSString.ReleaseNative (nsmerchantIdentifier);
			NSString.ReleaseNative (nsmerchantSecretKey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static string Build {
			[Export ("build")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("build")));
			}
			
		}
		
		[CompilerGenerated]
		public static MPProviderOptionsFactory ProviderOptionsFactory {
			[Export ("providerOptionsFactory")]
			get {
				MPProviderOptionsFactory ret;
				ret =  Runtime.GetNSObject<MPProviderOptionsFactory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("providerOptionsFactory")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public static string Version {
			[Export ("version")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("version")));
			}
			
		}
		
	} /* class MPMpos */
}
