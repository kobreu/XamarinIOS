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
	[Register("MPAccessoryComponentBarcodeScanner", true)]
	public unsafe partial class MPAccessoryComponentBarcodeScanner : MPAccessoryComponent {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentBarcodeScanner");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentBarcodeScanner () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentBarcodeScanner (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentBarcodeScanner (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("startScanWithConfiguration:success:scan:button:failure:")]
		[CompilerGenerated]
		public unsafe virtual void StartScanWithConfiguration (MPAccessoryComponentBarcodeScannerConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanSuccess))]MPAccessoryComponentBarcodeScannerStartScanSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanScan))]MPAccessoryComponentBarcodeScannerStartScanScan scan, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanButton))]MPAccessoryComponentBarcodeScannerStartScanButton button, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanFailure))]MPAccessoryComponentBarcodeScannerStartScanFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (scan == null)
				throw new ArgumentNullException ("scan");
			if (button == null)
				throw new ArgumentNullException ("button");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanSuccess.Handler, success);
			BlockLiteral *block_ptr_scan;
			BlockLiteral block_scan;
			block_scan = new BlockLiteral ();
			block_ptr_scan = &block_scan;
			block_scan.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanScan.Handler, scan);
			BlockLiteral *block_ptr_button;
			BlockLiteral block_button;
			block_button = new BlockLiteral ();
			block_ptr_button = &block_button;
			block_button.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanButton.Handler, button);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startScanWithConfiguration:success:scan:button:failure:"), configuration == null ? IntPtr.Zero : configuration.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startScanWithConfiguration:success:scan:button:failure:"), configuration == null ? IntPtr.Zero : configuration.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_scan->CleanupBlock ();
			block_ptr_button->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("startScanWithConfiguration:success:scan:button:abort:failure:")]
		[CompilerGenerated]
		public unsafe virtual void StartScanWithConfiguration (MPAccessoryComponentBarcodeScannerConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanSuccess))]MPAccessoryComponentBarcodeScannerStartScanSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanScan))]MPAccessoryComponentBarcodeScannerStartScanScan scan, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanButton))]MPAccessoryComponentBarcodeScannerStartScanButton button, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanAbort))]MPAccessoryComponentBarcodeScannerStartScanAbort abort, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanFailure))]MPAccessoryComponentBarcodeScannerStartScanFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (scan == null)
				throw new ArgumentNullException ("scan");
			if (button == null)
				throw new ArgumentNullException ("button");
			if (abort == null)
				throw new ArgumentNullException ("abort");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanSuccess.Handler, success);
			BlockLiteral *block_ptr_scan;
			BlockLiteral block_scan;
			block_scan = new BlockLiteral ();
			block_ptr_scan = &block_scan;
			block_scan.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanScan.Handler, scan);
			BlockLiteral *block_ptr_button;
			BlockLiteral block_button;
			block_button = new BlockLiteral ();
			block_ptr_button = &block_button;
			block_button.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanButton.Handler, button);
			BlockLiteral *block_ptr_abort;
			BlockLiteral block_abort;
			block_abort = new BlockLiteral ();
			block_ptr_abort = &block_abort;
			block_abort.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanAbort.Handler, abort);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startScanWithConfiguration:success:scan:button:abort:failure:"), configuration == null ? IntPtr.Zero : configuration.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startScanWithConfiguration:success:scan:button:abort:failure:"), configuration == null ? IntPtr.Zero : configuration.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_scan->CleanupBlock ();
			block_ptr_button->CleanupBlock ();
			block_ptr_abort->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("startScanWithSuccess:scan:button:failure:")]
		[CompilerGenerated]
		public unsafe virtual void StartScanWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanSuccess))]MPAccessoryComponentBarcodeScannerStartScanSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanScan))]MPAccessoryComponentBarcodeScannerStartScanScan scan, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanButton))]MPAccessoryComponentBarcodeScannerStartScanButton button, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanFailure))]MPAccessoryComponentBarcodeScannerStartScanFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (scan == null)
				throw new ArgumentNullException ("scan");
			if (button == null)
				throw new ArgumentNullException ("button");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanSuccess.Handler, success);
			BlockLiteral *block_ptr_scan;
			BlockLiteral block_scan;
			block_scan = new BlockLiteral ();
			block_ptr_scan = &block_scan;
			block_scan.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanScan.Handler, scan);
			BlockLiteral *block_ptr_button;
			BlockLiteral block_button;
			block_button = new BlockLiteral ();
			block_ptr_button = &block_button;
			block_button.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanButton.Handler, button);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startScanWithSuccess:scan:button:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startScanWithSuccess:scan:button:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_scan->CleanupBlock ();
			block_ptr_button->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("startScanWithSuccess:scan:button:abort:failure:")]
		[CompilerGenerated]
		public unsafe virtual void StartScanWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanSuccess))]MPAccessoryComponentBarcodeScannerStartScanSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanScan))]MPAccessoryComponentBarcodeScannerStartScanScan scan, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanButton))]MPAccessoryComponentBarcodeScannerStartScanButton button, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanAbort))]MPAccessoryComponentBarcodeScannerStartScanAbort abort, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStartScanFailure))]MPAccessoryComponentBarcodeScannerStartScanFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (scan == null)
				throw new ArgumentNullException ("scan");
			if (button == null)
				throw new ArgumentNullException ("button");
			if (abort == null)
				throw new ArgumentNullException ("abort");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanSuccess.Handler, success);
			BlockLiteral *block_ptr_scan;
			BlockLiteral block_scan;
			block_scan = new BlockLiteral ();
			block_ptr_scan = &block_scan;
			block_scan.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanScan.Handler, scan);
			BlockLiteral *block_ptr_button;
			BlockLiteral block_button;
			block_button = new BlockLiteral ();
			block_ptr_button = &block_button;
			block_button.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanButton.Handler, button);
			BlockLiteral *block_ptr_abort;
			BlockLiteral block_abort;
			block_abort = new BlockLiteral ();
			block_ptr_abort = &block_abort;
			block_abort.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanAbort.Handler, abort);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStartScanFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startScanWithSuccess:scan:button:abort:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startScanWithSuccess:scan:button:abort:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_scan, (IntPtr) block_ptr_button, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_scan->CleanupBlock ();
			block_ptr_button->CleanupBlock ();
			block_ptr_abort->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("stopScanWithSuccess:failure:")]
		[CompilerGenerated]
		public unsafe virtual void StopScanWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStopScanSuccess))]MPAccessoryComponentBarcodeScannerStopScanSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryComponentBarcodeScannerStopScanFailure))]MPAccessoryComponentBarcodeScannerStopScanFailure failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStopScanSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryComponentBarcodeScannerStopScanFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("stopScanWithSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("stopScanWithSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
	} /* class MPAccessoryComponentBarcodeScanner */
}
