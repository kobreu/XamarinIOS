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
	[Protocol (Name = "MPAccessoryComponentDelegate", WrapperType = typeof (MPAccessoryComponentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeBatteryState", Selector = "accessory:didChangeBatteryState:level:", ParameterType = new Type [] { typeof (Payworks.MPAccessory), typeof (NSObject), typeof (int) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEmitCardEvent", Selector = "accessory:didEmitCardEvent:", ParameterType = new Type [] { typeof (Payworks.MPAccessory), typeof (Payworks.MPAccessoryCardEvent) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEmitKeyEvent", Selector = "accessory:didEmitKeyEvent:", ParameterType = new Type [] { typeof (Payworks.MPAccessory), typeof (Payworks.MPAccessoryKeyEvent) }, ParameterByRef = new bool [] { false, false })]
	public interface IMPAccessoryComponentDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MPAccessoryComponentDelegate_Extensions {
		[CompilerGenerated]
		public static void DidChangeBatteryState (this IMPAccessoryComponentDelegate This, MPAccessory accessory, NSObject state, int level)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (state == null)
				throw new ArgumentNullException ("state");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_int (This.Handle, Selector.GetHandle ("accessory:didChangeBatteryState:level:"), accessory.Handle, state.Handle, level);
		}
		
		[CompilerGenerated]
		public static void DidEmitCardEvent (this IMPAccessoryComponentDelegate This, MPAccessory accessory, MPAccessoryCardEvent @event)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("accessory:didEmitCardEvent:"), accessory.Handle, (UInt32)@event);
		}
		
		[CompilerGenerated]
		public static void DidEmitKeyEvent (this IMPAccessoryComponentDelegate This, MPAccessory accessory, MPAccessoryKeyEvent @event)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("accessory:didEmitKeyEvent:"), accessory.Handle, (UInt32)@event);
		}
		
	}
	
	internal sealed class MPAccessoryComponentDelegateWrapper : BaseWrapper, IMPAccessoryComponentDelegate {
		public MPAccessoryComponentDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPAccessoryComponentDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPAccessoryComponentDelegate", false)]
	[Model]
	public unsafe partial class MPAccessoryComponentDelegate : NSObject, IMPAccessoryComponentDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentDelegate () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("accessory:didChangeBatteryState:level:")]
		[CompilerGenerated]
		public virtual void DidChangeBatteryState (MPAccessory accessory, NSObject state, int level)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("accessory:didEmitCardEvent:")]
		[CompilerGenerated]
		public virtual void DidEmitCardEvent (MPAccessory accessory, MPAccessoryCardEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("accessory:didEmitKeyEvent:")]
		[CompilerGenerated]
		public virtual void DidEmitKeyEvent (MPAccessory accessory, MPAccessoryKeyEvent @event)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MPAccessoryComponentDelegate */
}
