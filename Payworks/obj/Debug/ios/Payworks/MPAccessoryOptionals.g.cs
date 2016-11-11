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
	[Protocol (Name = "MPAccessoryOptionals", WrapperType = typeof (MPAccessoryOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IdleText", Selector = "idleText", PropertyType = typeof (NSObject[]), GetterSelector = "idleText", SetterSelector = "setIdleText:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Locale", Selector = "locale", PropertyType = typeof (int), GetterSelector = "locale", SetterSelector = "setLocale:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMPAccessoryOptionals : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		NSObject[] IdleText {
			[Export ("idleText", ArgumentSemantic.UnsafeUnretained)]
			get;
			[Export ("setIdleText:", ArgumentSemantic.UnsafeUnretained)]
			set;
		}
		
		[Preserve (Conditional = true)]
		int Locale {
			[Export ("locale")]
			get;
			[Export ("setLocale:")]
			set;
		}
		
	}
	
	internal sealed class MPAccessoryOptionalsWrapper : BaseWrapper, IMPAccessoryOptionals {
		public MPAccessoryOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPAccessoryOptionalsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[CompilerGenerated]
		public NSObject[] IdleText {
			[Export ("idleText", ArgumentSemantic.UnsafeUnretained)]
			get {
				return NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("idleText")));
			}
			
			[Export ("setIdleText:", ArgumentSemantic.UnsafeUnretained)]
			set {
				var nsa_value = value == null ? null : NSArray.FromNSObjects (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIdleText:"), nsa_value == null ? IntPtr.Zero : nsa_value.Handle);
				if (nsa_value != null)
					nsa_value.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public int Locale {
			[Export ("locale")]
			get {
				return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("locale"));
			}
			
			[Export ("setLocale:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setLocale:"), value);
			}
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPAccessoryOptionals", false)]
	[Model]
	public unsafe abstract partial class MPAccessoryOptionals : NSObject, IMPAccessoryOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPAccessoryOptionals () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public abstract NSObject[] IdleText {
			[Export ("idleText", ArgumentSemantic.UnsafeUnretained)]
			get; 
			[Export ("setIdleText:", ArgumentSemantic.UnsafeUnretained)]
			set; 
		}
		
		[CompilerGenerated]
		public abstract int Locale {
			[Export ("locale")]
			get; 
			[Export ("setLocale:")]
			set; 
		}
		
	} /* class MPAccessoryOptionals */
}
