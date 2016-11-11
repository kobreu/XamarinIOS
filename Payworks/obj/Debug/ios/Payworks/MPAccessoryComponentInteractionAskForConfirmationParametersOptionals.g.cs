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
	[Protocol (Name = "MPAccessoryComponentInteractionAskForConfirmationParametersOptionals", WrapperType = typeof (MPAccessoryComponentInteractionAskForConfirmationParametersOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCenterText", Selector = "setCenterText:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetShowIdleScreen", Selector = "setShowIdleScreen:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetConfirmationKeys", Selector = "setConfirmationKeys:", ParameterType = new Type [] { typeof (Payworks.MPAccessoryComponentInteractionConfirmationKey) }, ParameterByRef = new bool [] { false })]
	public interface IMPAccessoryComponentInteractionAskForConfirmationParametersOptionals : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("setCenterText:")]
		[Preserve (Conditional = true)]
		void SetCenterText (bool centered);
		
		[CompilerGenerated]
		[Export ("setShowIdleScreen:")]
		[Preserve (Conditional = true)]
		void SetShowIdleScreen (bool showIdleScreen);
		
		[CompilerGenerated]
		[Export ("setConfirmationKeys:")]
		[Preserve (Conditional = true)]
		void SetConfirmationKeys (MPAccessoryComponentInteractionConfirmationKey keys);
		
	}
	
	internal sealed class MPAccessoryComponentInteractionAskForConfirmationParametersOptionalsWrapper : BaseWrapper, IMPAccessoryComponentInteractionAskForConfirmationParametersOptionals {
		public MPAccessoryComponentInteractionAskForConfirmationParametersOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPAccessoryComponentInteractionAskForConfirmationParametersOptionalsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("setCenterText:")]
		[CompilerGenerated]
		public void SetCenterText (bool centered)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCenterText:"), centered);
		}
		
		[Export ("setShowIdleScreen:")]
		[CompilerGenerated]
		public void SetShowIdleScreen (bool showIdleScreen)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowIdleScreen:"), showIdleScreen);
		}
		
		[Export ("setConfirmationKeys:")]
		[CompilerGenerated]
		public void SetConfirmationKeys (MPAccessoryComponentInteractionConfirmationKey keys)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setConfirmationKeys:"), (UInt32)keys);
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPAccessoryComponentInteractionAskForConfirmationParametersOptionals", false)]
	[Model]
	public unsafe abstract partial class MPAccessoryComponentInteractionAskForConfirmationParametersOptionals : NSObject, IMPAccessoryComponentInteractionAskForConfirmationParametersOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPAccessoryComponentInteractionAskForConfirmationParametersOptionals () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentInteractionAskForConfirmationParametersOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentInteractionAskForConfirmationParametersOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setCenterText:")]
		[CompilerGenerated]
		public abstract void SetCenterText (bool centered);
		[Export ("setConfirmationKeys:")]
		[CompilerGenerated]
		public abstract void SetConfirmationKeys (MPAccessoryComponentInteractionConfirmationKey keys);
		[Export ("setShowIdleScreen:")]
		[CompilerGenerated]
		public abstract void SetShowIdleScreen (bool showIdleScreen);
	} /* class MPAccessoryComponentInteractionAskForConfirmationParametersOptionals */
}
