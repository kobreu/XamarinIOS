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
	public delegate void MPAccessoryCheckUpdateFailure (Payworks.MPAccessory arg0, NSError arg1);
	public delegate void MPAccessoryCheckUpdateSuccess (Payworks.MPAccessory arg0, Payworks.MPAccessoryUpdateRequirement arg1);
	public delegate void MPAccessoryComponentBarcodeScannerStartScanAbort (Payworks.MPAccessoryComponentBarcodeScanner arg0);
	public delegate void MPAccessoryComponentBarcodeScannerStartScanButton (Payworks.MPAccessoryComponentBarcodeScanner arg0, uint arg1);
	public delegate void MPAccessoryComponentBarcodeScannerStartScanFailure (Payworks.MPAccessoryComponentBarcodeScanner arg0, NSError arg1);
	public delegate void MPAccessoryComponentBarcodeScannerStartScanScan (Payworks.MPAccessoryComponentBarcodeScanner arg0, Payworks.MPAccessoryComponentBarcodeScannerData arg1);
	public delegate void MPAccessoryComponentBarcodeScannerStartScanSuccess (Payworks.MPAccessoryComponentBarcodeScanner arg0);
	public delegate void MPAccessoryComponentBarcodeScannerStopScanFailure (Payworks.MPAccessoryComponentBarcodeScanner arg0, NSError arg1);
	public delegate void MPAccessoryComponentBarcodeScannerStopScanSuccess (Payworks.MPAccessoryComponentBarcodeScanner arg0);
	public delegate void MPAccessoryComponentInteractionAskForNumberAbort (Payworks.MPAccessoryComponentInteraction arg0);
	public delegate void MPAccessoryComponentInteractionAskForNumberFailure (Payworks.MPAccessoryComponentInteraction arg0, NSError arg1);
	public delegate void MPAccessoryComponentInteractionAskForNumberSuccess (Payworks.MPAccessoryComponentInteraction arg0, string arg1);
	public delegate void MPAccessoryComponentInteractionConfirmationAbort (Payworks.MPAccessoryComponentInteraction arg0);
	public delegate void MPAccessoryComponentInteractionConfirmationFailure (Payworks.MPAccessoryComponentInteraction arg0, NSError arg1);
	public delegate void MPAccessoryComponentInteractionConfirmationSuccess (Payworks.MPAccessoryComponentInteraction arg0, Payworks.MPAccessoryComponentInteractionConfirmationKey arg1);
	public delegate void MPAccessoryComponentInteractionDisplayIdleScreenFailure (Payworks.MPAccessoryComponentInteraction arg0, NSError arg1);
	public delegate void MPAccessoryComponentInteractionDisplayIdleScreenSuccess (Payworks.MPAccessoryComponentInteraction arg0);
	public delegate void MPAccessoryComponentInteractionDisplayTextFailure (Payworks.MPAccessoryComponentInteraction arg0, NSError arg1);
	public delegate void MPAccessoryComponentInteractionDisplayTextSuccess (Payworks.MPAccessoryComponentInteraction arg0);
	public delegate void MPAccessoryComponentLogDeleteLogFailure (Payworks.MPAccessoryComponentLog arg0, NSError arg1);
	public delegate void MPAccessoryComponentLogDeleteLogSuccess (Payworks.MPAccessoryComponentLog arg0);
	public delegate void MPAccessoryComponentLogDownloadLogFailure (Payworks.MPAccessoryComponentLog arg0, NSError arg1);
	public delegate void MPAccessoryComponentLogDownloadLogSuccess (Payworks.MPAccessoryComponentLog arg0, NSData arg1);
	public delegate void MPAccessoryComponentPrinterPrintFailure (Payworks.MPAccessoryComponentPrinter arg0, Payworks.MPReceipt arg1, NSError arg2);
	public delegate void MPAccessoryComponentPrinterPrintSuccess (Payworks.MPAccessoryComponentPrinter arg0, Payworks.MPReceipt arg1);
	public delegate void MPAccessoryComponentTippingAskForTipAbort (Payworks.MPAccessoryComponentTipping arg0);
	public delegate void MPAccessoryComponentTippingAskForTipFailure (Payworks.MPAccessoryComponentTipping arg0, NSError arg1);
	public delegate void MPAccessoryComponentTippingAskForTipSuccess (Payworks.MPAccessoryComponentTipping arg0, NSDecimalNumber arg1);
	public delegate void MPAccessoryComponentTippingFailure (NSError arg0);
	public delegate void MPAccessoryComponentTippingSuccess (bool arg0, NSDecimalNumber arg1);
	public delegate void MPAccessoryConnectFailure (NSError arg0);
	public delegate void MPAccessoryConnectSuccess (Payworks.MPAccessory arg0);
	public delegate void MPAccessoryDisconnectFailure (Payworks.MPAccessory arg0, NSError arg1);
	public delegate void MPAccessoryDisconnectSuccess (Payworks.MPAccessory arg0);
	public delegate void MPAccessoryOptionalsBlock (Payworks.MPAccessoryOptionals arg0);
	public delegate void MPAccessoryProvisionFailure (Payworks.MPAccessory arg0, NSError arg1);
	public delegate void MPAccessoryProvisionSuccess (Payworks.MPAccessory arg0);
	public delegate void MPAccessoryUpdateFailure (Payworks.MPAccessory arg0, NSError arg1);
	public delegate void MPAccessoryUpdateStateFailure (Payworks.MPAccessory arg0, NSError arg1);
	public delegate void MPAccessoryUpdateStateSuccess (Payworks.MPAccessory arg0);
	public delegate void MPAccessoryUpdateSuccess (Payworks.MPAccessory arg0);
	public delegate void MPCustomerReceiptSendingFailure (string arg0, string arg1, NSError arg2);
	public delegate void MPCustomerReceiptSendingSuccess (string arg0, string arg1);
	public delegate void MPExternalAccessoryOptionalsBlock (Payworks.MPExternalAccessoryOptionals arg0);
	public delegate void MPPaymentAccessoryDisplayIdleScreenFailure (Payworks.MPAccessory arg0, NSError arg1);
	public delegate void MPPaymentAccessoryDisplayIdleScreenSuccess (Payworks.MPAccessory arg0);
	public delegate void MPPaymentAccessoryDisplayTextFailure (Payworks.MPAccessory arg0, NSObject[] arg1, NSError arg2);
	public delegate void MPPaymentAccessoryDisplayTextSuccess (Payworks.MPAccessory arg0, NSObject[] arg1);
	public delegate void MPPrintingProcessCompleted (Payworks.MPPrintingProcess arg0, Payworks.MPTransaction arg1, Payworks.MPPrintingProcessDetails arg2);
	public delegate void MPPrintingProcessStatusChanged (Payworks.MPPrintingProcess arg0, Payworks.MPTransaction arg1, Payworks.MPPrintingProcessDetails arg2);
	public delegate void MPRefundTransactionApproved (Payworks.MPTransaction arg0);
	public delegate void MPRefundTransactionDeclined (Payworks.MPTransaction arg0);
	public delegate void MPRefundTransactionFailure (Payworks.MPTransactionParameters arg0, NSError arg1);
	public delegate void MPRefundTransactionParamsWithoutCardFailure (Payworks.MPTransactionParameters arg0, NSError arg1);
	public delegate void MPRefundTransactionWithoutCardApproved (Payworks.MPTransaction arg0);
	public delegate void MPRefundTransactionWithoutCardDeclined (Payworks.MPTransaction arg0);
	public delegate void MPTransactionAbort (Payworks.MPTransaction arg0);
	public delegate void MPTransactionAbortFailure (Payworks.MPTransaction arg0, NSError arg1);
	public delegate void MPTransactionAbortSuccess (Payworks.MPTransaction arg0);
	public delegate void MPTransactionActionRequired (Payworks.MPTransaction arg0, int arg1, Payworks.MPTransactionActionSupport arg2);
	public delegate void MPTransactionApproval (Payworks.MPTransaction arg0);
	public delegate void MPTransactionCaptureFailure (NSError arg0);
	public delegate void MPTransactionCaptureSuccess (Payworks.MPTransaction arg0);
	public delegate void MPTransactionDecline (Payworks.MPTransaction arg0);
	public delegate void MPTransactionFailure (Payworks.MPTransaction arg0, NSError arg1);
	public delegate void MPTransactionLookupFailure (string arg0, NSError arg1);
	public delegate void MPTransactionLookupSuccess (Payworks.MPTransaction arg0);
	public delegate void MPTransactionModuleLookupByTransactionIdentifierCompleted (Payworks.MPTransaction arg0, NSError arg1);
	public delegate void MPTransactionModuleSendingCustomerReceiptCompleted (string arg0, string arg1, NSError arg2);
	public delegate void MPTransactionModulQueryCompleted (NSObject[] arg0, NSError arg1);
	public delegate void MPTransactionParametersCaptureOptionalsBlock (Payworks.MPTransactionParametersCaptureOptionals arg0);
	public delegate void MPTransactionParametersOptionalsBlock (Payworks.MPTransactionParametersOptionals arg0);
	public delegate void MPTransactionParametersRefundOptionalsBlock (Payworks.MPTransactionParametersRefundOptionals arg0);
	public delegate void MPTransactionProcessActionRequired (Payworks.MPTransactionProcess arg0, Payworks.MPTransaction arg1, int arg2, Payworks.MPTransactionActionSupport arg3);
	public delegate void MPTransactionProcessCompleted (Payworks.MPTransactionProcess arg0, Payworks.MPTransaction arg1, Payworks.MPTransactionProcessDetails arg2);
	public delegate void MPTransactionProcessParametersStepsBlock (Payworks.MPTransactionProcessParametersSteps arg0);
	public delegate void MPTransactionProcessRegistered (Payworks.MPTransactionProcess arg0, Payworks.MPTransaction arg1);
	public delegate void MPTransactionProcessStatusChanged (Payworks.MPTransactionProcess arg0, Payworks.MPTransaction arg1, Payworks.MPTransactionProcessDetails arg2);
	public delegate void MPTransactionQueryFailure (NSError arg0);
	public delegate void MPTransactionQuerySuccess (NSObject[] arg0);
}

