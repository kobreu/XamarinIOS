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
	[Register("MPAccessoryComponentInteraction", true)]
	public unsafe partial class MPAccessoryComponentInteraction : MPAccessoryComponent {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentInteraction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentInteraction () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentInteraction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentInteraction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("askForConfirmationWithParameters:success:abort:failure:")]
		[CompilerGenerated]
		public unsafe virtual void AskForConfirmationWithParameters (MPAccessoryComponentInteractionAskForConfirmationParameters @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionConfirmationSuccess))]MPAccessoryComponentInteractionConfirmationSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionConfirmationAbort))]MPAccessoryComponentInteractionConfirmationAbort abort, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionConfirmationFailure))]MPAccessoryComponentInteractionConfirmationFailure failure)
		{
			if (@params == null)
				throw new ArgumentNullException ("@params");
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
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionConfirmationSuccess.Handler, success);
			BlockLiteral *block_ptr_abort;
			BlockLiteral block_abort;
			block_abort = new BlockLiteral ();
			block_ptr_abort = &block_abort;
			block_abort.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionConfirmationAbort.Handler, abort);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionConfirmationFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("askForConfirmationWithParameters:success:abort:failure:"), @params.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("askForConfirmationWithParameters:success:abort:failure:"), @params.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_abort->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("askForNumberWithParameters:success:abort:failure:")]
		[CompilerGenerated]
		public unsafe virtual void AskForNumberWithParameters (MPAccessoryComponentInteractionAskForNumberParameters @params, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionAskForNumberSuccess))]MPAccessoryComponentInteractionAskForNumberSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionAskForNumberAbort))]MPAccessoryComponentInteractionAskForNumberAbort abort, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionAskForNumberFailure))]MPAccessoryComponentInteractionAskForNumberFailure failure)
		{
			if (@params == null)
				throw new ArgumentNullException ("@params");
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
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionAskForNumberSuccess.Handler, success);
			BlockLiteral *block_ptr_abort;
			BlockLiteral block_abort;
			block_abort = new BlockLiteral ();
			block_ptr_abort = &block_abort;
			block_abort.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionAskForNumberAbort.Handler, abort);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionAskForNumberFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("askForNumberWithParameters:success:abort:failure:"), @params.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("askForNumberWithParameters:success:abort:failure:"), @params.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_abort->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("displayIdleScreenSuccess:failure:")]
		[CompilerGenerated]
		public unsafe virtual void DisplayIdleScreenSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionDisplayIdleScreenSuccess))]MPAccessoryComponentInteractionDisplayIdleScreenSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionDisplayIdleScreenFailure))]MPAccessoryComponentInteractionDisplayIdleScreenFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionDisplayIdleScreenSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionDisplayIdleScreenFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayIdleScreenSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayIdleScreenSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("displayText:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void DisplayText (NSObject[] text, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionDisplayTextSuccess))]MPAccessoryComponentInteractionDisplayTextSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentInteractionDisplayTextFailure))]MPAccessoryComponentInteractionDisplayTextFailure failure)
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
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionDisplayTextSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentInteractionDisplayTextFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayText:success:failure:"), nsa_text.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayText:success:failure:"), nsa_text.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			nsa_text.Dispose ();
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
	} /* class MPAccessoryComponentInteraction */
}
