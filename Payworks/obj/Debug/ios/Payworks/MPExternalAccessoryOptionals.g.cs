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
	[Protocol (Name = "MPExternalAccessoryOptionals", WrapperType = typeof (MPExternalAccessoryOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NamePrefix", Selector = "namePrefix", PropertyType = typeof (string), GetterSelector = "namePrefix", SetterSelector = "setNamePrefix:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMPExternalAccessoryOptionals : INativeObject, IDisposable, 
		Payworks.IMPAccessoryOptionals
		
	{
		[Preserve (Conditional = true)]
		string NamePrefix {
			[Export ("namePrefix")]
			get;
			[Export ("setNamePrefix:")]
			set;
		}
		
	}
	
	internal sealed class MPExternalAccessoryOptionalsWrapper : BaseWrapper, IMPExternalAccessoryOptionals {
		public MPExternalAccessoryOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPExternalAccessoryOptionalsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[CompilerGenerated]
		public string NamePrefix {
			[Export ("namePrefix")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("namePrefix")));
			}
			
			[Export ("setNamePrefix:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setNamePrefix:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
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
	[Register("MPExternalAccessoryOptionals", false)]
	[Model]
	public unsafe abstract partial class MPExternalAccessoryOptionals : NSObject, IMPExternalAccessoryOptionals, IMPAccessoryOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPExternalAccessoryOptionals () : base (NSObjectFlag.Empty)
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
		protected MPExternalAccessoryOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPExternalAccessoryOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual NSObject[] IdleText {
			[Export ("idleText", ArgumentSemantic.UnsafeUnretained)]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setIdleText:", ArgumentSemantic.UnsafeUnretained)]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public virtual int Locale {
			[Export ("locale")]
			get {
				throw new ModelNotImplementedException ();
			}
			
			[Export ("setLocale:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
		[CompilerGenerated]
		public abstract string NamePrefix {
			[Export ("namePrefix")]
			get; 
			[Export ("setNamePrefix:")]
			set; 
		}
		
	} /* class MPExternalAccessoryOptionals */
}
