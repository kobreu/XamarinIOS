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
	[Register("MPAccessoryComponentInteractionAskForNumberParameters", true)]
	public unsafe partial class MPAccessoryComponentInteractionAskForNumberParameters : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentInteractionAskForNumberParameters");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentInteractionAskForNumberParameters () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentInteractionAskForNumberParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentInteractionAskForNumberParameters (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("parametersWithPrompt:optionals:")]
		[CompilerGenerated]
		public static MPAccessoryComponentInteractionAskForNumberParameters ParametersWithPrompt (MPAccessoryComponentInteractionPrompt prompt, MPAccessoryComponentInteractionAskForNumberOptionals optionalsBlock)
		{
			return  Runtime.GetNSObject<MPAccessoryComponentInteractionAskForNumberParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32_IntPtr (class_ptr, Selector.GetHandle ("parametersWithPrompt:optionals:"), (UInt32)prompt, optionalsBlock == null ? IntPtr.Zero : optionalsBlock.Handle));
		}
		
		[Export ("parametersWithPromptIndexes:optionals:")]
		[CompilerGenerated]
		public static MPAccessoryComponentInteractionAskForNumberParameters ParametersWithPromptIndexes (NSObject[] promptIndexes, MPAccessoryComponentInteractionAskForNumberOptionals optionalsBlock)
		{
			if (promptIndexes == null)
				throw new ArgumentNullException ("promptIndexes");
			var nsa_promptIndexes = NSArray.FromNSObjects (promptIndexes);
			
			MPAccessoryComponentInteractionAskForNumberParameters ret;
			ret =  Runtime.GetNSObject<MPAccessoryComponentInteractionAskForNumberParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("parametersWithPromptIndexes:optionals:"), nsa_promptIndexes.Handle, optionalsBlock == null ? IntPtr.Zero : optionalsBlock.Handle));
			nsa_promptIndexes.Dispose ();
			
			return ret;
		}
		
	} /* class MPAccessoryComponentInteractionAskForNumberParameters */
}
