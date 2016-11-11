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
	[Protocol (Name = "MPProviderComponentDelegate", WrapperType = typeof (MPProviderComponentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Accessory", Selector = "accessory:didChangeState:", ParameterType = new Type [] { typeof (Payworks.MPAccessory), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Transaction", Selector = "transaction:didChangeState:abortable:", ParameterType = new Type [] { typeof (Payworks.MPTransaction), typeof (NSObject), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IMPProviderComponentDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class MPProviderComponentDelegate_Extensions {
		[CompilerGenerated]
		public static void Accessory (this IMPProviderComponentDelegate This, MPAccessory accessory, NSObject state)
		{
			if (accessory == null)
				throw new ArgumentNullException ("accessory");
			if (state == null)
				throw new ArgumentNullException ("state");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("accessory:didChangeState:"), accessory.Handle, state.Handle);
		}
		
		[CompilerGenerated]
		public static void Transaction (this IMPProviderComponentDelegate This, MPTransaction transaction, NSObject state, bool abortable)
		{
			if (transaction == null)
				throw new ArgumentNullException ("transaction");
			if (state == null)
				throw new ArgumentNullException ("state");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_bool (This.Handle, Selector.GetHandle ("transaction:didChangeState:abortable:"), transaction.Handle, state.Handle, abortable);
		}
		
	}
	
	internal sealed class MPProviderComponentDelegateWrapper : BaseWrapper, IMPProviderComponentDelegate {
		public MPProviderComponentDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPProviderComponentDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPProviderComponentDelegate", false)]
	[Model]
	public unsafe partial class MPProviderComponentDelegate : NSObject, IMPProviderComponentDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPProviderComponentDelegate () : base (NSObjectFlag.Empty)
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
		protected MPProviderComponentDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPProviderComponentDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("accessory:didChangeState:")]
		[CompilerGenerated]
		public virtual void Accessory (MPAccessory accessory, NSObject state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("transaction:didChangeState:abortable:")]
		[CompilerGenerated]
		public virtual void Transaction (MPTransaction transaction, NSObject state, bool abortable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class MPProviderComponentDelegate */
}
