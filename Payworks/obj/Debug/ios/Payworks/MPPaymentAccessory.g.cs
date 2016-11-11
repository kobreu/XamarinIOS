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
	[Register("MPPaymentAccessory", true)]
	public unsafe partial class MPPaymentAccessory : MPAccessory {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPPaymentAccessory");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPPaymentAccessory () : base (NSObjectFlag.Empty)
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
		protected MPPaymentAccessory (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPPaymentAccessory (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("displayIdleScreenWithSuccess:failure:")]
		[CompilerGenerated]
		public unsafe virtual void DisplayIdleScreenWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPPaymentAccessoryDisplayIdleScreenSuccess))]MPPaymentAccessoryDisplayIdleScreenSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPPaymentAccessoryDisplayIdleScreenFailure))]MPPaymentAccessoryDisplayIdleScreenFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPPaymentAccessoryDisplayIdleScreenSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPPaymentAccessoryDisplayIdleScreenFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayIdleScreenWithSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayIdleScreenWithSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("displayText:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void DisplayText (NSObject[] text, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPPaymentAccessoryDisplayTextSuccess))]MPPaymentAccessoryDisplayTextSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPPaymentAccessoryDisplayTextFailure))]MPPaymentAccessoryDisplayTextFailure failure)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsa_text = NSArray.FromNSObjects (text);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPPaymentAccessoryDisplayTextSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPPaymentAccessoryDisplayTextFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayText:success:failure:"), nsa_text.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayText:success:failure:"), nsa_text.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			nsa_text.Dispose ();
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual MPPaymentAccessoryFeature Features {
			[Export ("features", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPPaymentAccessoryFeature) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("features"));
				} else {
					return (MPPaymentAccessoryFeature) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("features"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] IdleScreenText {
			[Export ("idleScreenText", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("idleScreenText")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("idleScreenText")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Locale {
			[Export ("locale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("locale"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("locale"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPPaymentAccessoryRequirement Requirements {
			[Export ("requirements", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPPaymentAccessoryRequirement) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("requirements"));
				} else {
					return (MPPaymentAccessoryRequirement) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requirements"));
				}
			}
			
		}
		
	} /* class MPPaymentAccessory */
}
