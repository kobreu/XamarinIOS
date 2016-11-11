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
	[Register("MPReceipt", true)]
	public unsafe partial class MPReceipt : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPReceipt");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPReceipt () : base (NSObjectFlag.Empty)
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
		protected MPReceipt (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPReceipt (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("receiptLineItemForKey:")]
		[CompilerGenerated]
		public virtual MPReceiptLineItem ReceiptLineItemForKey (MPReceiptLineKey key)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("receiptLineItemForKey:"), (int)key));
			} else {
				return  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("receiptLineItemForKey:"), (int)key));
			}
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem AmountAndCurrency {
			[Export ("amountAndCurrency", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("amountAndCurrency")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("amountAndCurrency")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] ClearingDetails {
			[Export ("clearingDetails", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clearingDetails")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearingDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem Date {
			[Export ("date", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("date")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("date")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem Identifier {
			[Export ("identifier", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("identifier")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] MerchantDetails {
			[Export ("merchantDetails", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("merchantDetails")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("merchantDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] PaymentDetails {
			[Export ("paymentDetails", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("paymentDetails")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("paymentDetails")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PrettyPrinted {
			[Export ("prettyPrinted")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("prettyPrinted")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prettyPrinted")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool PrintSignatureLine {
			[Export ("printSignatureLine")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("printSignatureLine"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("printSignatureLine"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem ReceiptType {
			[Export ("receiptType", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiptType")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiptType")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem StatusText {
			[Export ("statusText", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statusText")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("statusText")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem Subject {
			[Export ("subject", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subject")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subject")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem Time {
			[Export ("time", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("time")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("time")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPReceiptLineItem TransactionType {
			[Export ("transactionType", ArgumentSemantic.Retain)]
			get {
				MPReceiptLineItem ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionType")));
				} else {
					ret =  Runtime.GetNSObject<MPReceiptLineItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionType")));
				}
				return ret;
			}
			
		}
		
	} /* class MPReceipt */
}
