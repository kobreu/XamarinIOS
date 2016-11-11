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
	[Register("MPAccessoryComponentInteractionAskForConfirmationParameters", true)]
	public unsafe partial class MPAccessoryComponentInteractionAskForConfirmationParameters : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPAccessoryComponentInteractionAskForConfirmationParameters");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPAccessoryComponentInteractionAskForConfirmationParameters () : base (NSObjectFlag.Empty)
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
		protected MPAccessoryComponentInteractionAskForConfirmationParameters (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPAccessoryComponentInteractionAskForConfirmationParameters (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("parametersWithText:optionals:")]
		[CompilerGenerated]
		public static MPAccessoryComponentInteractionAskForConfirmationParameters ParametersWithText (NSObject[] text, MPAccessoryComponentInteractionAskForConfirmationParametersOptionals optionalsBlock)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nsa_text = NSArray.FromNSObjects (text);
			
			MPAccessoryComponentInteractionAskForConfirmationParameters ret;
			ret =  Runtime.GetNSObject<MPAccessoryComponentInteractionAskForConfirmationParameters> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("parametersWithText:optionals:"), nsa_text.Handle, optionalsBlock == null ? IntPtr.Zero : optionalsBlock.Handle));
			nsa_text.Dispose ();
			
			return ret;
		}
		
	} /* class MPAccessoryComponentInteractionAskForConfirmationParameters */
}
