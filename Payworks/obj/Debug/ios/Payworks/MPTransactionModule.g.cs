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
	[Register("MPTransactionModule", true)]
	public unsafe partial class MPTransactionModule : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionModule");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionModule () : base (NSObjectFlag.Empty)
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
		protected MPTransactionModule (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionModule (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("lookupTransactionWithTransactionIdentifier:completed:")]
		[CompilerGenerated]
		public unsafe virtual void LookupTransactionWithTransactionIdentifier (string transactionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionModuleLookupByTransactionIdentifierCompleted))]MPTransactionModuleLookupByTransactionIdentifierCompleted completed)
		{
			if (transactionIdentifier == null)
				throw new ArgumentNullException ("transactionIdentifier");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			var nstransactionIdentifier = NSString.CreateNative (transactionIdentifier);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionModuleLookupByTransactionIdentifierCompleted.Handler, completed);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("lookupTransactionWithTransactionIdentifier:completed:"), nstransactionIdentifier, (IntPtr) block_ptr_completed);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("lookupTransactionWithTransactionIdentifier:completed:"), nstransactionIdentifier, (IntPtr) block_ptr_completed);
			}
			NSString.ReleaseNative (nstransactionIdentifier);
			block_ptr_completed->CleanupBlock ();
			
		}
		
		[Export ("queryTransactionsUsingFilters:completed:")]
		[CompilerGenerated]
		public unsafe virtual void QueryTransactionsUsingFilters (MPTransactionFilterParameters filterParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionModulQueryCompleted))]MPTransactionModulQueryCompleted completed)
		{
			if (completed == null)
				throw new ArgumentNullException ("completed");
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionModulQueryCompleted.Handler, completed);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("queryTransactionsUsingFilters:completed:"), filterParameters == null ? IntPtr.Zero : filterParameters.Handle, (IntPtr) block_ptr_completed);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("queryTransactionsUsingFilters:completed:"), filterParameters == null ? IntPtr.Zero : filterParameters.Handle, (IntPtr) block_ptr_completed);
			}
			block_ptr_completed->CleanupBlock ();
			
		}
		
		[Export ("queryTransactionsUsingFilters:includeReceipts:range:completed:")]
		[CompilerGenerated]
		public unsafe virtual void QueryTransactionsUsingFilters (MPTransactionFilterParameters filterParameters, bool includeReceipts, NSRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionModulQueryCompleted))]MPTransactionModulQueryCompleted completed)
		{
			if (completed == null)
				throw new ArgumentNullException ("completed");
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionModulQueryCompleted.Handler, completed);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_NSRange_IntPtr (this.Handle, Selector.GetHandle ("queryTransactionsUsingFilters:includeReceipts:range:completed:"), filterParameters == null ? IntPtr.Zero : filterParameters.Handle, includeReceipts, range, (IntPtr) block_ptr_completed);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_NSRange_IntPtr (this.SuperHandle, Selector.GetHandle ("queryTransactionsUsingFilters:includeReceipts:range:completed:"), filterParameters == null ? IntPtr.Zero : filterParameters.Handle, includeReceipts, range, (IntPtr) block_ptr_completed);
			}
			block_ptr_completed->CleanupBlock ();
			
		}
		
		[Export ("sendCustomerReceiptForTransactionIdentifier:emailAddress:completed:")]
		[CompilerGenerated]
		public unsafe virtual void SendCustomerReceiptForTransactionIdentifier (string transactionIdentifier, string emailAddress, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionModuleSendingCustomerReceiptCompleted))]MPTransactionModuleSendingCustomerReceiptCompleted completed)
		{
			if (transactionIdentifier == null)
				throw new ArgumentNullException ("transactionIdentifier");
			if (emailAddress == null)
				throw new ArgumentNullException ("emailAddress");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			var nstransactionIdentifier = NSString.CreateNative (transactionIdentifier);
			var nsemailAddress = NSString.CreateNative (emailAddress);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionModuleSendingCustomerReceiptCompleted.Handler, completed);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendCustomerReceiptForTransactionIdentifier:emailAddress:completed:"), nstransactionIdentifier, nsemailAddress, (IntPtr) block_ptr_completed);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendCustomerReceiptForTransactionIdentifier:emailAddress:completed:"), nstransactionIdentifier, nsemailAddress, (IntPtr) block_ptr_completed);
			}
			NSString.ReleaseNative (nstransactionIdentifier);
			NSString.ReleaseNative (nsemailAddress);
			block_ptr_completed->CleanupBlock ();
			
		}
		
	} /* class MPTransactionModule */
}
