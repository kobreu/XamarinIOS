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
	[Protocol (Name = "MPTransactionProcessParametersSteps", WrapperType = typeof (MPTransactionProcessParametersStepsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddAskForTipStepWithSuggestedAmount", Selector = "addAskForTipStepWithSuggestedAmount:", ParameterType = new Type [] { typeof (NSDecimalNumber) }, ParameterByRef = new bool [] { false })]
	public interface IMPTransactionProcessParametersSteps : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("addAskForTipStepWithSuggestedAmount:")]
		[Preserve (Conditional = true)]
		void AddAskForTipStepWithSuggestedAmount (NSDecimalNumber suggestedAmount);
		
	}
	
	internal sealed class MPTransactionProcessParametersStepsWrapper : BaseWrapper, IMPTransactionProcessParametersSteps {
		public MPTransactionProcessParametersStepsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPTransactionProcessParametersStepsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("addAskForTipStepWithSuggestedAmount:")]
		[CompilerGenerated]
		public void AddAskForTipStepWithSuggestedAmount (NSDecimalNumber suggestedAmount)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAskForTipStepWithSuggestedAmount:"), suggestedAmount == null ? IntPtr.Zero : suggestedAmount.Handle);
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPTransactionProcessParametersSteps", false)]
	[Model]
	public unsafe abstract partial class MPTransactionProcessParametersSteps : NSObject, IMPTransactionProcessParametersSteps {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPTransactionProcessParametersSteps () : base (NSObjectFlag.Empty)
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
		protected MPTransactionProcessParametersSteps (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionProcessParametersSteps (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAskForTipStepWithSuggestedAmount:")]
		[CompilerGenerated]
		public abstract void AddAskForTipStepWithSuggestedAmount (NSDecimalNumber suggestedAmount);
	} /* class MPTransactionProcessParametersSteps */
}
