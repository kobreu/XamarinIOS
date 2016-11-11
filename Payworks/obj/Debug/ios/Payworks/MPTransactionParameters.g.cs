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
	[Register("MPTransactionParameters", true)]
	public unsafe partial class MPTransactionParameters : NSObject, INSCopying {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionParameters");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionParameters () : base (NSObjectFlag.Empty)
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
		protected MPTransactionParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionParameters (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("captureTransactionWithIdentifier:optionals:")]
		[CompilerGenerated]
		public unsafe static MPTransactionParameters CaptureTransactionWithIdentifier (string transactionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionParametersCaptureOptionalsBlock))]MPTransactionParametersCaptureOptionalsBlock optionalsBlock)
		{
			if (transactionIdentifier == null)
				throw new ArgumentNullException ("transactionIdentifier");
			var nstransactionIdentifier = NSString.CreateNative (transactionIdentifier);
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPTransactionParametersCaptureOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPTransactionParameters ret;
			ret =  Runtime.GetNSObject<MPTransactionParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("captureTransactionWithIdentifier:optionals:"), nstransactionIdentifier, (IntPtr) block_ptr_optionalsBlock));
			NSString.ReleaseNative (nstransactionIdentifier);
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("chargeWithAmount:currency:optionals:")]
		[CompilerGenerated]
		public unsafe static MPTransactionParameters ChargeWithAmount (NSDecimalNumber amount, MPCurrency currency, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionParametersOptionalsBlock))]MPTransactionParametersOptionalsBlock optionalsBlock)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPTransactionParametersOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPTransactionParameters ret;
			if (IntPtr.Size == 8) {
				ret =  Runtime.GetNSObject<MPTransactionParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr (class_ptr, Selector.GetHandle ("chargeWithAmount:currency:optionals:"), amount.Handle, (Int64)currency, (IntPtr) block_ptr_optionalsBlock));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_int_IntPtr (class_ptr, Selector.GetHandle ("chargeWithAmount:currency:optionals:"), amount.Handle, (int)currency, (IntPtr) block_ptr_optionalsBlock));
			}
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("copyWithZone:")]
		[CompilerGenerated]
		[Preserve (Conditional = true)]
		public virtual NSObject Copy (NSZone zone)
		{
			if (zone == null)
				throw new ArgumentNullException ("zone");
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			} else {
				return Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("copyWithZone:"), zone.Handle));
			}
		}
		
		[Export ("refundForCustomIdentifier:optionals:")]
		[CompilerGenerated]
		public unsafe static MPTransactionParameters RefundForCustomIdentifier (string customIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionParametersRefundOptionalsBlock))]MPTransactionParametersRefundOptionalsBlock optionalsBlock)
		{
			if (customIdentifier == null)
				throw new ArgumentNullException ("customIdentifier");
			var nscustomIdentifier = NSString.CreateNative (customIdentifier);
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPTransactionParametersRefundOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPTransactionParameters ret;
			ret =  Runtime.GetNSObject<MPTransactionParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("refundForCustomIdentifier:optionals:"), nscustomIdentifier, (IntPtr) block_ptr_optionalsBlock));
			NSString.ReleaseNative (nscustomIdentifier);
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("refundForTransactionIdentifier:optionals:")]
		[CompilerGenerated]
		public unsafe static MPTransactionParameters RefundForTransactionIdentifier (string transactionIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionParametersRefundOptionalsBlock))]MPTransactionParametersRefundOptionalsBlock optionalsBlock)
		{
			if (transactionIdentifier == null)
				throw new ArgumentNullException ("transactionIdentifier");
			var nstransactionIdentifier = NSString.CreateNative (transactionIdentifier);
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPTransactionParametersRefundOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPTransactionParameters ret;
			ret =  Runtime.GetNSObject<MPTransactionParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("refundForTransactionIdentifier:optionals:"), nstransactionIdentifier, (IntPtr) block_ptr_optionalsBlock));
			NSString.ReleaseNative (nstransactionIdentifier);
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber Amount {
			[Export ("amount", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("amount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("amount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber ApplicationFee {
			[Export ("applicationFee", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applicationFee")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationFee")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool AutoCapture {
			[Export ("autoCapture")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoCapture"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autoCapture"));
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
		public virtual string CustomIdentifier {
			[Export ("customIdentifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDecimalNumber IncludedTipAmount {
			[Export ("includedTipAmount", ArgumentSemantic.Copy)]
			get {
				NSDecimalNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("includedTipAmount")));
				} else {
					ret =  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("includedTipAmount")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.Copy)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("metadata")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionParametersType ParametersType {
			[Export ("parametersType", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (MPTransactionParametersType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("parametersType"));
				} else {
					return (MPTransactionParametersType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parametersType"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ReferencedCustomIdentifier {
			[Export ("referencedCustomIdentifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("referencedCustomIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("referencedCustomIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ReferencedTransactionIdentifier {
			[Export ("referencedTransactionIdentifier")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("referencedTransactionIdentifier")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("referencedTransactionIdentifier")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string StatementDescriptor {
			[Export ("statementDescriptor")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statementDescriptor")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("statementDescriptor")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Subject {
			[Export ("subject")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subject")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subject")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int TransactionType {
			[Export ("transactionType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("transactionType"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionType"));
				}
			}
			
		}
		
	} /* class MPTransactionParameters */
}
