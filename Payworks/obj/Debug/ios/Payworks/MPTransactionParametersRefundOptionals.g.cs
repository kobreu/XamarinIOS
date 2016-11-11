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
	[Protocol (Name = "MPTransactionParametersRefundOptionals", WrapperType = typeof (MPTransactionParametersRefundOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Currency", Selector = "setAmount:currency:", ParameterType = new Type [] { typeof (NSDecimalNumber), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Subject", Selector = "subject", PropertyType = typeof (string), GetterSelector = "subject", SetterSelector = "setSubject:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CustomIdentifier", Selector = "customIdentifier", PropertyType = typeof (string), GetterSelector = "customIdentifier", SetterSelector = "setCustomIdentifier:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMPTransactionParametersRefundOptionals : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setAmount:currency:")]
		[Preserve (Conditional = true)]
		void Currency (NSDecimalNumber amount, NSObject currency);
		
		[Preserve (Conditional = true)]
		string Subject {
			[Export ("subject")]
			get;
			[Export ("setSubject:")]
			set;
		}
		
		[Preserve (Conditional = true)]
		string CustomIdentifier {
			[Export ("customIdentifier")]
			get;
			[Export ("setCustomIdentifier:")]
			set;
		}
		
	}
	
	internal sealed class MPTransactionParametersRefundOptionalsWrapper : BaseWrapper, IMPTransactionParametersRefundOptionals {
		public MPTransactionParametersRefundOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPTransactionParametersRefundOptionalsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setAmount:currency:")]
		[CompilerGenerated]
		public void Currency (NSDecimalNumber amount, NSObject currency)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setAmount:currency:"), amount.Handle, currency.Handle);
		}
		
		[CompilerGenerated]
		public string Subject {
			[Export ("subject")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subject")));
			}
			
			[Export ("setSubject:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubject:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public string CustomIdentifier {
			[Export ("customIdentifier")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customIdentifier")));
			}
			
			[Export ("setCustomIdentifier:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomIdentifier:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPTransactionParametersRefundOptionals", false)]
	[Model]
	public unsafe abstract partial class MPTransactionParametersRefundOptionals : NSObject, IMPTransactionParametersRefundOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPTransactionParametersRefundOptionals () : base (NSObjectFlag.Empty)
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
		protected MPTransactionParametersRefundOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionParametersRefundOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setAmount:currency:")]
		[CompilerGenerated]
		public abstract void Currency (NSDecimalNumber amount, NSObject currency);
		[CompilerGenerated]
		public abstract string CustomIdentifier {
			[Export ("customIdentifier")]
			get; 
			[Export ("setCustomIdentifier:")]
			set; 
		}
		
		[CompilerGenerated]
		public abstract string Subject {
			[Export ("subject")]
			get; 
			[Export ("setSubject:")]
			set; 
		}
		
	} /* class MPTransactionParametersRefundOptionals */
}
