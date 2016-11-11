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
	[Register("MPTransaction", true)]
	public unsafe partial class MPTransaction : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransaction");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransaction () : base (NSObjectFlag.Empty)
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
		protected MPTransaction (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransaction (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string Amount {
			[Export ("amount", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("amount")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("amount")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject CanBeAborted {
			[Export ("canBeAborted")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("canBeAborted")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canBeAborted")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Captured {
			[Export ("captured")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("captured"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("captured"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPCardDetails CardDetails {
			[Export ("cardDetails", ArgumentSemantic.Retain)]
			get {
				MPCardDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPCardDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cardDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPCardDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPClearingDetails ClearingDetails {
			[Export ("clearingDetails", ArgumentSemantic.Retain)]
			get {
				MPClearingDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPClearingDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clearingDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPClearingDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearingDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Created {
			[Export ("created", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("created")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("created")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Currency {
			[Export ("currency")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("currency"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("currency"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceipt CustomerReceipt {
			[Export ("customerReceipt", ArgumentSemantic.Retain)]
			get {
				MPReceipt ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customerReceipt")));
				} else {
					ret =  Runtime.GetNSObject<MPReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customerReceipt")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string CustomIdentifier {
			[Export ("customIdentifier", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionDetails Details {
			[Export ("details", ArgumentSemantic.Retain)]
			get {
				MPTransactionDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("details")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("details")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Error {
			[Export ("error", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("error")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("error")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string GroupIdentifier {
			[Export ("groupIdentifier", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("groupIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("groupIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Identifier {
			[Export ("identifier", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("identifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceipt MerchantReceipt {
			[Export ("merchantReceipt", ArgumentSemantic.Retain)]
			get {
				MPReceipt ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("merchantReceipt")));
				} else {
					ret =  Runtime.GetNSObject<MPReceipt> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantReceipt")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPPaymentDetails PaymentDetails {
			[Export ("paymentDetails", ArgumentSemantic.Retain)]
			get {
				MPPaymentDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPPaymentDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paymentDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPPaymentDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPProcessingDetails ProcessingDetails {
			[Export ("processingDetails", ArgumentSemantic.Retain)]
			get {
				MPProcessingDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPProcessingDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("processingDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPProcessingDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("processingDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ReferencedTransactionIdentifier {
			[Export ("referencedTransactionIdentifier", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("referencedTransactionIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("referencedTransactionIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPRefundDetails RefundDetails {
			[Export ("refundDetails", ArgumentSemantic.Retain)]
			get {
				MPRefundDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPRefundDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("refundDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPRefundDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("refundDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SessionIdentifier {
			[Export ("sessionIdentifier", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sessionIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sessionIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPShopperDetails ShopperDetails {
			[Export ("shopperDetails", ArgumentSemantic.Retain)]
			get {
				MPShopperDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPShopperDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shopperDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPShopperDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shopperDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int State {
			[Export ("state")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("state"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("state"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string StatementDescriptor {
			[Export ("statementDescriptor", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statementDescriptor")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("statementDescriptor")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Status {
			[Export ("status")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("status"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("status"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPStatusDetails StatusDetails {
			[Export ("statusDetails", ArgumentSemantic.Retain)]
			get {
				MPStatusDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPStatusDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statusDetails")));
				} else {
					ret =  Runtime.GetNSObject<MPStatusDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("statusDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Subject {
			[Export ("subject", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subject")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subject")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Type {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
				}
			}
			
		}
		
	} /* class MPTransaction */
}
