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
	[Register("MPPrintingProcess", true)]
	public unsafe partial class MPPrintingProcess : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPPrintingProcess");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPPrintingProcess () : base (NSObjectFlag.Empty)
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
		protected MPPrintingProcess (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPPrintingProcess (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual MPAccessory Accessory {
			[Export ("accessory", ArgumentSemantic.Retain)]
			get {
				MPAccessory ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPAccessory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessory")));
				} else {
					ret =  Runtime.GetNSObject<MPAccessory> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessory")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool CanBeAborted {
			[Export ("canBeAborted")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canBeAborted"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canBeAborted"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPPrintingProcessDetails Details {
			[Export ("details", ArgumentSemantic.Retain)]
			get {
				MPPrintingProcessDetails ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPPrintingProcessDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("details")));
				} else {
					ret =  Runtime.GetNSObject<MPPrintingProcessDetails> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("details")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionProvider Provider {
			[Export ("provider", ArgumentSemantic.Retain)]
			get {
				MPTransactionProvider ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("provider")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionProvider> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("provider")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RequestAbort {
			[Export ("requestAbort")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("requestAbort"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestAbort"));
				}
			}
			
		}
		
	} /* class MPPrintingProcess */
}