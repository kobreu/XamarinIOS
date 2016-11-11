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
	[Register("MPTransactionProcess", true)]
	public unsafe partial class MPTransactionProcess : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionProcess");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionProcess () : base (NSObjectFlag.Empty)
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
		protected MPTransactionProcess (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionProcess (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("continueWithCustomerIdentityVerified:")]
		[CompilerGenerated]
		public virtual void ContinueWithCustomerIdentityVerified (bool verified)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("continueWithCustomerIdentityVerified:"), verified);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("continueWithCustomerIdentityVerified:"), verified);
			}
		}
		
		[Export ("continueWithCustomerSignature:verified:")]
		[CompilerGenerated]
		public virtual void ContinueWithCustomerSignature (global::UIKit.UIImage signature, bool verified)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("continueWithCustomerSignature:verified:"), signature == null ? IntPtr.Zero : signature.Handle, verified);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("continueWithCustomerSignature:verified:"), signature == null ? IntPtr.Zero : signature.Handle, verified);
			}
		}
		
		[Export ("continueWithCustomerSignatureOnReceipt")]
		[CompilerGenerated]
		public virtual void ContinueWithCustomerSignatureOnReceipt ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("continueWithCustomerSignatureOnReceipt"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("continueWithCustomerSignatureOnReceipt"));
			}
		}
		
		[Export ("continueWithSelectedApplication:")]
		[CompilerGenerated]
		public virtual void ContinueWithSelectedApplication (MPApplicationInformation application)
		{
			if (application == null)
				throw new ArgumentNullException ("application");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("continueWithSelectedApplication:"), application.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("continueWithSelectedApplication:"), application.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual MPAccessory Accessory {
			[Export ("accessory", ArgumentSemantic.Retain)]
			get {
				MPAccessory ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPAccessory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessory")));
				} else {
					ret =  Runtime.GetNSObject<MPAccessory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessory")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanBeAborted {
			[Export ("canBeAborted")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canBeAborted"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canBeAborted"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionProcessDetails Details {
			[Export ("details", ArgumentSemantic.Retain)]
			get {
				MPTransactionProcessDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionProcessDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("details")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionProcessDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("details")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionProvider Provider {
			[Export ("provider", ArgumentSemantic.Retain)]
			get {
				MPTransactionProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("provider")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("provider")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RequestAbort {
			[Export ("requestAbort")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestAbort"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestAbort"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransaction Transaction {
			[Export ("transaction", ArgumentSemantic.Retain)]
			get {
				MPTransaction ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransaction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transaction")));
				} else {
					ret =  Runtime.GetNSObject<MPTransaction> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transaction")));
				}
				return ret;
			}
			
		}
		
	} /* class MPTransactionProcess */
}
