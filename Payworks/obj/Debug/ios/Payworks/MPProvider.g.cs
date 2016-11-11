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
	[Register("MPProvider", true)]
	public unsafe partial class MPProvider : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPProvider () : base (NSObjectFlag.Empty)
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
		protected MPProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("abortTransaction:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void AbortTransaction (MPTransaction transaction, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionAbortSuccess))]MPTransactionAbortSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionAbortFailure))]MPTransactionAbortFailure failure)
		{
			if (transaction == null)
				throw new ArgumentNullException ("transaction");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPTransactionAbortSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionAbortFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("abortTransaction:success:failure:"), transaction.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("abortTransaction:success:failure:"), transaction.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("abortTransaction:reason:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void AbortTransaction (MPTransaction transaction, MPTransactionAbortReason reason, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionAbortSuccess))]MPTransactionAbortSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionAbortFailure))]MPTransactionAbortFailure failure)
		{
			if (transaction == null)
				throw new ArgumentNullException ("transaction");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPTransactionAbortSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionAbortFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("abortTransaction:reason:success:failure:"), transaction.Handle, (UInt32)reason, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("abortTransaction:reason:success:failure:"), transaction.Handle, (UInt32)reason, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("addAccessoryComponentCallback:")]
		[CompilerGenerated]
		public virtual void AddAccessoryComponentCallback (MPAccessoryComponentDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAccessoryComponentCallback:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAccessoryComponentCallback:"), @delegate.Handle);
			}
		}
		
		[Export ("addProviderComponentDelegate:")]
		[CompilerGenerated]
		public virtual void AddProviderComponentDelegate (MPProviderComponentDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addProviderComponentDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addProviderComponentDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("captureTransactionWithParameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void CaptureTransactionWithParameters (MPTransactionParameters parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionCaptureSuccess))]MPTransactionCaptureSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionCaptureFailure))]MPTransactionCaptureFailure failure)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPTransactionCaptureSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionCaptureFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("captureTransactionWithParameters:success:failure:"), parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("captureTransactionWithParameters:success:failure:"), parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("checkUpdateRequirementForAccessory:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void CheckUpdateRequirementForAccessory (MPAccessory accessory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryCheckUpdateSuccess))]MPAccessoryCheckUpdateSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryCheckUpdateFailure))]MPAccessoryCheckUpdateFailure failure)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryCheckUpdateSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryCheckUpdateFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("checkUpdateRequirementForAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("checkUpdateRequirementForAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("connectToAccessoryWithParameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void ConnectToAccessoryWithParameters (MPAccessoryParameters parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryConnectSuccess))]MPAccessoryConnectSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryConnectFailure))]MPAccessoryConnectFailure failure)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryConnectSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryConnectFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("connectToAccessoryWithParameters:success:failure:"), parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("connectToAccessoryWithParameters:success:failure:"), parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("continueTransaction:withAction:response:")]
		[CompilerGenerated]
		public virtual void ContinueTransaction (MPTransaction transaction, NSObject action, MPTransactionActionResponse response)
		{
			if (transaction == null)
				throw new ArgumentNullException ("transaction");
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("continueTransaction:withAction:response:"), transaction.Handle, action.Handle, response == null ? IntPtr.Zero : response.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("continueTransaction:withAction:response:"), transaction.Handle, action.Handle, response == null ? IntPtr.Zero : response.Handle);
			}
		}
		
		[Export ("disconnectFromAccessory:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void DisconnectFromAccessory (MPAccessory accessory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryDisconnectSuccess))]MPAccessoryDisconnectSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryDisconnectFailure))]MPAccessoryDisconnectFailure failure)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryDisconnectSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryDisconnectFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("disconnectFromAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("disconnectFromAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("lookupTransactionWithSessionIdentifier:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void LookupTransactionWithSessionIdentifier (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionLookupSuccess))]MPTransactionLookupSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionLookupFailure))]MPTransactionLookupFailure failure)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsidentifier = NSString.CreateNative (identifier);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPTransactionLookupSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionLookupFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("lookupTransactionWithSessionIdentifier:success:failure:"), nsidentifier, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("lookupTransactionWithSessionIdentifier:success:failure:"), nsidentifier, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nsidentifier);
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("lookupTransactionWithTransactionIdentifier:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void LookupTransactionWithTransactionIdentifier (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionLookupSuccess))]MPTransactionLookupSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionLookupFailure))]MPTransactionLookupFailure failure)
		{
			if (identifier == null)
				throw new ArgumentNullException ("identifier");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nsidentifier = NSString.CreateNative (identifier);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPTransactionLookupSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionLookupFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("lookupTransactionWithTransactionIdentifier:success:failure:"), nsidentifier, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("lookupTransactionWithTransactionIdentifier:success:failure:"), nsidentifier, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nsidentifier);
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("provisionAccessory:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void ProvisionAccessory (MPAccessory accessory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryProvisionSuccess))]MPAccessoryProvisionSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryProvisionFailure))]MPAccessoryProvisionFailure failure)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryProvisionSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryProvisionFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("provisionAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("provisionAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("queryTransactionsUsingFilters:includeReceipts:range:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void QueryTransactionsUsingFilters (MPTransactionFilterParameters filterParameters, bool includeReceipts, NSRange range, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionQuerySuccess))]MPTransactionQuerySuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionQueryFailure))]MPTransactionQueryFailure failure)
		{
			if (filterParameters == null)
				throw new ArgumentNullException ("filterParameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPTransactionQuerySuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionQueryFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_NSRange_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("queryTransactionsUsingFilters:includeReceipts:range:success:failure:"), filterParameters.Handle, includeReceipts, range, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_NSRange_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("queryTransactionsUsingFilters:includeReceipts:range:success:failure:"), filterParameters.Handle, includeReceipts, range, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("refundTransactionWithoutCardForParameters:approved:declined:failure:")]
		[CompilerGenerated]
		public unsafe virtual void RefundTransactionWithoutCardForParameters (MPTransactionParameters transactionParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPRefundTransactionWithoutCardApproved))]MPRefundTransactionWithoutCardApproved approved, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPRefundTransactionWithoutCardDeclined))]MPRefundTransactionWithoutCardDeclined declined, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPRefundTransactionParamsWithoutCardFailure))]MPRefundTransactionParamsWithoutCardFailure failure)
		{
			if (transactionParameters == null)
				throw new ArgumentNullException ("transactionParameters");
			if (approved == null)
				throw new ArgumentNullException ("approved");
			if (declined == null)
				throw new ArgumentNullException ("declined");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_approved;
			BlockLiteral block_approved;
			block_approved = new BlockLiteral ();
			block_ptr_approved = &block_approved;
			block_approved.SetupBlock (Trampolines.SDMPRefundTransactionWithoutCardApproved.Handler, approved);
			BlockLiteral *block_ptr_declined;
			BlockLiteral block_declined;
			block_declined = new BlockLiteral ();
			block_ptr_declined = &block_declined;
			block_declined.SetupBlock (Trampolines.SDMPRefundTransactionWithoutCardDeclined.Handler, declined);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPRefundTransactionParamsWithoutCardFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("refundTransactionWithoutCardForParameters:approved:declined:failure:"), transactionParameters.Handle, (IntPtr) block_ptr_approved, (IntPtr) block_ptr_declined, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("refundTransactionWithoutCardForParameters:approved:declined:failure:"), transactionParameters.Handle, (IntPtr) block_ptr_approved, (IntPtr) block_ptr_declined, (IntPtr) block_ptr_failure);
			}
			block_ptr_approved->CleanupBlock ();
			block_ptr_declined->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("refundTransactionWithParameters:approved:declined:failure:")]
		[CompilerGenerated]
		public unsafe virtual void RefundTransactionWithParameters (MPTransactionParameters transactionParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPRefundTransactionApproved))]MPRefundTransactionApproved approved, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPRefundTransactionDeclined))]MPRefundTransactionDeclined declined, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPRefundTransactionFailure))]MPRefundTransactionFailure failure)
		{
			if (transactionParameters == null)
				throw new ArgumentNullException ("transactionParameters");
			if (approved == null)
				throw new ArgumentNullException ("approved");
			if (declined == null)
				throw new ArgumentNullException ("declined");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_approved;
			BlockLiteral block_approved;
			block_approved = new BlockLiteral ();
			block_ptr_approved = &block_approved;
			block_approved.SetupBlock (Trampolines.SDMPRefundTransactionApproved.Handler, approved);
			BlockLiteral *block_ptr_declined;
			BlockLiteral block_declined;
			block_declined = new BlockLiteral ();
			block_ptr_declined = &block_declined;
			block_declined.SetupBlock (Trampolines.SDMPRefundTransactionDeclined.Handler, declined);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPRefundTransactionFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("refundTransactionWithParameters:approved:declined:failure:"), transactionParameters.Handle, (IntPtr) block_ptr_approved, (IntPtr) block_ptr_declined, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("refundTransactionWithParameters:approved:declined:failure:"), transactionParameters.Handle, (IntPtr) block_ptr_approved, (IntPtr) block_ptr_declined, (IntPtr) block_ptr_failure);
			}
			block_ptr_approved->CleanupBlock ();
			block_ptr_declined->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("removeAccessoryComponentCallback:")]
		[CompilerGenerated]
		public virtual void RemoveAccessoryComponentCallback (MPAccessoryComponentDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAccessoryComponentCallback:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAccessoryComponentCallback:"), @delegate.Handle);
			}
		}
		
		[Export ("removeProviderComponentDelegate:")]
		[CompilerGenerated]
		public virtual void RemoveProviderComponentDelegate (MPProviderComponentDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeProviderComponentDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeProviderComponentDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("sendCustomerReceiptForTransactionIdentifier:emailAddress:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void SendCustomerReceiptForTransactionIdentifier (string transactionIdentifier, string emailAddress, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPCustomerReceiptSendingSuccess))]MPCustomerReceiptSendingSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPCustomerReceiptSendingFailure))]MPCustomerReceiptSendingFailure failure)
		{
			if (transactionIdentifier == null)
				throw new ArgumentNullException ("transactionIdentifier");
			if (emailAddress == null)
				throw new ArgumentNullException ("emailAddress");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			var nstransactionIdentifier = NSString.CreateNative (transactionIdentifier);
			var nsemailAddress = NSString.CreateNative (emailAddress);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPCustomerReceiptSendingSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPCustomerReceiptSendingFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendCustomerReceiptForTransactionIdentifier:emailAddress:success:failure:"), nstransactionIdentifier, nsemailAddress, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendCustomerReceiptForTransactionIdentifier:emailAddress:success:failure:"), nstransactionIdentifier, nsemailAddress, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nstransactionIdentifier);
			NSString.ReleaseNative (nsemailAddress);
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("startTransaction:usingAccessory:approval:decline:abort:failure:actionRequired:")]
		[CompilerGenerated]
		public unsafe virtual void StartTransaction (MPTransaction transaction, MPAccessory accessory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionApproval))]MPTransactionApproval approval, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionDecline))]MPTransactionDecline decline, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionAbort))]MPTransactionAbort abort, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionFailure))]MPTransactionFailure failure, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionActionRequired))]MPTransactionActionRequired actionRequired)
		{
			if (transaction == null)
				throw new ArgumentNullException ("transaction");
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (approval == null)
				throw new ArgumentNullException ("approval");
			if (decline == null)
				throw new ArgumentNullException ("decline");
			if (abort == null)
				throw new ArgumentNullException ("abort");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			if (actionRequired == null)
				throw new ArgumentNullException ("actionRequired");
			BlockLiteral *block_ptr_approval;
			BlockLiteral block_approval;
			block_approval = new BlockLiteral ();
			block_ptr_approval = &block_approval;
			block_approval.SetupBlock (Trampolines.SDMPTransactionApproval.Handler, approval);
			BlockLiteral *block_ptr_decline;
			BlockLiteral block_decline;
			block_decline = new BlockLiteral ();
			block_ptr_decline = &block_decline;
			block_decline.SetupBlock (Trampolines.SDMPTransactionDecline.Handler, decline);
			BlockLiteral *block_ptr_abort;
			BlockLiteral block_abort;
			block_abort = new BlockLiteral ();
			block_ptr_abort = &block_abort;
			block_abort.SetupBlock (Trampolines.SDMPTransactionAbort.Handler, abort);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPTransactionFailure.Handler, failure);
			BlockLiteral *block_ptr_actionRequired;
			BlockLiteral block_actionRequired;
			block_actionRequired = new BlockLiteral ();
			block_ptr_actionRequired = &block_actionRequired;
			block_actionRequired.SetupBlock (Trampolines.SDMPTransactionActionRequired.Handler, actionRequired);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startTransaction:usingAccessory:approval:decline:abort:failure:actionRequired:"), transaction.Handle, accessory.Handle, (IntPtr) block_ptr_approval, (IntPtr) block_ptr_decline, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure, (IntPtr) block_ptr_actionRequired);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startTransaction:usingAccessory:approval:decline:abort:failure:actionRequired:"), transaction.Handle, accessory.Handle, (IntPtr) block_ptr_approval, (IntPtr) block_ptr_decline, (IntPtr) block_ptr_abort, (IntPtr) block_ptr_failure, (IntPtr) block_ptr_actionRequired);
			}
			block_ptr_approval->CleanupBlock ();
			block_ptr_decline->CleanupBlock ();
			block_ptr_abort->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			block_ptr_actionRequired->CleanupBlock ();
			
		}
		
		[Export ("updateAccessory:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void UpdateAccessory (MPAccessory accessory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryUpdateSuccess))]MPAccessoryUpdateSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryUpdateFailure))]MPAccessoryUpdateFailure failure)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryUpdateSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryUpdateFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateAccessory:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("updateAccessoryState:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void UpdateAccessoryState (MPAccessory accessory, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryUpdateStateSuccess))]MPAccessoryUpdateStateSuccess success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryUpdateStateFailure))]MPAccessoryUpdateStateFailure failure)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDMPAccessoryUpdateStateSuccess.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDMPAccessoryUpdateStateFailure.Handler, failure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateAccessoryState:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateAccessoryState:success:failure:"), accessory.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual NSSet Accessories {
			[Export ("accessories", ArgumentSemantic.Retain)]
			get {
				NSSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessories")));
				} else {
					ret =  Runtime.GetNSObject<NSSet> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessories")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::CoreFoundation.DispatchQueue CallbackQueue {
			[Export ("callbackQueue", ArgumentSemantic.Retain)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("callbackQueue"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("callbackQueue"));
				}
				return ret == IntPtr.Zero ? null : new global::CoreFoundation.DispatchQueue (ret);
			}
			
			[Export ("setCallbackQueue:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCallbackQueue:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCallbackQueue:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual MPPaymentDetailsFactory PaymentDetailsFactory {
			[Export ("paymentDetailsFactory", ArgumentSemantic.Retain)]
			get {
				MPPaymentDetailsFactory ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPPaymentDetailsFactory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paymentDetailsFactory")));
				} else {
					ret =  Runtime.GetNSObject<MPPaymentDetailsFactory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentDetailsFactory")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPProviderMode ProviderMode {
			[Export ("providerMode", ArgumentSemantic.UnsafeUnretained)]
			get {
				MPProviderMode ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (MPProviderMode) global::ApiDefinition.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("providerMode"));
					} else {
						ret = (MPProviderMode) global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("providerMode"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (MPProviderMode) global::ApiDefinition.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("providerMode"));
					} else {
						ret = (MPProviderMode) global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("providerMode"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int SupportedActions {
			[Export ("supportedActions")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("supportedActions"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportedActions"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionActionResponseFactory TransactionActionResponseFactory {
			[Export ("transactionActionResponseFactory", ArgumentSemantic.Retain)]
			get {
				MPTransactionActionResponseFactory ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionActionResponseFactory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionActionResponseFactory")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionActionResponseFactory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionActionResponseFactory")));
				}
				return ret;
			}
			
		}
		
	} /* class MPProvider */
}
