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
	[Register("MPTransactionProcessParameters", true)]
	public unsafe partial class MPTransactionProcessParameters : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionProcessParameters");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionProcessParameters () : base (NSObjectFlag.Empty)
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
		protected MPTransactionProcessParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionProcessParameters (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("parametersWithSteps:")]
		[CompilerGenerated]
		public unsafe static MPTransactionProcessParameters ParametersWithSteps ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessParametersStepsBlock))]MPTransactionProcessParametersStepsBlock stepsBlock)
		{
			if (stepsBlock == null)
				throw new ArgumentNullException ("stepsBlock");
			BlockLiteral *block_ptr_stepsBlock;
			BlockLiteral block_stepsBlock;
			block_stepsBlock = new BlockLiteral ();
			block_ptr_stepsBlock = &block_stepsBlock;
			block_stepsBlock.SetupBlock (Trampolines.SDMPTransactionProcessParametersStepsBlock.Handler, stepsBlock);
			
			MPTransactionProcessParameters ret;
			ret =  Runtime.GetNSObject<MPTransactionProcessParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("parametersWithSteps:"), (IntPtr) block_ptr_stepsBlock));
			block_ptr_stepsBlock->CleanupBlock ();
			
			return ret;
		}
		
	} /* class MPTransactionProcessParameters */
}
