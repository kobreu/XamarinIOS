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
	[Protocol (Name = "MPTransactionParametersOptionals", WrapperType = typeof (MPTransactionParametersOptionalsWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Subject", Selector = "subject", PropertyType = typeof (string), GetterSelector = "subject", SetterSelector = "setSubject:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CustomIdentifier", Selector = "customIdentifier", PropertyType = typeof (string), GetterSelector = "customIdentifier", SetterSelector = "setCustomIdentifier:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StatementDescriptor", Selector = "statementDescriptor", PropertyType = typeof (string), GetterSelector = "statementDescriptor", SetterSelector = "setStatementDescriptor:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ApplicationFee", Selector = "applicationFee", PropertyType = typeof (NSDecimalNumber), GetterSelector = "applicationFee", SetterSelector = "setApplicationFee:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IncludedTipAmount", Selector = "includedTipAmount", PropertyType = typeof (NSDecimalNumber), GetterSelector = "includedTipAmount", SetterSelector = "setIncludedTipAmount:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Metadata", Selector = "metadata", PropertyType = typeof (NSDictionary), GetterSelector = "metadata", SetterSelector = "setMetadata:", ArgumentSemantic = ArgumentSemantic.UnsafeUnretained)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AutoCapture", Selector = "autoCapture", PropertyType = typeof (bool), GetterSelector = "autoCapture", SetterSelector = "setAutoCapture:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IMPTransactionParametersOptionals : INativeObject, IDisposable
	{
		[Preserve (Conditional = true)]
		string Subject {
			[Export ("subject")]
			get;
			[Export ("setSubject:")]
			set;
		}
		
		[Preserve (Conditional = true)]
		string CustomIdentifier {
			[Export ("customIdentifier")]
			get;
			[Export ("setCustomIdentifier:")]
			set;
		}
		
		[Preserve (Conditional = true)]
		string StatementDescriptor {
			[Export ("statementDescriptor")]
			get;
			[Export ("setStatementDescriptor:")]
			set;
		}
		
		[Preserve (Conditional = true)]
		NSDecimalNumber ApplicationFee {
			[Export ("applicationFee", ArgumentSemantic.UnsafeUnretained)]
			get;
			[Export ("setApplicationFee:", ArgumentSemantic.UnsafeUnretained)]
			set;
		}
		
		[Preserve (Conditional = true)]
		NSDecimalNumber IncludedTipAmount {
			[Export ("includedTipAmount", ArgumentSemantic.UnsafeUnretained)]
			get;
			[Export ("setIncludedTipAmount:", ArgumentSemantic.UnsafeUnretained)]
			set;
		}
		
		[Preserve (Conditional = true)]
		NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.UnsafeUnretained)]
			get;
			[Export ("setMetadata:", ArgumentSemantic.UnsafeUnretained)]
			set;
		}
		
		[Preserve (Conditional = true)]
		bool AutoCapture {
			[Export ("autoCapture")]
			get;
			[Export ("setAutoCapture:")]
			set;
		}
		
	}
	
	internal sealed class MPTransactionParametersOptionalsWrapper : BaseWrapper, IMPTransactionParametersOptionals {
		public MPTransactionParametersOptionalsWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public MPTransactionParametersOptionalsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[CompilerGenerated]
		public string Subject {
			[Export ("subject")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subject")));
			}
			
			[Export ("setSubject:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubject:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public string CustomIdentifier {
			[Export ("customIdentifier")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customIdentifier")));
			}
			
			[Export ("setCustomIdentifier:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomIdentifier:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public string StatementDescriptor {
			[Export ("statementDescriptor")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("statementDescriptor")));
			}
			
			[Export ("setStatementDescriptor:")]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStatementDescriptor:"), nsvalue);
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public NSDecimalNumber ApplicationFee {
			[Export ("applicationFee", ArgumentSemantic.UnsafeUnretained)]
			get {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applicationFee")));
			}
			
			[Export ("setApplicationFee:", ArgumentSemantic.UnsafeUnretained)]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplicationFee:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
		[CompilerGenerated]
		public NSDecimalNumber IncludedTipAmount {
			[Export ("includedTipAmount", ArgumentSemantic.UnsafeUnretained)]
			get {
				return  Runtime.GetNSObject<NSDecimalNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("includedTipAmount")));
			}
			
			[Export ("setIncludedTipAmount:", ArgumentSemantic.UnsafeUnretained)]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setIncludedTipAmount:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
		[CompilerGenerated]
		public NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.UnsafeUnretained)]
			get {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("metadata")));
			}
			
			[Export ("setMetadata:", ArgumentSemantic.UnsafeUnretained)]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMetadata:"), value == null ? IntPtr.Zero : value.Handle);
			}
		}
		
		[CompilerGenerated]
		public bool AutoCapture {
			[Export ("autoCapture")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoCapture"));
			}
			
			[Export ("setAutoCapture:")]
			set {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoCapture:"), value);
			}
		}
		
	}
}
namespace Payworks {
	[Protocol]
	[Register("MPTransactionParametersOptionals", false)]
	[Model]
	public unsafe abstract partial class MPTransactionParametersOptionals : NSObject, IMPTransactionParametersOptionals {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPTransactionParametersOptionals () : base (NSObjectFlag.Empty)
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
		protected MPTransactionParametersOptionals (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MPTransactionParametersOptionals (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public abstract NSDecimalNumber ApplicationFee {
			[Export ("applicationFee", ArgumentSemantic.UnsafeUnretained)]
			get; 
			[Export ("setApplicationFee:", ArgumentSemantic.UnsafeUnretained)]
			set; 
		}
		
		[CompilerGenerated]
		public abstract bool AutoCapture {
			[Export ("autoCapture")]
			get; 
			[Export ("setAutoCapture:")]
			set; 
		}
		
		[CompilerGenerated]
		public abstract string CustomIdentifier {
			[Export ("customIdentifier")]
			get; 
			[Export ("setCustomIdentifier:")]
			set; 
		}
		
		[CompilerGenerated]
		public abstract NSDecimalNumber IncludedTipAmount {
			[Export ("includedTipAmount", ArgumentSemantic.UnsafeUnretained)]
			get; 
			[Export ("setIncludedTipAmount:", ArgumentSemantic.UnsafeUnretained)]
			set; 
		}
		
		[CompilerGenerated]
		public abstract NSDictionary Metadata {
			[Export ("metadata", ArgumentSemantic.UnsafeUnretained)]
			get; 
			[Export ("setMetadata:", ArgumentSemantic.UnsafeUnretained)]
			set; 
		}
		
		[CompilerGenerated]
		public abstract string StatementDescriptor {
			[Export ("statementDescriptor")]
			get; 
			[Export ("setStatementDescriptor:")]
			set; 
		}
		
		[CompilerGenerated]
		public abstract string Subject {
			[Export ("subject")]
			get; 
			[Export ("setSubject:")]
			set; 
		}
		
	} /* class MPTransactionParametersOptionals */
}
