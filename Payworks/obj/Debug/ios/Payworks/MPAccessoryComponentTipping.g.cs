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
	[Register("MPAccessoryComponentTipping", true)]
	public unsafe partial class MPAccessoryComponentTipping : MPAccessoryComponent {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentTipping");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentTipping () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentTipping (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentTipping (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("askForTipForAmount:currency:suggestedTip:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void AskForTipForAmount (NSDecimalNumber transactionAmmount, NSObject currency, NSDecimalNumber suggestedTip, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentTippingSuccess))]MPAccessoryComponentTippingSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentTippingFailure))]MPAccessoryComponentTippingFailure failure)
		{
			if (transactionAmmount == null)
				throw new ArgumentNullException ("transactionAmmount");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentTippingSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentTippingFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("askForTipForAmount:currency:suggestedTip:success:failure:"), transactionAmmount.Handle, currency.Handle, suggestedTip == null ? IntPtr.Zero : suggestedTip.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("askForTipForAmount:currency:suggestedTip:success:failure:"), transactionAmmount.Handle, currency.Handle, suggestedTip == null ? IntPtr.Zero : suggestedTip.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("askForTipForAmount:currency:suggestedTip:success:abort:failure:")]
		[CompilerGenerated]
		public unsafe virtual void AskForTipForAmount (NSDecimalNumber transactionAmmount, NSObject currency, NSDecimalNumber suggestedTip, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentTippingAskForTipSuccess))]MPAccessoryComponentTippingAskForTipSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentTippingAskForTipAbort))]MPAccessoryComponentTippingAskForTipAbort abort, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentTippingAskForTipFailure))]MPAccessoryComponentTippingAskForTipFailure failure)
		{
			if (transactionAmmount == null)
				throw new ArgumentNullException ("transactionAmmount");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (abort == null)
				throw new ArgumentNullException ("abort");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentTippingAskForTipSuccess.Handler, success);
			BlockLiteral *block_ptr_abort;
			BlockLiteral block_abort;
			block_abort = new BlockLiteral ();
			block_ptr_abort = &block_abort;
			block_abort.SetupBlock (Trampolines.SDMPAccessoryComponentTippingAskForTipAbort.Handler, abort);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentTippingAskForTipFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("askForTipForAmount:currency:suggestedTip:success:abort:failure:"), transactionAmmount.Handle, currency.Handle, suggestedTip == null ? IntPtr.Zero : suggestedTip.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("askForTipForAmount:currency:suggestedTip:success:abort:failure:"), transactionAmmount.Handle, currency.Handle, suggestedTip == null ? IntPtr.Zero : suggestedTip.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_abort->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
	} /* class MPAccessoryComponentTipping */
}
