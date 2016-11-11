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
	[Register("MPAccessoryComponentPrinter", true)]
	public unsafe partial class MPAccessoryComponentPrinter : MPAccessoryComponent {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentPrinter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentPrinter () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentPrinter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentPrinter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("printReceipt:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void PrintReceipt (MPReceipt receipt, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentPrinterPrintSuccess))]MPAccessoryComponentPrinterPrintSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentPrinterPrintFailure))]MPAccessoryComponentPrinterPrintFailure failure)
		{
			if (receipt == null)
				throw new ArgumentNullException ("receipt");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentPrinterPrintSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentPrinterPrintFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("printReceipt:success:failure:"), receipt.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("printReceipt:success:failure:"), receipt.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual MPAccessoryComponentPrinterState State {
			[Export ("state", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPAccessoryComponentPrinterState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				} else {
					return (MPAccessoryComponentPrinterState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
				}
			}
			
		}
		
	} /* class MPAccessoryComponentPrinter */
}
