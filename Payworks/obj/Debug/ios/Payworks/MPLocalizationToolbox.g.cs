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
	[Register("MPLocalizationToolbox", true)]
	public unsafe partial class MPLocalizationToolbox : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPLocalizationToolbox");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPLocalizationToolbox () : base (NSObjectFlag.Empty)
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
		protected MPLocalizationToolbox (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPLocalizationToolbox (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("informationForTransactionStatusDetailsCode:")]
		[CompilerGenerated]
		public virtual string InformationForTransactionStatusDetailsCode (MPTransactionStatusDetailsCode code)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("informationForTransactionStatusDetailsCode:"), (UInt32)code));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("informationForTransactionStatusDetailsCode:"), (UInt32)code));
			}
		}
		
		[Export ("textFormattedForAmount:currency:")]
		[CompilerGenerated]
		public virtual string TextFormattedForAmount (NSDecimalNumber amount, NSObject currency)
		{
			if (currency == null)
				throw new ArgumentNullException ("currency");
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("textFormattedForAmount:currency:"), amount == null ? IntPtr.Zero : amount.Handle, currency.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("textFormattedForAmount:currency:"), amount == null ? IntPtr.Zero : amount.Handle, currency.Handle));
			}
		}
		
		[Export ("textFormattedForDate:")]
		[CompilerGenerated]
		public virtual string TextFormattedForDate (NSDate date)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("textFormattedForDate:"), date == null ? IntPtr.Zero : date.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("textFormattedForDate:"), date == null ? IntPtr.Zero : date.Handle));
			}
		}
		
		[Export ("textFormattedForTime:")]
		[CompilerGenerated]
		public virtual string TextFormattedForTime (NSDate time)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("textFormattedForTime:"), time == null ? IntPtr.Zero : time.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("textFormattedForTime:"), time == null ? IntPtr.Zero : time.Handle));
			}
		}
		
		[Export ("textFormattedForTimeAndDate:")]
		[CompilerGenerated]
		public virtual string TextFormattedForTimeAndDate (NSDate datetime)
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("textFormattedForTimeAndDate:"), datetime == null ? IntPtr.Zero : datetime.Handle));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("textFormattedForTimeAndDate:"), datetime == null ? IntPtr.Zero : datetime.Handle));
			}
		}
		
	} /* class MPLocalizationToolbox */
}
