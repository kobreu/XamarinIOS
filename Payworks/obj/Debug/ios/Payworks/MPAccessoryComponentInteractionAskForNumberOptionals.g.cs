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
	[Protocol (Name = "MPAccessoryComponentInteractionAskForNumberOptionals", WrapperType = typeof (MPAccessoryComponentInteractionAskForNumberOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetFormatWithIntegerDigits", Selector = "setFormatWithIntegerDigits:fractionDigits:", ParameterType = new Type [] { typeof (uint), typeof (uint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetAutoConfirm", Selector = "setAutoConfirm:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDefaultNumber", Selector = "setDefaultNumber:", ParameterType = new Type [] { typeof (NSDecimalNumber) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDisplayAmount", Selector = "setDisplayAmount:currency:", ParameterType = new Type [] { typeof (NSDecimalNumber), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetShowIdleScreen", Selector = "setShowIdleScreen:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public interface IMPAccessoryComponentInteractionAskForNumberOptionals : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setFormatWithIntegerDigits:fractionDigits:")]
		[Preserve (Conditional = true)]
		void SetFormatWithIntegerDigits (global::System.UInt32 integerDigits, global::System.UInt32 fractionDigits);
		
		[CompilerGenerated]
		[Export ("setAutoConfirm:")]
		[Preserve (Conditional = true)]
		void SetAutoConfirm (bool autoConfirm);
		
		[CompilerGenerated]
		[Export ("setDefaultNumber:")]
		[Preserve (Conditional = true)]
		void SetDefaultNumber (NSDecimalNumber defaultNumber);
		
		[CompilerGenerated]
		[Export ("setDisplayAmount:currency:")]
		[Preserve (Conditional = true)]
		void SetDisplayAmount (NSDecimalNumber amount, NSObject currency);
		
		[CompilerGenerated]
		[Export ("setShowIdleScreen:")]
		[Preserve (Conditional = true)]
		void SetShowIdleScreen (bool showIdleScreen);
		
	}
	
	internal sealed class MPAccessoryComponentInteractionAskForNumberOptionalsWrapper : BaseWrapper, IMPAccessoryComponentInteractionAskForNumberOptionals {
		public MPAccessoryComponentInteractionAskForNumberOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPAccessoryComponentInteractionAskForNumberOptionalsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setFormatWithIntegerDigits:fractionDigits:")]
		[CompilerGenerated]
		public void SetFormatWithIntegerDigits (global::System.UInt32 integerDigits, global::System.UInt32 fractionDigits)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32 (this.Handle, Selector.GetHandle ("setFormatWithIntegerDigits:fractionDigits:"), integerDigits, fractionDigits);
		}
		
		[Export ("setAutoConfirm:")]
		[CompilerGenerated]
		public void SetAutoConfirm (bool autoConfirm)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoConfirm:"), autoConfirm);
		}
		
		[Export ("setDefaultNumber:")]
		[CompilerGenerated]
		public void SetDefaultNumber (NSDecimalNumber defaultNumber)
		{
			if (defaultNumber == null)
				throw new ArgumentNullException ("defaultNumber");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDefaultNumber:"), defaultNumber.Handle);
		}
		
		[Export ("setDisplayAmount:currency:")]
		[CompilerGenerated]
		public void SetDisplayAmount (NSDecimalNumber amount, NSObject currency)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (currency == null)
				throw new ArgumentNullException ("currency");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setDisplayAmount:currency:"), amount.Handle, currency.Handle);
		}
		
		[Export ("setShowIdleScreen:")]
		[CompilerGenerated]
		public void SetShowIdleScreen (bool showIdleScreen)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowIdleScreen:"), showIdleScreen);
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPAccessoryComponentInteractionAskForNumberOptionals", false)]
	[Model]
	public unsafe abstract partial class MPAccessoryComponentInteractionAskForNumberOptionals : NSObject, IMPAccessoryComponentInteractionAskForNumberOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPAccessoryComponentInteractionAskForNumberOptionals () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentInteractionAskForNumberOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentInteractionAskForNumberOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setAutoConfirm:")]
		[CompilerGenerated]
		public abstract void SetAutoConfirm (bool autoConfirm);
		[Export ("setDefaultNumber:")]
		[CompilerGenerated]
		public abstract void SetDefaultNumber (NSDecimalNumber defaultNumber);
		[Export ("setDisplayAmount:currency:")]
		[CompilerGenerated]
		public abstract void SetDisplayAmount (NSDecimalNumber amount, NSObject currency);
		[Export ("setFormatWithIntegerDigits:fractionDigits:")]
		[CompilerGenerated]
		public abstract void SetFormatWithIntegerDigits (global::System.UInt32 integerDigits, global::System.UInt32 fractionDigits);
		[Export ("setShowIdleScreen:")]
		[CompilerGenerated]
		public abstract void SetShowIdleScreen (bool showIdleScreen);
	} /* class MPAccessoryComponentInteractionAskForNumberOptionals */
}
