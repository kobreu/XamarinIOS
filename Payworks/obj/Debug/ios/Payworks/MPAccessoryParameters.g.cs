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
	[Register("MPAccessoryParameters", true)]
	public unsafe partial class MPAccessoryParameters : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryParameters");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryParameters () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryParameters (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("audioJackAccessoryParametersWithFamily:optionals:")]
		[CompilerGenerated]
		public unsafe static MPAccessoryParameters AudioJackAccessoryParametersWithFamily (NSObject family, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryOptionalsBlock))]MPAccessoryOptionalsBlock optionalsBlock)
		{
			if (family == null)
				throw new ArgumentNullException ("family");
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPAccessoryOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPAccessoryParameters ret;
			ret =  Runtime.GetNSObject<MPAccessoryParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("audioJackAccessoryParametersWithFamily:optionals:"), family.Handle, (IntPtr) block_ptr_optionalsBlock));
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("externalAccessoryParametersWithFamily:protocol:optionals:")]
		[CompilerGenerated]
		public unsafe static MPAccessoryParameters ExternalAccessoryParametersWithFamily (NSObject family, string protocol, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPExternalAccessoryOptionalsBlock))]MPExternalAccessoryOptionalsBlock optionalsBlock)
		{
			if (family == null)
				throw new ArgumentNullException ("family");
			if (protocol == null)
				throw new ArgumentNullException ("protocol");
			var nsprotocol = NSString.CreateNative (protocol);
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPExternalAccessoryOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPAccessoryParameters ret;
			ret =  Runtime.GetNSObject<MPAccessoryParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("externalAccessoryParametersWithFamily:protocol:optionals:"), family.Handle, nsprotocol, (IntPtr) block_ptr_optionalsBlock));
			NSString.ReleaseNative (nsprotocol);
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("mockAccessoryParameters")]
		[CompilerGenerated]
		public static MPAccessoryParameters MockAccessoryParameters ()
		{
			return  Runtime.GetNSObject<MPAccessoryParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("mockAccessoryParameters")));
		}
		
		[Export ("tcpAccessoryParametersWithFamily:remote:port:optionals:")]
		[CompilerGenerated]
		public unsafe static MPAccessoryParameters TcpAccessoryParametersWithFamily (NSObject family, string remote, global::System.UInt32 port, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPAccessoryOptionalsBlock))]MPAccessoryOptionalsBlock optionalsBlock)
		{
			if (family == null)
				throw new ArgumentNullException ("family");
			if (remote == null)
				throw new ArgumentNullException ("remote");
			var nsremote = NSString.CreateNative (remote);
			BlockLiteral *block_ptr_optionalsBlock;
			BlockLiteral block_optionalsBlock;
			if (optionalsBlock == null){
				block_ptr_optionalsBlock = null;
			} else {
				block_optionalsBlock = new BlockLiteral ();
				block_ptr_optionalsBlock = &block_optionalsBlock;
				block_optionalsBlock.SetupBlock (Trampolines.SDMPAccessoryOptionalsBlock.Handler, optionalsBlock);
			}
			
			MPAccessoryParameters ret;
			ret =  Runtime.GetNSObject<MPAccessoryParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (class_ptr, Selector.GetHandle ("tcpAccessoryParametersWithFamily:remote:port:optionals:"), family.Handle, nsremote, port, (IntPtr) block_ptr_optionalsBlock));
			NSString.ReleaseNative (nsremote);
			if (block_ptr_optionalsBlock != null)
				block_ptr_optionalsBlock->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual int AccessoryFamily {
			[Export ("accessoryFamily")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("accessoryFamily"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessoryFamily"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ConnectionType {
			[Export ("connectionType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("connectionType"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("connectionType"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSDictionary Filters {
			[Export ("filters", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("filters")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("filters")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSObject[] IdleText {
			[Export ("idleText", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("idleText")));
				} else {
					ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("idleText")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Locale {
			[Export ("locale")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("locale"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("locale"));
				}
			}
			
		}
		
	} /* class MPAccessoryParameters */
}
