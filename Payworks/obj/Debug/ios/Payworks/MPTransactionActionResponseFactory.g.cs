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
	[Register("MPTransactionActionResponseFactory", true)]
	public unsafe partial class MPTransactionActionResponseFactory : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionActionResponseFactory");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionActionResponseFactory () : base (NSObjectFlag.Empty)
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
		protected MPTransactionActionResponseFactory (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionActionResponseFactory (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("responseForApplicationSelectionWithApplication:")]
		[CompilerGenerated]
		public virtual MPTransactionActionResponse ResponseForApplicationSelectionWithApplication (MPApplicationInformation application)
		{
			if (application == null)
				throw new ArgumentNullException ("application");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("responseForApplicationSelectionWithApplication:"), application.Handle));
			} else {
				return  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("responseForApplicationSelectionWithApplication:"), application.Handle));
			}
		}
		
		[Export ("responseForCustomerIdentificationWithResult:")]
		[CompilerGenerated]
		public virtual MPTransactionActionResponse ResponseForCustomerIdentificationWithResult (bool customerVerified)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("responseForCustomerIdentificationWithResult:"), customerVerified));
			} else {
				return  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("responseForCustomerIdentificationWithResult:"), customerVerified));
			}
		}
		
		[Export ("responseForCustomerSignatureWithResult:signature:")]
		[CompilerGenerated]
		public virtual MPTransactionActionResponse ResponseForCustomerSignatureWithResult (bool signatureVerified, global::UIKit.UIImage signature)
		{
			if (signature == null)
				throw new ArgumentNullException ("signature");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("responseForCustomerSignatureWithResult:signature:"), signatureVerified, signature.Handle));
			} else {
				return  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("responseForCustomerSignatureWithResult:signature:"), signatureVerified, signature.Handle));
			}
		}
		
		[CompilerGenerated]
		public virtual MPTransactionActionResponse ResponseForCustomerSignatureOnReceipt {
			[Export ("responseForCustomerSignatureOnReceipt")]
			get {
				MPTransactionActionResponse ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseForCustomerSignatureOnReceipt")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionActionResponse> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseForCustomerSignatureOnReceipt")));
				}
				return ret;
			}
			
		}
		
	} /* class MPTransactionActionResponseFactory */
}
