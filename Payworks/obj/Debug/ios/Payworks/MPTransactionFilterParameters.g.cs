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
	[Register("MPTransactionFilterParameters", true)]
	public unsafe partial class MPTransactionFilterParameters : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionFilterParameters");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionFilterParameters () : base (NSObjectFlag.Empty)
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
		protected MPTransactionFilterParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionFilterParameters (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("emptyFilter")]
		[CompilerGenerated]
		public static MPTransactionFilterParameters EmptyFilter ()
		{
			return  Runtime.GetNSObject<MPTransactionFilterParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("emptyFilter")));
		}
		
		[Export ("filterWithCustomIdentifier:")]
		[CompilerGenerated]
		public static MPTransactionFilterParameters FilterWithCustomIdentifier (string customIdentifier)
		{
			if (customIdentifier == null)
				throw new ArgumentNullException ("customIdentifier");
			var nscustomIdentifier = NSString.CreateNative (customIdentifier);
			
			MPTransactionFilterParameters ret;
			ret =  Runtime.GetNSObject<MPTransactionFilterParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("filterWithCustomIdentifier:"), nscustomIdentifier));
			NSString.ReleaseNative (nscustomIdentifier);
			
			return ret;
		}
		
	} /* class MPTransactionFilterParameters */
}
