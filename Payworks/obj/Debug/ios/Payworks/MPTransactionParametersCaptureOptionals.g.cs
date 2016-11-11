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
	[Protocol (Name = "MPTransactionParametersCaptureOptionals", WrapperType = typeof (MPTransactionParametersCaptureOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Currency", Selector = "setAmount:currency:", ParameterType = new Type [] { typeof (NSDecimalNumber), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	public interface IMPTransactionParametersCaptureOptionals : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setAmount:currency:")]
		[Preserve (Conditional = true)]
		void Currency (NSDecimalNumber amount, NSObject currency);
		
	}
	
	internal sealed class MPTransactionParametersCaptureOptionalsWrapper : BaseWrapper, IMPTransactionParametersCaptureOptionals {
		public MPTransactionParametersCaptureOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPTransactionParametersCaptureOptionalsWrapper (IntPtr handle, bool owns)
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
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPTransactionParametersCaptureOptionals", false)]
	[Model]
	public unsafe abstract partial class MPTransactionParametersCaptureOptionals : NSObject, IMPTransactionParametersCaptureOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPTransactionParametersCaptureOptionals () : base (NSObjectFlag.Empty)
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
		protected MPTransactionParametersCaptureOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionParametersCaptureOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setAmount:currency:")]
		[CompilerGenerated]
		public abstract void Currency (NSDecimalNumber amount, NSObject currency);
	} /* class MPTransactionParametersCaptureOptionals */
}
