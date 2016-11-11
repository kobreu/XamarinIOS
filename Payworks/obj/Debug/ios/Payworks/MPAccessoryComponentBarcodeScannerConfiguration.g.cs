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
	[Register("MPAccessoryComponentBarcodeScannerConfiguration", true)]
	public unsafe partial class MPAccessoryComponentBarcodeScannerConfiguration : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentBarcodeScannerConfiguration");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentBarcodeScannerConfiguration () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentBarcodeScannerConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentBarcodeScannerConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual MPAccessoryComponentBarcodeScannerConfigurationContinuousMode ContinuousMode {
			[Export ("continuousMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPAccessoryComponentBarcodeScannerConfigurationContinuousMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("continuousMode"));
				} else {
					return (MPAccessoryComponentBarcodeScannerConfigurationContinuousMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("continuousMode"));
				}
			}
			
			[Export ("setContinuousMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setContinuousMode:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setContinuousMode:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MPAccessoryComponentBarcodeScannerConfigurationScanMode ScanMode {
			[Export ("scanMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPAccessoryComponentBarcodeScannerConfigurationScanMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("scanMode"));
				} else {
					return (MPAccessoryComponentBarcodeScannerConfigurationScanMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scanMode"));
				}
			}
			
			[Export ("setScanMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setScanMode:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setScanMode:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MPAccessoryComponentBarcodeScannerConfigurationTriggerMode TriggerMode {
			[Export ("triggerMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPAccessoryComponentBarcodeScannerConfigurationTriggerMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("triggerMode"));
				} else {
					return (MPAccessoryComponentBarcodeScannerConfigurationTriggerMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("triggerMode"));
				}
			}
			
			[Export ("setTriggerMode:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setTriggerMode:"), (int)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setTriggerMode:"), (int)value);
				}
			}
		}
		
	} /* class MPAccessoryComponentBarcodeScannerConfiguration */
}
