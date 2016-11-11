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
	[Register("MPTransactionProvider", true)]
	public unsafe partial class MPTransactionProvider : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MPTransactionProvider");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPTransactionProvider () : base (NSObjectFlag.Empty)
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
		protected MPTransactionProvider (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionProvider (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("amendTransactionWithParameters:statusChanged:completed:")]
		[CompilerGenerated]
		public unsafe virtual MPTransactionProcess AmendTransactionWithParameters (MPTransactionParameters transactionParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessStatusChanged))]MPTransactionProcessStatusChanged statusChanged, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessCompleted))]MPTransactionProcessCompleted completed)
		{
			if (transactionParameters == null)
				throw new ArgumentNullException ("transactionParameters");
			if (statusChanged == null)
				throw new ArgumentNullException ("statusChanged");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			BlockLiteral *block_ptr_statusChanged;
			BlockLiteral block_statusChanged;
			block_statusChanged = new BlockLiteral ();
			block_ptr_statusChanged = &block_statusChanged;
			block_statusChanged.SetupBlock (Trampolines.SDMPTransactionProcessStatusChanged.Handler, statusChanged);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionProcessCompleted.Handler, completed);
			
			MPTransactionProcess ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("amendTransactionWithParameters:statusChanged:completed:"), transactionParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_completed));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("amendTransactionWithParameters:statusChanged:completed:"), transactionParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_completed));
			}
			block_ptr_statusChanged->CleanupBlock ();
			block_ptr_completed->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("printCustomerReceiptForTransactionIdentifier:accessoryParameters:statusChanged:completed:")]
		[CompilerGenerated]
		public unsafe virtual MPPrintingProcess PrintCustomerReceiptForTransactionIdentifier (string transactionIdentifier, MPAccessoryParameters accessoryParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPPrintingProcessStatusChanged))]MPPrintingProcessStatusChanged statusChanged, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPPrintingProcessCompleted))]MPPrintingProcessCompleted completed)
		{
			if (transactionIdentifier == null)
				throw new ArgumentNullException ("transactionIdentifier");
			if (accessoryParameters == null)
				throw new ArgumentNullException ("accessoryParameters");
			if (statusChanged == null)
				throw new ArgumentNullException ("statusChanged");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			var nstransactionIdentifier = NSString.CreateNative (transactionIdentifier);
			BlockLiteral *block_ptr_statusChanged;
			BlockLiteral block_statusChanged;
			block_statusChanged = new BlockLiteral ();
			block_ptr_statusChanged = &block_statusChanged;
			block_statusChanged.SetupBlock (Trampolines.SDMPPrintingProcessStatusChanged.Handler, statusChanged);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPPrintingProcessCompleted.Handler, completed);
			
			MPPrintingProcess ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPPrintingProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("printCustomerReceiptForTransactionIdentifier:accessoryParameters:statusChanged:completed:"), nstransactionIdentifier, accessoryParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_completed));
			} else {
				ret =  Runtime.GetNSObject<MPPrintingProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("printCustomerReceiptForTransactionIdentifier:accessoryParameters:statusChanged:completed:"), nstransactionIdentifier, accessoryParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_completed));
			}
			NSString.ReleaseNative (nstransactionIdentifier);
			block_ptr_statusChanged->CleanupBlock ();
			block_ptr_completed->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startTransactionWithParameters:accessoryParameters:registered:statusChanged:actionRequired:completed:")]
		[CompilerGenerated]
		public unsafe virtual MPTransactionProcess StartTransactionWithParameters (MPTransactionParameters transactionParameters, MPAccessoryParameters accessoryParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessRegistered))]MPTransactionProcessRegistered registered, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessStatusChanged))]MPTransactionProcessStatusChanged statusChanged, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessActionRequired))]MPTransactionProcessActionRequired actionRequired, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessCompleted))]MPTransactionProcessCompleted completed)
		{
			if (transactionParameters == null)
				throw new ArgumentNullException ("transactionParameters");
			if (accessoryParameters == null)
				throw new ArgumentNullException ("accessoryParameters");
			if (registered == null)
				throw new ArgumentNullException ("registered");
			if (statusChanged == null)
				throw new ArgumentNullException ("statusChanged");
			if (actionRequired == null)
				throw new ArgumentNullException ("actionRequired");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			BlockLiteral *block_ptr_registered;
			BlockLiteral block_registered;
			block_registered = new BlockLiteral ();
			block_ptr_registered = &block_registered;
			block_registered.SetupBlock (Trampolines.SDMPTransactionProcessRegistered.Handler, registered);
			BlockLiteral *block_ptr_statusChanged;
			BlockLiteral block_statusChanged;
			block_statusChanged = new BlockLiteral ();
			block_ptr_statusChanged = &block_statusChanged;
			block_statusChanged.SetupBlock (Trampolines.SDMPTransactionProcessStatusChanged.Handler, statusChanged);
			BlockLiteral *block_ptr_actionRequired;
			BlockLiteral block_actionRequired;
			block_actionRequired = new BlockLiteral ();
			block_ptr_actionRequired = &block_actionRequired;
			block_actionRequired.SetupBlock (Trampolines.SDMPTransactionProcessActionRequired.Handler, actionRequired);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionProcessCompleted.Handler, completed);
			
			MPTransactionProcess ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startTransactionWithParameters:accessoryParameters:registered:statusChanged:actionRequired:completed:"), transactionParameters.Handle, accessoryParameters.Handle, (IntPtr) block_ptr_registered, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startTransactionWithParameters:accessoryParameters:registered:statusChanged:actionRequired:completed:"), transactionParameters.Handle, accessoryParameters.Handle, (IntPtr) block_ptr_registered, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			}
			block_ptr_registered->CleanupBlock ();
			block_ptr_statusChanged->CleanupBlock ();
			block_ptr_actionRequired->CleanupBlock ();
			block_ptr_completed->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startTransactionWithParameters:accessoryParameters:processParameters:registered:statusChanged:actionRequired:completed:")]
		[CompilerGenerated]
		public unsafe virtual MPTransactionProcess StartTransactionWithParameters (MPTransactionParameters transactionParameters, MPAccessoryParameters accessoryParameters, MPTransactionProcessParameters processParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessRegistered))]MPTransactionProcessRegistered registered, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessStatusChanged))]MPTransactionProcessStatusChanged statusChanged, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessActionRequired))]MPTransactionProcessActionRequired actionRequired, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessCompleted))]MPTransactionProcessCompleted completed)
		{
			if (transactionParameters == null)
				throw new ArgumentNullException ("transactionParameters");
			if (accessoryParameters == null)
				throw new ArgumentNullException ("accessoryParameters");
			if (registered == null)
				throw new ArgumentNullException ("registered");
			if (statusChanged == null)
				throw new ArgumentNullException ("statusChanged");
			if (actionRequired == null)
				throw new ArgumentNullException ("actionRequired");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			BlockLiteral *block_ptr_registered;
			BlockLiteral block_registered;
			block_registered = new BlockLiteral ();
			block_ptr_registered = &block_registered;
			block_registered.SetupBlock (Trampolines.SDMPTransactionProcessRegistered.Handler, registered);
			BlockLiteral *block_ptr_statusChanged;
			BlockLiteral block_statusChanged;
			block_statusChanged = new BlockLiteral ();
			block_ptr_statusChanged = &block_statusChanged;
			block_statusChanged.SetupBlock (Trampolines.SDMPTransactionProcessStatusChanged.Handler, statusChanged);
			BlockLiteral *block_ptr_actionRequired;
			BlockLiteral block_actionRequired;
			block_actionRequired = new BlockLiteral ();
			block_ptr_actionRequired = &block_actionRequired;
			block_actionRequired.SetupBlock (Trampolines.SDMPTransactionProcessActionRequired.Handler, actionRequired);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionProcessCompleted.Handler, completed);
			
			MPTransactionProcess ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startTransactionWithParameters:accessoryParameters:processParameters:registered:statusChanged:actionRequired:completed:"), transactionParameters.Handle, accessoryParameters.Handle, processParameters == null ? IntPtr.Zero : processParameters.Handle, (IntPtr) block_ptr_registered, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startTransactionWithParameters:accessoryParameters:processParameters:registered:statusChanged:actionRequired:completed:"), transactionParameters.Handle, accessoryParameters.Handle, processParameters == null ? IntPtr.Zero : processParameters.Handle, (IntPtr) block_ptr_registered, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			}
			block_ptr_registered->CleanupBlock ();
			block_ptr_statusChanged->CleanupBlock ();
			block_ptr_actionRequired->CleanupBlock ();
			block_ptr_completed->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startTransactionWithSessionIdentifier:accessoryParameters:statusChanged:actionRequired:completed:")]
		[CompilerGenerated]
		public unsafe virtual MPTransactionProcess StartTransactionWithSessionIdentifier (string sessionIdentifier, MPAccessoryParameters accessoryParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessStatusChanged))]MPTransactionProcessStatusChanged statusChanged, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessActionRequired))]MPTransactionProcessActionRequired actionRequired, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessCompleted))]MPTransactionProcessCompleted completed)
		{
			if (sessionIdentifier == null)
				throw new ArgumentNullException ("sessionIdentifier");
			if (accessoryParameters == null)
				throw new ArgumentNullException ("accessoryParameters");
			if (statusChanged == null)
				throw new ArgumentNullException ("statusChanged");
			if (actionRequired == null)
				throw new ArgumentNullException ("actionRequired");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			var nssessionIdentifier = NSString.CreateNative (sessionIdentifier);
			BlockLiteral *block_ptr_statusChanged;
			BlockLiteral block_statusChanged;
			block_statusChanged = new BlockLiteral ();
			block_ptr_statusChanged = &block_statusChanged;
			block_statusChanged.SetupBlock (Trampolines.SDMPTransactionProcessStatusChanged.Handler, statusChanged);
			BlockLiteral *block_ptr_actionRequired;
			BlockLiteral block_actionRequired;
			block_actionRequired = new BlockLiteral ();
			block_ptr_actionRequired = &block_actionRequired;
			block_actionRequired.SetupBlock (Trampolines.SDMPTransactionProcessActionRequired.Handler, actionRequired);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionProcessCompleted.Handler, completed);
			
			MPTransactionProcess ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startTransactionWithSessionIdentifier:accessoryParameters:statusChanged:actionRequired:completed:"), nssessionIdentifier, accessoryParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startTransactionWithSessionIdentifier:accessoryParameters:statusChanged:actionRequired:completed:"), nssessionIdentifier, accessoryParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			}
			NSString.ReleaseNative (nssessionIdentifier);
			block_ptr_statusChanged->CleanupBlock ();
			block_ptr_actionRequired->CleanupBlock ();
			block_ptr_completed->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("startTransactionWithSessionIdentifier:accessoryParameters:processParameters:statusChanged:actionRequired:completed:")]
		[CompilerGenerated]
		public unsafe virtual MPTransactionProcess StartTransactionWithSessionIdentifier (string sessionIdentifier, MPAccessoryParameters accessoryParameters, MPTransactionProcessParameters processParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessStatusChanged))]MPTransactionProcessStatusChanged statusChanged, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessActionRequired))]MPTransactionProcessActionRequired actionRequired, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPTransactionProcessCompleted))]MPTransactionProcessCompleted completed)
		{
			if (sessionIdentifier == null)
				throw new ArgumentNullException ("sessionIdentifier");
			if (accessoryParameters == null)
				throw new ArgumentNullException ("accessoryParameters");
			if (processParameters == null)
				throw new ArgumentNullException ("processParameters");
			if (statusChanged == null)
				throw new ArgumentNullException ("statusChanged");
			if (actionRequired == null)
				throw new ArgumentNullException ("actionRequired");
			if (completed == null)
				throw new ArgumentNullException ("completed");
			var nssessionIdentifier = NSString.CreateNative (sessionIdentifier);
			BlockLiteral *block_ptr_statusChanged;
			BlockLiteral block_statusChanged;
			block_statusChanged = new BlockLiteral ();
			block_ptr_statusChanged = &block_statusChanged;
			block_statusChanged.SetupBlock (Trampolines.SDMPTransactionProcessStatusChanged.Handler, statusChanged);
			BlockLiteral *block_ptr_actionRequired;
			BlockLiteral block_actionRequired;
			block_actionRequired = new BlockLiteral ();
			block_ptr_actionRequired = &block_actionRequired;
			block_actionRequired.SetupBlock (Trampolines.SDMPTransactionProcessActionRequired.Handler, actionRequired);
			BlockLiteral *block_ptr_completed;
			BlockLiteral block_completed;
			block_completed = new BlockLiteral ();
			block_ptr_completed = &block_completed;
			block_completed.SetupBlock (Trampolines.SDMPTransactionProcessCompleted.Handler, completed);
			
			MPTransactionProcess ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startTransactionWithSessionIdentifier:accessoryParameters:processParameters:statusChanged:actionRequired:completed:"), nssessionIdentifier, accessoryParameters.Handle, processParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			} else {
				ret =  Runtime.GetNSObject<MPTransactionProcess> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startTransactionWithSessionIdentifier:accessoryParameters:processParameters:statusChanged:actionRequired:completed:"), nssessionIdentifier, accessoryParameters.Handle, processParameters.Handle, (IntPtr) block_ptr_statusChanged, (IntPtr) block_ptr_actionRequired, (IntPtr) block_ptr_completed));
			}
			NSString.ReleaseNative (nssessionIdentifier);
			block_ptr_statusChanged->CleanupBlock ();
			block_ptr_actionRequired->CleanupBlock ();
			block_ptr_completed->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual MPLocalizationToolbox LocalizationToolbox {
			[Export ("localizationToolbox", ArgumentSemantic.Retain)]
			get {
				MPLocalizationToolbox ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPLocalizationToolbox> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("localizationToolbox")));
				} else {
					ret =  Runtime.GetNSObject<MPLocalizationToolbox> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("localizationToolbox")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual MPTransactionModule TransactionModule {
			[Export ("transactionModule", ArgumentSemantic.Retain)]
			get {
				MPTransactionModule ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MPTransactionModule> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transactionModule")));
				} else {
					ret =  Runtime.GetNSObject<MPTransactionModule> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transactionModule")));
				}
				return ret;
			}
			
		}
		
	} /* class MPTransactionProvider */
}
