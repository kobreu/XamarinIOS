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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryCheckUpdateFailure))]
		internal delegate void DMPAccessoryCheckUpdateFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryCheckUpdateFailure {
			static internal readonly DMPAccessoryCheckUpdateFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryCheckUpdateFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryCheckUpdateFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryCheckUpdateFailure */
		
		internal class NIDMPAccessoryCheckUpdateFailure {
			IntPtr blockPtr;
			DMPAccessoryCheckUpdateFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryCheckUpdateFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryCheckUpdateFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryCheckUpdateFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryCheckUpdateFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryCheckUpdateFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryCheckUpdateFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryCheckUpdateFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryCheckUpdateSuccess))]
		internal delegate void DMPAccessoryCheckUpdateSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryCheckUpdateSuccess {
			static internal readonly DMPAccessoryCheckUpdateSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryCheckUpdateSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryCheckUpdateSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<Payworks.MPAccessoryUpdateRequirement> (arg1));
			}
		} /* class SDMPAccessoryCheckUpdateSuccess */
		
		internal class NIDMPAccessoryCheckUpdateSuccess {
			IntPtr blockPtr;
			DMPAccessoryCheckUpdateSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryCheckUpdateSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryCheckUpdateSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryCheckUpdateSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryCheckUpdateSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryCheckUpdateSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryCheckUpdateSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, global::Payworks.MPAccessoryUpdateRequirement arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryCheckUpdateSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanAbort))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStartScanAbort (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStartScanAbort {
			static internal readonly DMPAccessoryComponentBarcodeScannerStartScanAbort Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStartScanAbort))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanAbort) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0));
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStartScanAbort */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStartScanAbort {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStartScanAbort invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStartScanAbort (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStartScanAbort> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStartScanAbort ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStartScanAbort Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStartScanAbort;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStartScanAbort ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStartScanAbort */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanButton))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStartScanButton (IntPtr block, IntPtr arg0, global::System.UInt32 arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStartScanButton {
			static internal readonly DMPAccessoryComponentBarcodeScannerStartScanButton Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStartScanButton))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, global::System.UInt32 arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanButton) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0), arg1);
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStartScanButton */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStartScanButton {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStartScanButton invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStartScanButton (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStartScanButton> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStartScanButton ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStartScanButton Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStartScanButton;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStartScanButton ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0, global::System.UInt32 arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStartScanButton */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanFailure))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStartScanFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStartScanFailure {
			static internal readonly DMPAccessoryComponentBarcodeScannerStartScanFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStartScanFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStartScanFailure */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStartScanFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStartScanFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStartScanFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStartScanFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStartScanFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStartScanFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStartScanFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStartScanFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStartScanFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanScan))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStartScanScan (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStartScanScan {
			static internal readonly DMPAccessoryComponentBarcodeScannerStartScanScan Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStartScanScan))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanScan) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0),  Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScannerData> (arg1));
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStartScanScan */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStartScanScan {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStartScanScan invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStartScanScan (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStartScanScan> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStartScanScan ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStartScanScan Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStartScanScan;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStartScanScan ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0, global::Payworks.MPAccessoryComponentBarcodeScannerData arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStartScanScan */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanSuccess))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStartScanSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStartScanSuccess {
			static internal readonly DMPAccessoryComponentBarcodeScannerStartScanSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStartScanSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStartScanSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0));
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStartScanSuccess */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStartScanSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStartScanSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStartScanSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStartScanSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStartScanSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStartScanSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStartScanSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStartScanSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStartScanSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStopScanFailure))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStopScanFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStopScanFailure {
			static internal readonly DMPAccessoryComponentBarcodeScannerStopScanFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStopScanFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStopScanFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStopScanFailure */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStopScanFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStopScanFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStopScanFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStopScanFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStopScanFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStopScanFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStopScanFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStopScanFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStopScanFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentBarcodeScannerStopScanSuccess))]
		internal delegate void DMPAccessoryComponentBarcodeScannerStopScanSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentBarcodeScannerStopScanSuccess {
			static internal readonly DMPAccessoryComponentBarcodeScannerStopScanSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentBarcodeScannerStopScanSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentBarcodeScannerStopScanSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentBarcodeScanner> (arg0));
			}
		} /* class SDMPAccessoryComponentBarcodeScannerStopScanSuccess */
		
		internal class NIDMPAccessoryComponentBarcodeScannerStopScanSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentBarcodeScannerStopScanSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentBarcodeScannerStopScanSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentBarcodeScannerStopScanSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentBarcodeScannerStopScanSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentBarcodeScannerStopScanSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentBarcodeScannerStopScanSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentBarcodeScannerStopScanSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentBarcodeScanner arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentBarcodeScannerStopScanSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionAskForNumberAbort))]
		internal delegate void DMPAccessoryComponentInteractionAskForNumberAbort (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionAskForNumberAbort {
			static internal readonly DMPAccessoryComponentInteractionAskForNumberAbort Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionAskForNumberAbort))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionAskForNumberAbort) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0));
			}
		} /* class SDMPAccessoryComponentInteractionAskForNumberAbort */
		
		internal class NIDMPAccessoryComponentInteractionAskForNumberAbort {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionAskForNumberAbort invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionAskForNumberAbort (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionAskForNumberAbort> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionAskForNumberAbort ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionAskForNumberAbort Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionAskForNumberAbort;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionAskForNumberAbort ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionAskForNumberAbort */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionAskForNumberFailure))]
		internal delegate void DMPAccessoryComponentInteractionAskForNumberFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionAskForNumberFailure {
			static internal readonly DMPAccessoryComponentInteractionAskForNumberFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionAskForNumberFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionAskForNumberFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentInteractionAskForNumberFailure */
		
		internal class NIDMPAccessoryComponentInteractionAskForNumberFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionAskForNumberFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionAskForNumberFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionAskForNumberFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionAskForNumberFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionAskForNumberFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionAskForNumberFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionAskForNumberFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionAskForNumberFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionAskForNumberSuccess))]
		internal delegate void DMPAccessoryComponentInteractionAskForNumberSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionAskForNumberSuccess {
			static internal readonly DMPAccessoryComponentInteractionAskForNumberSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionAskForNumberSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionAskForNumberSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDMPAccessoryComponentInteractionAskForNumberSuccess */
		
		internal class NIDMPAccessoryComponentInteractionAskForNumberSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionAskForNumberSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionAskForNumberSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionAskForNumberSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionAskForNumberSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionAskForNumberSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionAskForNumberSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionAskForNumberSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0, string arg1)
			{
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsarg1);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDMPAccessoryComponentInteractionAskForNumberSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionConfirmationAbort))]
		internal delegate void DMPAccessoryComponentInteractionConfirmationAbort (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionConfirmationAbort {
			static internal readonly DMPAccessoryComponentInteractionConfirmationAbort Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionConfirmationAbort))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionConfirmationAbort) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0));
			}
		} /* class SDMPAccessoryComponentInteractionConfirmationAbort */
		
		internal class NIDMPAccessoryComponentInteractionConfirmationAbort {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionConfirmationAbort invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionConfirmationAbort (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionConfirmationAbort> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionConfirmationAbort ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionConfirmationAbort Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionConfirmationAbort;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionConfirmationAbort ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionConfirmationAbort */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionConfirmationFailure))]
		internal delegate void DMPAccessoryComponentInteractionConfirmationFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionConfirmationFailure {
			static internal readonly DMPAccessoryComponentInteractionConfirmationFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionConfirmationFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionConfirmationFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentInteractionConfirmationFailure */
		
		internal class NIDMPAccessoryComponentInteractionConfirmationFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionConfirmationFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionConfirmationFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionConfirmationFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionConfirmationFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionConfirmationFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionConfirmationFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionConfirmationFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionConfirmationFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionConfirmationSuccess))]
		internal delegate void DMPAccessoryComponentInteractionConfirmationSuccess (IntPtr block, IntPtr arg0, global::Payworks.MPAccessoryComponentInteractionConfirmationKey arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionConfirmationSuccess {
			static internal readonly DMPAccessoryComponentInteractionConfirmationSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionConfirmationSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, global::Payworks.MPAccessoryComponentInteractionConfirmationKey arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionConfirmationSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0), arg1);
			}
		} /* class SDMPAccessoryComponentInteractionConfirmationSuccess */
		
		internal class NIDMPAccessoryComponentInteractionConfirmationSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionConfirmationSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionConfirmationSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionConfirmationSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionConfirmationSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionConfirmationSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionConfirmationSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionConfirmationSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0, global::Payworks.MPAccessoryComponentInteractionConfirmationKey arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1);
			}
		} /* class NIDMPAccessoryComponentInteractionConfirmationSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenFailure))]
		internal delegate void DMPAccessoryComponentInteractionDisplayIdleScreenFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionDisplayIdleScreenFailure {
			static internal readonly DMPAccessoryComponentInteractionDisplayIdleScreenFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionDisplayIdleScreenFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentInteractionDisplayIdleScreenFailure */
		
		internal class NIDMPAccessoryComponentInteractionDisplayIdleScreenFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionDisplayIdleScreenFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionDisplayIdleScreenFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionDisplayIdleScreenFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionDisplayIdleScreenFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionDisplayIdleScreenFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionDisplayIdleScreenFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenSuccess))]
		internal delegate void DMPAccessoryComponentInteractionDisplayIdleScreenSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionDisplayIdleScreenSuccess {
			static internal readonly DMPAccessoryComponentInteractionDisplayIdleScreenSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionDisplayIdleScreenSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0));
			}
		} /* class SDMPAccessoryComponentInteractionDisplayIdleScreenSuccess */
		
		internal class NIDMPAccessoryComponentInteractionDisplayIdleScreenSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionDisplayIdleScreenSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionDisplayIdleScreenSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionDisplayIdleScreenSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionDisplayIdleScreenSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionDisplayIdleScreenSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionDisplayIdleScreenSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionDisplayIdleScreenSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionDisplayTextFailure))]
		internal delegate void DMPAccessoryComponentInteractionDisplayTextFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionDisplayTextFailure {
			static internal readonly DMPAccessoryComponentInteractionDisplayTextFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionDisplayTextFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionDisplayTextFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentInteractionDisplayTextFailure */
		
		internal class NIDMPAccessoryComponentInteractionDisplayTextFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionDisplayTextFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionDisplayTextFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionDisplayTextFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionDisplayTextFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionDisplayTextFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionDisplayTextFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionDisplayTextFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionDisplayTextFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentInteractionDisplayTextSuccess))]
		internal delegate void DMPAccessoryComponentInteractionDisplayTextSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentInteractionDisplayTextSuccess {
			static internal readonly DMPAccessoryComponentInteractionDisplayTextSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentInteractionDisplayTextSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentInteractionDisplayTextSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentInteraction> (arg0));
			}
		} /* class SDMPAccessoryComponentInteractionDisplayTextSuccess */
		
		internal class NIDMPAccessoryComponentInteractionDisplayTextSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentInteractionDisplayTextSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentInteractionDisplayTextSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentInteractionDisplayTextSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentInteractionDisplayTextSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentInteractionDisplayTextSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentInteractionDisplayTextSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentInteractionDisplayTextSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentInteraction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentInteractionDisplayTextSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentLogDeleteLogFailure))]
		internal delegate void DMPAccessoryComponentLogDeleteLogFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentLogDeleteLogFailure {
			static internal readonly DMPAccessoryComponentLogDeleteLogFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentLogDeleteLogFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentLogDeleteLogFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentLog> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentLogDeleteLogFailure */
		
		internal class NIDMPAccessoryComponentLogDeleteLogFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentLogDeleteLogFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentLogDeleteLogFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentLogDeleteLogFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentLogDeleteLogFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentLogDeleteLogFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentLogDeleteLogFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentLogDeleteLogFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentLog arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentLogDeleteLogFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentLogDeleteLogSuccess))]
		internal delegate void DMPAccessoryComponentLogDeleteLogSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentLogDeleteLogSuccess {
			static internal readonly DMPAccessoryComponentLogDeleteLogSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentLogDeleteLogSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentLogDeleteLogSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentLog> (arg0));
			}
		} /* class SDMPAccessoryComponentLogDeleteLogSuccess */
		
		internal class NIDMPAccessoryComponentLogDeleteLogSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentLogDeleteLogSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentLogDeleteLogSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentLogDeleteLogSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentLogDeleteLogSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentLogDeleteLogSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentLogDeleteLogSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentLogDeleteLogSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentLog arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentLogDeleteLogSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentLogDownloadLogFailure))]
		internal delegate void DMPAccessoryComponentLogDownloadLogFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentLogDownloadLogFailure {
			static internal readonly DMPAccessoryComponentLogDownloadLogFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentLogDownloadLogFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentLogDownloadLogFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentLog> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentLogDownloadLogFailure */
		
		internal class NIDMPAccessoryComponentLogDownloadLogFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentLogDownloadLogFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentLogDownloadLogFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentLogDownloadLogFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentLogDownloadLogFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentLogDownloadLogFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentLogDownloadLogFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentLogDownloadLogFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentLog arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentLogDownloadLogFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentLogDownloadLogSuccess))]
		internal delegate void DMPAccessoryComponentLogDownloadLogSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentLogDownloadLogSuccess {
			static internal readonly DMPAccessoryComponentLogDownloadLogSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentLogDownloadLogSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentLogDownloadLogSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentLog> (arg0),  Runtime.GetNSObject<NSData> (arg1));
			}
		} /* class SDMPAccessoryComponentLogDownloadLogSuccess */
		
		internal class NIDMPAccessoryComponentLogDownloadLogSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentLogDownloadLogSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentLogDownloadLogSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentLogDownloadLogSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentLogDownloadLogSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentLogDownloadLogSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentLogDownloadLogSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentLogDownloadLogSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentLog arg0, NSData arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentLogDownloadLogSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentPrinterPrintFailure))]
		internal delegate void DMPAccessoryComponentPrinterPrintFailure (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentPrinterPrintFailure {
			static internal readonly DMPAccessoryComponentPrinterPrintFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentPrinterPrintFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentPrinterPrintFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentPrinter> (arg0),  Runtime.GetNSObject<Payworks.MPReceipt> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDMPAccessoryComponentPrinterPrintFailure */
		
		internal class NIDMPAccessoryComponentPrinterPrintFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentPrinterPrintFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentPrinterPrintFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentPrinterPrintFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentPrinterPrintFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentPrinterPrintFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentPrinterPrintFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentPrinterPrintFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentPrinter arg0, global::Payworks.MPReceipt arg1, NSError arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDMPAccessoryComponentPrinterPrintFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentPrinterPrintSuccess))]
		internal delegate void DMPAccessoryComponentPrinterPrintSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentPrinterPrintSuccess {
			static internal readonly DMPAccessoryComponentPrinterPrintSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentPrinterPrintSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentPrinterPrintSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentPrinter> (arg0),  Runtime.GetNSObject<Payworks.MPReceipt> (arg1));
			}
		} /* class SDMPAccessoryComponentPrinterPrintSuccess */
		
		internal class NIDMPAccessoryComponentPrinterPrintSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentPrinterPrintSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentPrinterPrintSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentPrinterPrintSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentPrinterPrintSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentPrinterPrintSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentPrinterPrintSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentPrinterPrintSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentPrinter arg0, global::Payworks.MPReceipt arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentPrinterPrintSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentTippingAskForTipAbort))]
		internal delegate void DMPAccessoryComponentTippingAskForTipAbort (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentTippingAskForTipAbort {
			static internal readonly DMPAccessoryComponentTippingAskForTipAbort Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentTippingAskForTipAbort))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentTippingAskForTipAbort) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentTipping> (arg0));
			}
		} /* class SDMPAccessoryComponentTippingAskForTipAbort */
		
		internal class NIDMPAccessoryComponentTippingAskForTipAbort {
			IntPtr blockPtr;
			DMPAccessoryComponentTippingAskForTipAbort invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentTippingAskForTipAbort (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentTippingAskForTipAbort> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentTippingAskForTipAbort ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentTippingAskForTipAbort Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentTippingAskForTipAbort;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentTippingAskForTipAbort ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentTipping arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentTippingAskForTipAbort */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentTippingAskForTipFailure))]
		internal delegate void DMPAccessoryComponentTippingAskForTipFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentTippingAskForTipFailure {
			static internal readonly DMPAccessoryComponentTippingAskForTipFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentTippingAskForTipFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentTippingAskForTipFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentTipping> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryComponentTippingAskForTipFailure */
		
		internal class NIDMPAccessoryComponentTippingAskForTipFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentTippingAskForTipFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentTippingAskForTipFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentTippingAskForTipFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentTippingAskForTipFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentTippingAskForTipFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentTippingAskForTipFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentTippingAskForTipFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentTipping arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentTippingAskForTipFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentTippingAskForTipSuccess))]
		internal delegate void DMPAccessoryComponentTippingAskForTipSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentTippingAskForTipSuccess {
			static internal readonly DMPAccessoryComponentTippingAskForTipSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentTippingAskForTipSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentTippingAskForTipSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryComponentTipping> (arg0),  Runtime.GetNSObject<NSDecimalNumber> (arg1));
			}
		} /* class SDMPAccessoryComponentTippingAskForTipSuccess */
		
		internal class NIDMPAccessoryComponentTippingAskForTipSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentTippingAskForTipSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentTippingAskForTipSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentTippingAskForTipSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentTippingAskForTipSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentTippingAskForTipSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentTippingAskForTipSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentTippingAskForTipSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryComponentTipping arg0, NSDecimalNumber arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentTippingAskForTipSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentTippingFailure))]
		internal delegate void DMPAccessoryComponentTippingFailure (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentTippingFailure {
			static internal readonly DMPAccessoryComponentTippingFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentTippingFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentTippingFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDMPAccessoryComponentTippingFailure */
		
		internal class NIDMPAccessoryComponentTippingFailure {
			IntPtr blockPtr;
			DMPAccessoryComponentTippingFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentTippingFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentTippingFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentTippingFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentTippingFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentTippingFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentTippingFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryComponentTippingFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryComponentTippingSuccess))]
		internal delegate void DMPAccessoryComponentTippingSuccess (IntPtr block, bool arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryComponentTippingSuccess {
			static internal readonly DMPAccessoryComponentTippingSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryComponentTippingSuccess))]
			static unsafe void Invoke (IntPtr block, bool arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryComponentTippingSuccess) (descriptor->Target);
				if (del != null)
					del (arg0,  Runtime.GetNSObject<NSDecimalNumber> (arg1));
			}
		} /* class SDMPAccessoryComponentTippingSuccess */
		
		internal class NIDMPAccessoryComponentTippingSuccess {
			IntPtr blockPtr;
			DMPAccessoryComponentTippingSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryComponentTippingSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryComponentTippingSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryComponentTippingSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryComponentTippingSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryComponentTippingSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryComponentTippingSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (bool arg0, NSDecimalNumber arg1)
			{
				invoker (blockPtr, arg0, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryComponentTippingSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryConnectFailure))]
		internal delegate void DMPAccessoryConnectFailure (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryConnectFailure {
			static internal readonly DMPAccessoryConnectFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryConnectFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryConnectFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDMPAccessoryConnectFailure */
		
		internal class NIDMPAccessoryConnectFailure {
			IntPtr blockPtr;
			DMPAccessoryConnectFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryConnectFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryConnectFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryConnectFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryConnectFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryConnectFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryConnectFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryConnectFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryConnectSuccess))]
		internal delegate void DMPAccessoryConnectSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryConnectSuccess {
			static internal readonly DMPAccessoryConnectSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryConnectSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryConnectSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0));
			}
		} /* class SDMPAccessoryConnectSuccess */
		
		internal class NIDMPAccessoryConnectSuccess {
			IntPtr blockPtr;
			DMPAccessoryConnectSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryConnectSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryConnectSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryConnectSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryConnectSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryConnectSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryConnectSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryConnectSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryDisconnectFailure))]
		internal delegate void DMPAccessoryDisconnectFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryDisconnectFailure {
			static internal readonly DMPAccessoryDisconnectFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryDisconnectFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryDisconnectFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryDisconnectFailure */
		
		internal class NIDMPAccessoryDisconnectFailure {
			IntPtr blockPtr;
			DMPAccessoryDisconnectFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryDisconnectFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryDisconnectFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryDisconnectFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryDisconnectFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryDisconnectFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryDisconnectFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryDisconnectFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryDisconnectSuccess))]
		internal delegate void DMPAccessoryDisconnectSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryDisconnectSuccess {
			static internal readonly DMPAccessoryDisconnectSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryDisconnectSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryDisconnectSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0));
			}
		} /* class SDMPAccessoryDisconnectSuccess */
		
		internal class NIDMPAccessoryDisconnectSuccess {
			IntPtr blockPtr;
			DMPAccessoryDisconnectSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryDisconnectSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryDisconnectSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryDisconnectSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryDisconnectSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryDisconnectSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryDisconnectSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryDisconnectSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryOptionalsBlock))]
		internal delegate void DMPAccessoryOptionalsBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryOptionalsBlock {
			static internal readonly DMPAccessoryOptionalsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryOptionalsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryOptionalsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessoryOptionals> (arg0));
			}
		} /* class SDMPAccessoryOptionalsBlock */
		
		internal class NIDMPAccessoryOptionalsBlock {
			IntPtr blockPtr;
			DMPAccessoryOptionalsBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryOptionalsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryOptionalsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryOptionalsBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryOptionalsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryOptionalsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryOptionalsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessoryOptionals arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryOptionalsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryProvisionFailure))]
		internal delegate void DMPAccessoryProvisionFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryProvisionFailure {
			static internal readonly DMPAccessoryProvisionFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryProvisionFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryProvisionFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryProvisionFailure */
		
		internal class NIDMPAccessoryProvisionFailure {
			IntPtr blockPtr;
			DMPAccessoryProvisionFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryProvisionFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryProvisionFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryProvisionFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryProvisionFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryProvisionFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryProvisionFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryProvisionFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryProvisionSuccess))]
		internal delegate void DMPAccessoryProvisionSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryProvisionSuccess {
			static internal readonly DMPAccessoryProvisionSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryProvisionSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryProvisionSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0));
			}
		} /* class SDMPAccessoryProvisionSuccess */
		
		internal class NIDMPAccessoryProvisionSuccess {
			IntPtr blockPtr;
			DMPAccessoryProvisionSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryProvisionSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryProvisionSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryProvisionSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryProvisionSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryProvisionSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryProvisionSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryProvisionSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryUpdateFailure))]
		internal delegate void DMPAccessoryUpdateFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryUpdateFailure {
			static internal readonly DMPAccessoryUpdateFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryUpdateFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryUpdateFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryUpdateFailure */
		
		internal class NIDMPAccessoryUpdateFailure {
			IntPtr blockPtr;
			DMPAccessoryUpdateFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryUpdateFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryUpdateFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryUpdateFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryUpdateFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryUpdateFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryUpdateFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryUpdateFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryUpdateStateFailure))]
		internal delegate void DMPAccessoryUpdateStateFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryUpdateStateFailure {
			static internal readonly DMPAccessoryUpdateStateFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryUpdateStateFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryUpdateStateFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPAccessoryUpdateStateFailure */
		
		internal class NIDMPAccessoryUpdateStateFailure {
			IntPtr blockPtr;
			DMPAccessoryUpdateStateFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryUpdateStateFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryUpdateStateFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryUpdateStateFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryUpdateStateFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryUpdateStateFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryUpdateStateFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPAccessoryUpdateStateFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryUpdateStateSuccess))]
		internal delegate void DMPAccessoryUpdateStateSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryUpdateStateSuccess {
			static internal readonly DMPAccessoryUpdateStateSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryUpdateStateSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryUpdateStateSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0));
			}
		} /* class SDMPAccessoryUpdateStateSuccess */
		
		internal class NIDMPAccessoryUpdateStateSuccess {
			IntPtr blockPtr;
			DMPAccessoryUpdateStateSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryUpdateStateSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryUpdateStateSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryUpdateStateSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryUpdateStateSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryUpdateStateSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryUpdateStateSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryUpdateStateSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPAccessoryUpdateSuccess))]
		internal delegate void DMPAccessoryUpdateSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPAccessoryUpdateSuccess {
			static internal readonly DMPAccessoryUpdateSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPAccessoryUpdateSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPAccessoryUpdateSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0));
			}
		} /* class SDMPAccessoryUpdateSuccess */
		
		internal class NIDMPAccessoryUpdateSuccess {
			IntPtr blockPtr;
			DMPAccessoryUpdateSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPAccessoryUpdateSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPAccessoryUpdateSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPAccessoryUpdateSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPAccessoryUpdateSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPAccessoryUpdateSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPAccessoryUpdateSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPAccessoryUpdateSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPCustomerReceiptSendingFailure))]
		internal delegate void DMPCustomerReceiptSendingFailure (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPCustomerReceiptSendingFailure {
			static internal readonly DMPCustomerReceiptSendingFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPCustomerReceiptSendingFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPCustomerReceiptSendingFailure) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0), NSString.FromHandle (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDMPCustomerReceiptSendingFailure */
		
		internal class NIDMPCustomerReceiptSendingFailure {
			IntPtr blockPtr;
			DMPCustomerReceiptSendingFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPCustomerReceiptSendingFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPCustomerReceiptSendingFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPCustomerReceiptSendingFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPCustomerReceiptSendingFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPCustomerReceiptSendingFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPCustomerReceiptSendingFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, string arg1, NSError arg2)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, nsarg0, nsarg1, arg2 == null ? IntPtr.Zero : arg2.Handle);
				NSString.ReleaseNative (nsarg0);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDMPCustomerReceiptSendingFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPCustomerReceiptSendingSuccess))]
		internal delegate void DMPCustomerReceiptSendingSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPCustomerReceiptSendingSuccess {
			static internal readonly DMPCustomerReceiptSendingSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPCustomerReceiptSendingSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPCustomerReceiptSendingSuccess) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0), NSString.FromHandle (arg1));
			}
		} /* class SDMPCustomerReceiptSendingSuccess */
		
		internal class NIDMPCustomerReceiptSendingSuccess {
			IntPtr blockPtr;
			DMPCustomerReceiptSendingSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPCustomerReceiptSendingSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPCustomerReceiptSendingSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPCustomerReceiptSendingSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPCustomerReceiptSendingSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPCustomerReceiptSendingSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPCustomerReceiptSendingSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, string arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, nsarg0, nsarg1);
				NSString.ReleaseNative (nsarg0);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDMPCustomerReceiptSendingSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPExternalAccessoryOptionalsBlock))]
		internal delegate void DMPExternalAccessoryOptionalsBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPExternalAccessoryOptionalsBlock {
			static internal readonly DMPExternalAccessoryOptionalsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPExternalAccessoryOptionalsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPExternalAccessoryOptionalsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPExternalAccessoryOptionals> (arg0));
			}
		} /* class SDMPExternalAccessoryOptionalsBlock */
		
		internal class NIDMPExternalAccessoryOptionalsBlock {
			IntPtr blockPtr;
			DMPExternalAccessoryOptionalsBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPExternalAccessoryOptionalsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPExternalAccessoryOptionalsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPExternalAccessoryOptionalsBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPExternalAccessoryOptionalsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPExternalAccessoryOptionalsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPExternalAccessoryOptionalsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPExternalAccessoryOptionals arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPExternalAccessoryOptionalsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPPaymentAccessoryDisplayIdleScreenFailure))]
		internal delegate void DMPPaymentAccessoryDisplayIdleScreenFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPPaymentAccessoryDisplayIdleScreenFailure {
			static internal readonly DMPPaymentAccessoryDisplayIdleScreenFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPPaymentAccessoryDisplayIdleScreenFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPPaymentAccessoryDisplayIdleScreenFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPPaymentAccessoryDisplayIdleScreenFailure */
		
		internal class NIDMPPaymentAccessoryDisplayIdleScreenFailure {
			IntPtr blockPtr;
			DMPPaymentAccessoryDisplayIdleScreenFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPPaymentAccessoryDisplayIdleScreenFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPPaymentAccessoryDisplayIdleScreenFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPPaymentAccessoryDisplayIdleScreenFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPPaymentAccessoryDisplayIdleScreenFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPPaymentAccessoryDisplayIdleScreenFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPPaymentAccessoryDisplayIdleScreenFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPPaymentAccessoryDisplayIdleScreenFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPPaymentAccessoryDisplayIdleScreenSuccess))]
		internal delegate void DMPPaymentAccessoryDisplayIdleScreenSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPPaymentAccessoryDisplayIdleScreenSuccess {
			static internal readonly DMPPaymentAccessoryDisplayIdleScreenSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPPaymentAccessoryDisplayIdleScreenSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPPaymentAccessoryDisplayIdleScreenSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0));
			}
		} /* class SDMPPaymentAccessoryDisplayIdleScreenSuccess */
		
		internal class NIDMPPaymentAccessoryDisplayIdleScreenSuccess {
			IntPtr blockPtr;
			DMPPaymentAccessoryDisplayIdleScreenSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPPaymentAccessoryDisplayIdleScreenSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPPaymentAccessoryDisplayIdleScreenSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPPaymentAccessoryDisplayIdleScreenSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPPaymentAccessoryDisplayIdleScreenSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPPaymentAccessoryDisplayIdleScreenSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPPaymentAccessoryDisplayIdleScreenSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPPaymentAccessoryDisplayIdleScreenSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPPaymentAccessoryDisplayTextFailure))]
		internal delegate void DMPPaymentAccessoryDisplayTextFailure (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPPaymentAccessoryDisplayTextFailure {
			static internal readonly DMPPaymentAccessoryDisplayTextFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPPaymentAccessoryDisplayTextFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPPaymentAccessoryDisplayTextFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0), NSArray.ArrayFromHandle<NSObject> (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDMPPaymentAccessoryDisplayTextFailure */
		
		internal class NIDMPPaymentAccessoryDisplayTextFailure {
			IntPtr blockPtr;
			DMPPaymentAccessoryDisplayTextFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPPaymentAccessoryDisplayTextFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPPaymentAccessoryDisplayTextFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPPaymentAccessoryDisplayTextFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPPaymentAccessoryDisplayTextFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPPaymentAccessoryDisplayTextFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPPaymentAccessoryDisplayTextFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSObject[] arg1, NSError arg2)
			{
				var nsa_arg1 = arg1 == null ? null : NSArray.FromNSObjects (arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsa_arg1 == null ? IntPtr.Zero : nsa_arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
				if (nsa_arg1 != null)
					nsa_arg1.Dispose ();
				
			}
		} /* class NIDMPPaymentAccessoryDisplayTextFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPPaymentAccessoryDisplayTextSuccess))]
		internal delegate void DMPPaymentAccessoryDisplayTextSuccess (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPPaymentAccessoryDisplayTextSuccess {
			static internal readonly DMPPaymentAccessoryDisplayTextSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPPaymentAccessoryDisplayTextSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPPaymentAccessoryDisplayTextSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPAccessory> (arg0), NSArray.ArrayFromHandle<NSObject> (arg1));
			}
		} /* class SDMPPaymentAccessoryDisplayTextSuccess */
		
		internal class NIDMPPaymentAccessoryDisplayTextSuccess {
			IntPtr blockPtr;
			DMPPaymentAccessoryDisplayTextSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPPaymentAccessoryDisplayTextSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPPaymentAccessoryDisplayTextSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPPaymentAccessoryDisplayTextSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPPaymentAccessoryDisplayTextSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPPaymentAccessoryDisplayTextSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPPaymentAccessoryDisplayTextSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPAccessory arg0, NSObject[] arg1)
			{
				var nsa_arg1 = arg1 == null ? null : NSArray.FromNSObjects (arg1);
				
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, nsa_arg1 == null ? IntPtr.Zero : nsa_arg1.Handle);
				if (nsa_arg1 != null)
					nsa_arg1.Dispose ();
				
			}
		} /* class NIDMPPaymentAccessoryDisplayTextSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPPrintingProcessCompleted))]
		internal delegate void DMPPrintingProcessCompleted (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPPrintingProcessCompleted {
			static internal readonly DMPPrintingProcessCompleted Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPPrintingProcessCompleted))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPPrintingProcessCompleted) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPPrintingProcess> (arg0),  Runtime.GetNSObject<Payworks.MPTransaction> (arg1),  Runtime.GetNSObject<Payworks.MPPrintingProcessDetails> (arg2));
			}
		} /* class SDMPPrintingProcessCompleted */
		
		internal class NIDMPPrintingProcessCompleted {
			IntPtr blockPtr;
			DMPPrintingProcessCompleted invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPPrintingProcessCompleted (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPPrintingProcessCompleted> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPPrintingProcessCompleted ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPPrintingProcessCompleted Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPPrintingProcessCompleted;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPPrintingProcessCompleted ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPPrintingProcess arg0, global::Payworks.MPTransaction arg1, global::Payworks.MPPrintingProcessDetails arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDMPPrintingProcessCompleted */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPPrintingProcessStatusChanged))]
		internal delegate void DMPPrintingProcessStatusChanged (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPPrintingProcessStatusChanged {
			static internal readonly DMPPrintingProcessStatusChanged Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPPrintingProcessStatusChanged))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPPrintingProcessStatusChanged) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPPrintingProcess> (arg0),  Runtime.GetNSObject<Payworks.MPTransaction> (arg1),  Runtime.GetNSObject<Payworks.MPPrintingProcessDetails> (arg2));
			}
		} /* class SDMPPrintingProcessStatusChanged */
		
		internal class NIDMPPrintingProcessStatusChanged {
			IntPtr blockPtr;
			DMPPrintingProcessStatusChanged invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPPrintingProcessStatusChanged (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPPrintingProcessStatusChanged> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPPrintingProcessStatusChanged ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPPrintingProcessStatusChanged Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPPrintingProcessStatusChanged;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPPrintingProcessStatusChanged ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPPrintingProcess arg0, global::Payworks.MPTransaction arg1, global::Payworks.MPPrintingProcessDetails arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDMPPrintingProcessStatusChanged */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPRefundTransactionApproved))]
		internal delegate void DMPRefundTransactionApproved (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPRefundTransactionApproved {
			static internal readonly DMPRefundTransactionApproved Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPRefundTransactionApproved))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPRefundTransactionApproved) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPRefundTransactionApproved */
		
		internal class NIDMPRefundTransactionApproved {
			IntPtr blockPtr;
			DMPRefundTransactionApproved invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPRefundTransactionApproved (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPRefundTransactionApproved> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPRefundTransactionApproved ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPRefundTransactionApproved Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPRefundTransactionApproved;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPRefundTransactionApproved ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPRefundTransactionApproved */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPRefundTransactionDeclined))]
		internal delegate void DMPRefundTransactionDeclined (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPRefundTransactionDeclined {
			static internal readonly DMPRefundTransactionDeclined Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPRefundTransactionDeclined))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPRefundTransactionDeclined) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPRefundTransactionDeclined */
		
		internal class NIDMPRefundTransactionDeclined {
			IntPtr blockPtr;
			DMPRefundTransactionDeclined invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPRefundTransactionDeclined (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPRefundTransactionDeclined> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPRefundTransactionDeclined ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPRefundTransactionDeclined Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPRefundTransactionDeclined;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPRefundTransactionDeclined ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPRefundTransactionDeclined */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPRefundTransactionFailure))]
		internal delegate void DMPRefundTransactionFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPRefundTransactionFailure {
			static internal readonly DMPRefundTransactionFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPRefundTransactionFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPRefundTransactionFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionParameters> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPRefundTransactionFailure */
		
		internal class NIDMPRefundTransactionFailure {
			IntPtr blockPtr;
			DMPRefundTransactionFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPRefundTransactionFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPRefundTransactionFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPRefundTransactionFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPRefundTransactionFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPRefundTransactionFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPRefundTransactionFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionParameters arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPRefundTransactionFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPRefundTransactionParamsWithoutCardFailure))]
		internal delegate void DMPRefundTransactionParamsWithoutCardFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPRefundTransactionParamsWithoutCardFailure {
			static internal readonly DMPRefundTransactionParamsWithoutCardFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPRefundTransactionParamsWithoutCardFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPRefundTransactionParamsWithoutCardFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionParameters> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPRefundTransactionParamsWithoutCardFailure */
		
		internal class NIDMPRefundTransactionParamsWithoutCardFailure {
			IntPtr blockPtr;
			DMPRefundTransactionParamsWithoutCardFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPRefundTransactionParamsWithoutCardFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPRefundTransactionParamsWithoutCardFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPRefundTransactionParamsWithoutCardFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPRefundTransactionParamsWithoutCardFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPRefundTransactionParamsWithoutCardFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPRefundTransactionParamsWithoutCardFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionParameters arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPRefundTransactionParamsWithoutCardFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPRefundTransactionWithoutCardApproved))]
		internal delegate void DMPRefundTransactionWithoutCardApproved (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPRefundTransactionWithoutCardApproved {
			static internal readonly DMPRefundTransactionWithoutCardApproved Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPRefundTransactionWithoutCardApproved))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPRefundTransactionWithoutCardApproved) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPRefundTransactionWithoutCardApproved */
		
		internal class NIDMPRefundTransactionWithoutCardApproved {
			IntPtr blockPtr;
			DMPRefundTransactionWithoutCardApproved invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPRefundTransactionWithoutCardApproved (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPRefundTransactionWithoutCardApproved> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPRefundTransactionWithoutCardApproved ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPRefundTransactionWithoutCardApproved Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPRefundTransactionWithoutCardApproved;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPRefundTransactionWithoutCardApproved ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPRefundTransactionWithoutCardApproved */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPRefundTransactionWithoutCardDeclined))]
		internal delegate void DMPRefundTransactionWithoutCardDeclined (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPRefundTransactionWithoutCardDeclined {
			static internal readonly DMPRefundTransactionWithoutCardDeclined Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPRefundTransactionWithoutCardDeclined))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPRefundTransactionWithoutCardDeclined) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPRefundTransactionWithoutCardDeclined */
		
		internal class NIDMPRefundTransactionWithoutCardDeclined {
			IntPtr blockPtr;
			DMPRefundTransactionWithoutCardDeclined invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPRefundTransactionWithoutCardDeclined (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPRefundTransactionWithoutCardDeclined> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPRefundTransactionWithoutCardDeclined ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPRefundTransactionWithoutCardDeclined Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPRefundTransactionWithoutCardDeclined;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPRefundTransactionWithoutCardDeclined ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPRefundTransactionWithoutCardDeclined */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionAbort))]
		internal delegate void DMPTransactionAbort (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionAbort {
			static internal readonly DMPTransactionAbort Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionAbort))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionAbort) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPTransactionAbort */
		
		internal class NIDMPTransactionAbort {
			IntPtr blockPtr;
			DMPTransactionAbort invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionAbort (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionAbort> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionAbort ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionAbort Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionAbort;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionAbort ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionAbort */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionAbortFailure))]
		internal delegate void DMPTransactionAbortFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionAbortFailure {
			static internal readonly DMPTransactionAbortFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionAbortFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionAbortFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPTransactionAbortFailure */
		
		internal class NIDMPTransactionAbortFailure {
			IntPtr blockPtr;
			DMPTransactionAbortFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionAbortFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionAbortFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionAbortFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionAbortFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionAbortFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionAbortFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPTransactionAbortFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionAbortSuccess))]
		internal delegate void DMPTransactionAbortSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionAbortSuccess {
			static internal readonly DMPTransactionAbortSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionAbortSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionAbortSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPTransactionAbortSuccess */
		
		internal class NIDMPTransactionAbortSuccess {
			IntPtr blockPtr;
			DMPTransactionAbortSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionAbortSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionAbortSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionAbortSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionAbortSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionAbortSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionAbortSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionAbortSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionActionRequired))]
		internal delegate void DMPTransactionActionRequired (IntPtr block, IntPtr arg0, int arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionActionRequired {
			static internal readonly DMPTransactionActionRequired Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionActionRequired))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, int arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionActionRequired) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0), arg1,  Runtime.GetNSObject<Payworks.MPTransactionActionSupport> (arg2));
			}
		} /* class SDMPTransactionActionRequired */
		
		internal class NIDMPTransactionActionRequired {
			IntPtr blockPtr;
			DMPTransactionActionRequired invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionActionRequired (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionActionRequired> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionActionRequired ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionActionRequired Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionActionRequired;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionActionRequired ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0, int arg1, global::Payworks.MPTransactionActionSupport arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDMPTransactionActionRequired */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionApproval))]
		internal delegate void DMPTransactionApproval (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionApproval {
			static internal readonly DMPTransactionApproval Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionApproval))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionApproval) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPTransactionApproval */
		
		internal class NIDMPTransactionApproval {
			IntPtr blockPtr;
			DMPTransactionApproval invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionApproval (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionApproval> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionApproval ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionApproval Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionApproval;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionApproval ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionApproval */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionCaptureFailure))]
		internal delegate void DMPTransactionCaptureFailure (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionCaptureFailure {
			static internal readonly DMPTransactionCaptureFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionCaptureFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionCaptureFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDMPTransactionCaptureFailure */
		
		internal class NIDMPTransactionCaptureFailure {
			IntPtr blockPtr;
			DMPTransactionCaptureFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionCaptureFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionCaptureFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionCaptureFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionCaptureFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionCaptureFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionCaptureFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionCaptureFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionCaptureSuccess))]
		internal delegate void DMPTransactionCaptureSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionCaptureSuccess {
			static internal readonly DMPTransactionCaptureSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionCaptureSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionCaptureSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPTransactionCaptureSuccess */
		
		internal class NIDMPTransactionCaptureSuccess {
			IntPtr blockPtr;
			DMPTransactionCaptureSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionCaptureSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionCaptureSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionCaptureSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionCaptureSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionCaptureSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionCaptureSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionCaptureSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionDecline))]
		internal delegate void DMPTransactionDecline (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionDecline {
			static internal readonly DMPTransactionDecline Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionDecline))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionDecline) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPTransactionDecline */
		
		internal class NIDMPTransactionDecline {
			IntPtr blockPtr;
			DMPTransactionDecline invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionDecline (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionDecline> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionDecline ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionDecline Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionDecline;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionDecline ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionDecline */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionFailure))]
		internal delegate void DMPTransactionFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionFailure {
			static internal readonly DMPTransactionFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPTransactionFailure */
		
		internal class NIDMPTransactionFailure {
			IntPtr blockPtr;
			DMPTransactionFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPTransactionFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionLookupFailure))]
		internal delegate void DMPTransactionLookupFailure (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionLookupFailure {
			static internal readonly DMPTransactionLookupFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionLookupFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionLookupFailure) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPTransactionLookupFailure */
		
		internal class NIDMPTransactionLookupFailure {
			IntPtr blockPtr;
			DMPTransactionLookupFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionLookupFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionLookupFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionLookupFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionLookupFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionLookupFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionLookupFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, NSError arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (blockPtr, nsarg0, arg1 == null ? IntPtr.Zero : arg1.Handle);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDMPTransactionLookupFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionLookupSuccess))]
		internal delegate void DMPTransactionLookupSuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionLookupSuccess {
			static internal readonly DMPTransactionLookupSuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionLookupSuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionLookupSuccess) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0));
			}
		} /* class SDMPTransactionLookupSuccess */
		
		internal class NIDMPTransactionLookupSuccess {
			IntPtr blockPtr;
			DMPTransactionLookupSuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionLookupSuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionLookupSuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionLookupSuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionLookupSuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionLookupSuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionLookupSuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionLookupSuccess */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionModulQueryCompleted))]
		internal delegate void DMPTransactionModulQueryCompleted (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionModulQueryCompleted {
			static internal readonly DMPTransactionModulQueryCompleted Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionModulQueryCompleted))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionModulQueryCompleted) (descriptor->Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<NSObject> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPTransactionModulQueryCompleted */
		
		internal class NIDMPTransactionModulQueryCompleted {
			IntPtr blockPtr;
			DMPTransactionModulQueryCompleted invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionModulQueryCompleted (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionModulQueryCompleted> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionModulQueryCompleted ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionModulQueryCompleted Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionModulQueryCompleted;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionModulQueryCompleted ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSObject[] arg0, NSError arg1)
			{
				var nsa_arg0 = arg0 == null ? null : NSArray.FromNSObjects (arg0);
				
				invoker (blockPtr, nsa_arg0 == null ? IntPtr.Zero : nsa_arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
				if (nsa_arg0 != null)
					nsa_arg0.Dispose ();
				
			}
		} /* class NIDMPTransactionModulQueryCompleted */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionModuleLookupByTransactionIdentifierCompleted))]
		internal delegate void DMPTransactionModuleLookupByTransactionIdentifierCompleted (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionModuleLookupByTransactionIdentifierCompleted {
			static internal readonly DMPTransactionModuleLookupByTransactionIdentifierCompleted Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionModuleLookupByTransactionIdentifierCompleted))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionModuleLookupByTransactionIdentifierCompleted) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransaction> (arg0),  Runtime.GetNSObject<NSError> (arg1));
			}
		} /* class SDMPTransactionModuleLookupByTransactionIdentifierCompleted */
		
		internal class NIDMPTransactionModuleLookupByTransactionIdentifierCompleted {
			IntPtr blockPtr;
			DMPTransactionModuleLookupByTransactionIdentifierCompleted invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionModuleLookupByTransactionIdentifierCompleted (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionModuleLookupByTransactionIdentifierCompleted> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionModuleLookupByTransactionIdentifierCompleted ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionModuleLookupByTransactionIdentifierCompleted Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionModuleLookupByTransactionIdentifierCompleted;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionModuleLookupByTransactionIdentifierCompleted ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransaction arg0, NSError arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPTransactionModuleLookupByTransactionIdentifierCompleted */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionModuleSendingCustomerReceiptCompleted))]
		internal delegate void DMPTransactionModuleSendingCustomerReceiptCompleted (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionModuleSendingCustomerReceiptCompleted {
			static internal readonly DMPTransactionModuleSendingCustomerReceiptCompleted Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionModuleSendingCustomerReceiptCompleted))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionModuleSendingCustomerReceiptCompleted) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0), NSString.FromHandle (arg1),  Runtime.GetNSObject<NSError> (arg2));
			}
		} /* class SDMPTransactionModuleSendingCustomerReceiptCompleted */
		
		internal class NIDMPTransactionModuleSendingCustomerReceiptCompleted {
			IntPtr blockPtr;
			DMPTransactionModuleSendingCustomerReceiptCompleted invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionModuleSendingCustomerReceiptCompleted (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionModuleSendingCustomerReceiptCompleted> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionModuleSendingCustomerReceiptCompleted ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionModuleSendingCustomerReceiptCompleted Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionModuleSendingCustomerReceiptCompleted;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionModuleSendingCustomerReceiptCompleted ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, string arg1, NSError arg2)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				var nsarg1 = NSString.CreateNative (arg1);
				
				invoker (blockPtr, nsarg0, nsarg1, arg2 == null ? IntPtr.Zero : arg2.Handle);
				NSString.ReleaseNative (nsarg0);
				NSString.ReleaseNative (nsarg1);
				
			}
		} /* class NIDMPTransactionModuleSendingCustomerReceiptCompleted */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionParametersCaptureOptionalsBlock))]
		internal delegate void DMPTransactionParametersCaptureOptionalsBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionParametersCaptureOptionalsBlock {
			static internal readonly DMPTransactionParametersCaptureOptionalsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionParametersCaptureOptionalsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionParametersCaptureOptionalsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionParametersCaptureOptionals> (arg0));
			}
		} /* class SDMPTransactionParametersCaptureOptionalsBlock */
		
		internal class NIDMPTransactionParametersCaptureOptionalsBlock {
			IntPtr blockPtr;
			DMPTransactionParametersCaptureOptionalsBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionParametersCaptureOptionalsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionParametersCaptureOptionalsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionParametersCaptureOptionalsBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionParametersCaptureOptionalsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionParametersCaptureOptionalsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionParametersCaptureOptionalsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionParametersCaptureOptionals arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionParametersCaptureOptionalsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionParametersOptionalsBlock))]
		internal delegate void DMPTransactionParametersOptionalsBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionParametersOptionalsBlock {
			static internal readonly DMPTransactionParametersOptionalsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionParametersOptionalsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionParametersOptionalsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionParametersOptionals> (arg0));
			}
		} /* class SDMPTransactionParametersOptionalsBlock */
		
		internal class NIDMPTransactionParametersOptionalsBlock {
			IntPtr blockPtr;
			DMPTransactionParametersOptionalsBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionParametersOptionalsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionParametersOptionalsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionParametersOptionalsBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionParametersOptionalsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionParametersOptionalsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionParametersOptionalsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionParametersOptionals arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionParametersOptionalsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionParametersRefundOptionalsBlock))]
		internal delegate void DMPTransactionParametersRefundOptionalsBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionParametersRefundOptionalsBlock {
			static internal readonly DMPTransactionParametersRefundOptionalsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionParametersRefundOptionalsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionParametersRefundOptionalsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionParametersRefundOptionals> (arg0));
			}
		} /* class SDMPTransactionParametersRefundOptionalsBlock */
		
		internal class NIDMPTransactionParametersRefundOptionalsBlock {
			IntPtr blockPtr;
			DMPTransactionParametersRefundOptionalsBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionParametersRefundOptionalsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionParametersRefundOptionalsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionParametersRefundOptionalsBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionParametersRefundOptionalsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionParametersRefundOptionalsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionParametersRefundOptionalsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionParametersRefundOptionals arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionParametersRefundOptionalsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionProcessActionRequired))]
		internal delegate void DMPTransactionProcessActionRequired (IntPtr block, IntPtr arg0, IntPtr arg1, int arg2, IntPtr arg3);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionProcessActionRequired {
			static internal readonly DMPTransactionProcessActionRequired Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionProcessActionRequired))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, int arg2, IntPtr arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionProcessActionRequired) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionProcess> (arg0),  Runtime.GetNSObject<Payworks.MPTransaction> (arg1), arg2,  Runtime.GetNSObject<Payworks.MPTransactionActionSupport> (arg3));
			}
		} /* class SDMPTransactionProcessActionRequired */
		
		internal class NIDMPTransactionProcessActionRequired {
			IntPtr blockPtr;
			DMPTransactionProcessActionRequired invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionProcessActionRequired (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionProcessActionRequired> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionProcessActionRequired ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionProcessActionRequired Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionProcessActionRequired;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionProcessActionRequired ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionProcess arg0, global::Payworks.MPTransaction arg1, int arg2, global::Payworks.MPTransactionActionSupport arg3)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2, arg3 == null ? IntPtr.Zero : arg3.Handle);
			}
		} /* class NIDMPTransactionProcessActionRequired */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionProcessCompleted))]
		internal delegate void DMPTransactionProcessCompleted (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionProcessCompleted {
			static internal readonly DMPTransactionProcessCompleted Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionProcessCompleted))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionProcessCompleted) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionProcess> (arg0),  Runtime.GetNSObject<Payworks.MPTransaction> (arg1),  Runtime.GetNSObject<Payworks.MPTransactionProcessDetails> (arg2));
			}
		} /* class SDMPTransactionProcessCompleted */
		
		internal class NIDMPTransactionProcessCompleted {
			IntPtr blockPtr;
			DMPTransactionProcessCompleted invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionProcessCompleted (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionProcessCompleted> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionProcessCompleted ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionProcessCompleted Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionProcessCompleted;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionProcessCompleted ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionProcess arg0, global::Payworks.MPTransaction arg1, global::Payworks.MPTransactionProcessDetails arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDMPTransactionProcessCompleted */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionProcessParametersStepsBlock))]
		internal delegate void DMPTransactionProcessParametersStepsBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionProcessParametersStepsBlock {
			static internal readonly DMPTransactionProcessParametersStepsBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionProcessParametersStepsBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionProcessParametersStepsBlock) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionProcessParametersSteps> (arg0));
			}
		} /* class SDMPTransactionProcessParametersStepsBlock */
		
		internal class NIDMPTransactionProcessParametersStepsBlock {
			IntPtr blockPtr;
			DMPTransactionProcessParametersStepsBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionProcessParametersStepsBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionProcessParametersStepsBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionProcessParametersStepsBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionProcessParametersStepsBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionProcessParametersStepsBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionProcessParametersStepsBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionProcessParametersSteps arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionProcessParametersStepsBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionProcessRegistered))]
		internal delegate void DMPTransactionProcessRegistered (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionProcessRegistered {
			static internal readonly DMPTransactionProcessRegistered Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionProcessRegistered))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionProcessRegistered) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionProcess> (arg0),  Runtime.GetNSObject<Payworks.MPTransaction> (arg1));
			}
		} /* class SDMPTransactionProcessRegistered */
		
		internal class NIDMPTransactionProcessRegistered {
			IntPtr blockPtr;
			DMPTransactionProcessRegistered invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionProcessRegistered (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionProcessRegistered> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionProcessRegistered ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionProcessRegistered Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionProcessRegistered;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionProcessRegistered ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionProcess arg0, global::Payworks.MPTransaction arg1)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle);
			}
		} /* class NIDMPTransactionProcessRegistered */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionProcessStatusChanged))]
		internal delegate void DMPTransactionProcessStatusChanged (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionProcessStatusChanged {
			static internal readonly DMPTransactionProcessStatusChanged Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionProcessStatusChanged))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionProcessStatusChanged) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Payworks.MPTransactionProcess> (arg0),  Runtime.GetNSObject<Payworks.MPTransaction> (arg1),  Runtime.GetNSObject<Payworks.MPTransactionProcessDetails> (arg2));
			}
		} /* class SDMPTransactionProcessStatusChanged */
		
		internal class NIDMPTransactionProcessStatusChanged {
			IntPtr blockPtr;
			DMPTransactionProcessStatusChanged invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionProcessStatusChanged (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionProcessStatusChanged> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionProcessStatusChanged ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionProcessStatusChanged Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionProcessStatusChanged;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionProcessStatusChanged ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::Payworks.MPTransactionProcess arg0, global::Payworks.MPTransaction arg1, global::Payworks.MPTransactionProcessDetails arg2)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDMPTransactionProcessStatusChanged */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionQueryFailure))]
		internal delegate void DMPTransactionQueryFailure (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionQueryFailure {
			static internal readonly DMPTransactionQueryFailure Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionQueryFailure))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionQueryFailure) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSError> (arg0));
			}
		} /* class SDMPTransactionQueryFailure */
		
		internal class NIDMPTransactionQueryFailure {
			IntPtr blockPtr;
			DMPTransactionQueryFailure invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionQueryFailure (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionQueryFailure> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionQueryFailure ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionQueryFailure Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionQueryFailure;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionQueryFailure ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSError arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDMPTransactionQueryFailure */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Payworks.MPTransactionQuerySuccess))]
		internal delegate void DMPTransactionQuerySuccess (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMPTransactionQuerySuccess {
			static internal readonly DMPTransactionQuerySuccess Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DMPTransactionQuerySuccess))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Payworks.MPTransactionQuerySuccess) (descriptor->Target);
				if (del != null)
					del (NSArray.ArrayFromHandle<NSObject> (arg0));
			}
		} /* class SDMPTransactionQuerySuccess */
		
		internal class NIDMPTransactionQuerySuccess {
			IntPtr blockPtr;
			DMPTransactionQuerySuccess invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDMPTransactionQuerySuccess (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DMPTransactionQuerySuccess> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDMPTransactionQuerySuccess ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::Payworks.MPTransactionQuerySuccess Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::Payworks.MPTransactionQuerySuccess;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDMPTransactionQuerySuccess ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSObject[] arg0)
			{
				var nsa_arg0 = arg0 == null ? null : NSArray.FromNSObjects (arg0);
				
				invoker (blockPtr, nsa_arg0 == null ? IntPtr.Zero : nsa_arg0.Handle);
				if (nsa_arg0 != null)
					nsa_arg0.Dispose ();
				
			}
		} /* class NIDMPTransactionQuerySuccess */
	}
}
