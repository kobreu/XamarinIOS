using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Payworks
{
	static class CFunctions
	{
		// extern int NS_OPTIONS (int NSUInteger, int MPTransactionAction);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_OPTIONS (int NSUInteger, int MPTransactionAction);

		// extern int NS_ENUM (int NSUInteger, int MPTransactionType);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPTransactionType);

		// extern int NS_ENUM (int NSUInteger, int MPTransactionStatus);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPTransactionStatus);

		// extern int NS_ENUM (int NSUInteger, int MPCurrency);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPCurrency);


		// extern int NS_ENUM (int NSUInteger, int MPTransactionState);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPTransactionState);

		// extern int NS_ENUM (int NSUInteger, int MPAccessoryType);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPAccessoryType);

		// extern int NS_ENUM (int NSUInteger, int MPAccessoryFamily);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPAccessoryFamily);

		// extern int NS_ENUM (int NSUInteger, int MPAccessoryState);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPAccessoryState);

		//[DllImport ("__Internal")]
		//static extern int NS_ENUM (int NSUInteger, int MPProviderMode);

		// extern int NS_ENUM (int NSUInteger, int MPAccessoryConnectionType);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPAccessoryConnectionType);

		// extern int NS_ENUM (int NSUInteger, int MPAccessoryConnectionState);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPAccessoryConnectionState);

		// extern int NS_ENUM (int NSUInteger, int MPAccessoryBatteryState);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPAccessoryBatteryState);

		// extern int NS_ENUM (int NSUInteger, int MPLocale);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_ENUM (int NSUInteger, int MPLocale);

		// extern int NS_OPTIONS (int NSUInteger, int MPAccessoryComponentType);
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern int NS_OPTIONS (int NSUInteger, int MPAccessoryComponentType);
	}

	[Native]
	public enum MPAccessoryFamily : long
	{
		/** Use a mock */
   		Mock = 0,
    
	    /** Use the Miura MPI devices  */
	    MiuraMPI = 1,
	    
	    /** Use the Verifone e-Series (except e105) */
	    VerifoneESeries = 2,
	    /** Use the Verifone e105 */
	    VerifoneE105 = 3,
	    
	    /** Use the Sewoo printer */
	    Sewoo = 4,
	    
	    /** Use the BBPOS WisePad or WisePOS */
	    BBPOS = 5,
	    /** Use the BBPOS Chipper */
	    BBPOSChipper = 6
	}

	[Native]
	public enum MPCurrency : long
	{
		/** Unknown or not available */
	    Unknown = 0,
	    /** United Arab Emirates Dirham */
	    AED,
	    /** Australian Dollar */
	    AUD,
	    /** Bulgarian Lev */
	    BGN,
	    /** Brazilian Real */
	    BRL,
	    /** Swiss Franc */
	    CHF,
	    /** Czech Koruna */
	    CZK,
	    /** Danish Krone  */
	    DKK,
	    /** Euro */
	    EUR,
	    /** Pound Sterling */
	    GBP,
	    /** Ghanaian cedi*/
	    GHS,
	    /** Hong Kong Dollars */
	    HKD,
	    /** Croatian Kuna */
	    HRK,
	    /** Hungarian Forint */
	    HUF,
	    /** Indian Rupee */
	    INR,
	    /** Lithuanian Litas */
	    LTL,
	    /** Latvian Lats */
	    LVL,
	    /** Norwegian Krone */
	    NOK,
	    /** Polish Zloty */
	    PLN,
	    /** Romanian Leu */
	    RON,
	    /** Swedish Krona */
	    SEK,
	    /** Singapore Dollar */
	    SGD,
	    /** US Dollar */
	    USD,
	    /** South African Rand */
	    ZAR
	}



	public enum MPReceiptLineKey : int
	{
		Unknown,
		ReceiptType,
		TransactionType,
		Subject,
		Identifier,
		AmountAndCurrency,
		Date,
		Time,
		StatusText,
		PaymentDetailsSchemeOrLabel,
		PaymentDetailsMaskedAccount,
		PaymentDetailsSource,
		PaymentDetailsEMVApplicationID,
		PaymentDetailsAccountSequenceNumber,
		PaymentDetailsCustomerVerification,
		ClearingDetailsTransactionIdentifier,
		ClearingDetailsOriginalTransactionIdentifier,
		ClearingDetailsAuthorizationCode,
		ClearingDetailsMerchantId,
		ClearingDetailsTerminalId,
		MerchantDetailsPublicName,
		MerchantDetailsAddress,
		MerchantDetailsZip,
		MerchantDetailsCity,
		MerchantDetailsCountry,
		MerchantDetailsContact,
		MerchantDetailsAdditionalInformation
	}

	[Native]
	public enum MPProviderMode : long
	{
		Unknown = 0,
		Live = 1,
		Test = 2,
		Mock = 3,
		Jungle = 4,
		LiveFixed = 5,
		TestFixed = 6
	}

	public enum MPTransactionAbortReason : uint
	{
		MerchantAborted = 0,
		AccessoryError,
		AccessoryNotWhitelisted
	}

	public enum MPErrorSource : uint
	{
		Unknown = 0,
		Parameter,
		Accessory,
		Transaction,
		Server,
		Sdk,
		Internal
	}

	public enum MPErrorType : uint
	{
		Unknown = 0,
		ParameterMissing,
		ParameterInvalid,
		AccessoryNotFound,
		AccessoryNotConnected,
		AccessoryAlreadyConnected,
		AccessoryAlreadyDisconnected,
		AccessoryBusy,
		AccessoryNotWhitelisted,
		AccessoryDeactivated,
		AccessoryRequiresUpdate,
		AccessoryBatteryLow,
		AccessoryTampered,
		AccessoryError,
		AccessoryComponentNotFound,
		AccessoryComponentPrinterBusy,
		AccessoryComponentPrinterPaperLowOrOut,
		AccessoryComponentPrinterCoverOpen,
		TransactionSessionNotFound,
		TransactionReferenceNotFound,
		TransactionInvalid,
		TransactionBusy,
		TransactionNoLongerAbortable,
		TransactionDeclined,
		TransactionAborted,
		TransactionError,
		TransactionActionError,
		ServerUnavailable,
		ServerAuthenticationFailed,
		ServerUnknownUsername,
		ServerPinningWithRemoteFailed,
		ServerTimeout,
		ServerError,
		ServerInvalidResponse,
		SDKResourcesNotFound,
		SDKResourcesModified,
		SDKConfigurationMissing,
		InternalInconsistency
	}

	public enum MPTransactionStatusDetailsCode : uint
	{
		Unknown = 0,
		InitializedAtServer,
		InitializedAtProcessor,
		InitializedWithReplacement,
		PendingWaitingForProcessor,
		PendingAwaitingFinalization,
		Approved,
		DeclinedCardOrTerminalDeclined,
		DeclinedProcessor,
		DeclinedInvalidTerminalSoftware,
		DeclinedInvalidTerminalConfiguration,
		DeclinedInvalidTerminal,
		DeclinedSessionExpired,
		DeclinedPinWrong,
		DeclinedPinWrongTooOften,
		DeclinedCardExpired,
		DeclinedCardInvalidScheme,
		DeclinedCardInvalidPan,
		DeclinedCardStolen,
		DeclinedCardUseOriginal,
		DeclinedProcessorExceedsWithdrawalCountLimit,
		DeclinedProcessorUncapturedChargesNotSupported,
		DeclinedProcessorInconsistentState,
		DeclinedMalformedRequest,
		DeclinedManipulationSuspected,
		DeclinedCardBlocked,
		DeclinedInsufficientFunds,
		DeclinedTransactionFrequencyExceeded,
		DeclinedCardLost,
		DeclinedInvalidScheme,
		DeclinedInvalidAmount,
		DeclinedInvalidConfiguration,
		DeclinedDuplicateTransaction,
		DeclinedInvalidWorkflow,
		DeclinedProcessorCardExpired,
		DeclinedProcessorRefundNotPossible,
		DeclinedProcessorTemporarilyBlacklisted,
		DeclinedAmountExceedsLimit,
		AbortedShopperRemovedCard,
		AbortedShopperAborted,
		AbortedMerchantAborted,
		AbortedWaitingForCardTimeout,
		ErrorInvalidProcessorFormat,
		ErrorInvalidProcessorStatus,
		ErrorMissingProcessorSession,
		ErrorInvalidProcessorSession,
		ErrorInvalidProcessorNonce,
		ErrorProcessorConnectionError,
		ErrorProcessorFailedInconsistentStateUnresolved,
		ErrorProcessorFailedInconsistentStateResolved,
		ErrorProcessorPaymentDetailsExtractionFailed,
		ErrorProcessorInvalidPaymentDetails,
		ErrorProcessorInvalidConfiguration,
		ErrorProcessorMalformedRequest,
		ErrorProcessorTransactionAlreadyInProgress,
		ErrorProcessorConnectionNoResponse,
		ErrorTerminalError,
		ErrorTerminalTimeout,
		ErrorServerInvalidResponse,
		ErrorServerUnavailable,
		ErrorServerAuthenticationFailed,
		ErrorServerPinningWithRemoteFailed,
		ErrorServerTimeout,
		ErrorServerAccessoryDeactivated,
		ErrorServerAccessoryNotAssignedToMerchant,
		ErrorServerSessionTimeout,
		ErrorApprovedOffline
	}

	public enum MPPaymentDetailsSource : uint
	{
		Unknown = 0,
		Manual,
		Icc,
		MagneticStripe,
		MagneticStripeFallback,
		NFCUsingEMV,
		NFCUsingMSD
	}

	public enum MPPaymentDetailsScheme : uint
	{
		Unknown = 0,
		MasterCard,
		Visa,
		VISAElectron,
		Maestro,
		AmericanExpress,
		Jcb,
		DinersClub,
		Discover,
		UnionPay
	}


	public enum MPPaymentDetailsCustomerVerification : uint
	{
		Unknown = 0,
		None,
		Signature,
		Pin,
		PINAndSignature,
		CustomerDevice
	}

	public enum MPRefundDetailsStatus : uint
	{
		Unknown = 0,
		NonRefundable,
		RefundablePartialAndFull,
		RefundableFullOnly,
		Refunded
	}

	public enum MPRefundDetailsProcess : uint
	{
		Unknown = 0,
		AnyCard = 1 << 0,
		WithoutCard = 1 << 1,
		SameCard = 1 << 2
	}

	public enum MPRefundTransactionCode : uint
	{
		Unknown = 0,
		RefundBeforeClearing,
		RefundAfterClearing,
		PartialCapture
	}

	public enum MPPaymentAccessoryFeature : uint
	{
		None = 0,
		MagneticStripe = 1 << 0,
		Icc = 1 << 1,
		Nfc = 1 << 2,
		EMVKernel = 1 << 3,
		SREDEncryption = 1 << 4,
		PINEncryption = 1 << 5,
		Keypad = 1 << 6,
		Display = 1 << 7,
		OnlineTransactions = 1 << 8,
		OfflineTransactions = 1 << 9,
		OfflinePIN = 1 << 10,
		AbortWithKey = 1 << 11,
		Refund = 1 << 12
	}

	public enum MPPaymentAccessoryRequirement : uint
	{
		None = 0,
		AmountConfirmation = 1 << 0,
		AuthenticationBeforeUpdate = 1 << 1,
		ManualNFCActivation = 1 << 2,
		ContactlessOnlyWorkaround = 1 << 3
	}

	public enum MPAccessoryUpdateRequirementStatus : uint
	{
		NoUpdateAvailable = 0,
		UpdateAvailableAndRequired,
		UpdateAvailableButInGracePeriod
	}

	public enum MPAccessoryUpdateRequirementComponent : uint
	{
		None = 0,
		Software = 1 << 0,
		Configuration = 1 << 1,
		Security = 1 << 2,
		Firmware = 1 << 3
	}

	public enum MPProviderComponentDelegateDisplayUpdateType : uint
	{
		Text = 0,
		Pin
	}

	public enum MPAccessoryCardEvent : uint
	{
		Unknown = 0,
		Inserted,
		Removed,
		Swiped
	}

	public enum MPAccessoryKeyEvent : uint
	{
		Unknown = 0,
		Numeric,
		Cancel,
		Ok,
		Back
	}

	public enum MPPINInformationStatus : uint
	{
		Started,
		Update,
		Completed,
		Incorrect,
		LastTry
	}

	public enum MPAccessoryComponentPrinterState : uint
	{
		Unknown = 0,
		Normal,
		Busy,
		PaperLowOrEmpty,
		CoverOpen
	}

	public enum MPAccessoryComponentBarcodeScannerConfigurationTriggerMode
	{
		Edge = 0,
		Level,
		Soft,
		Passive
	}

	public enum MPAccessoryComponentBarcodeScannerConfigurationScanMode
	{
		MPAccessoryComponentBarcodeScannerConfigurationScanMode1D = 0,
		MPAccessoryComponentBarcodeScannerConfigurationScanMode1D2D
	}

	public enum MPAccessoryComponentBarcodeScannerConfigurationContinuousMode
	{
		Disabled = 0,
		Enabled
	}

	public enum MPAccessoryComponentBarcodeScannerConfigurationBarcodeType : uint
	{
		Unknown = 0,
		UpcEan,
		Code39,
		Code128,
		Pdf417,
		Qr,
		Invalid
	}

	public enum MPAccessoryComponentInteractionPrompt : uint
	{
		Tip = 0,
		MobileNumber,
		TableNumber,
		Amount
	}

	public enum MPAccessoryComponentInteractionConfirmationKey : uint
	{
		Ok = 1 << 0,
		Cancel = 1 << 1,
		Back = 1 << 2,
		Numeric = 1 << 3
	}

	public enum MPPrintingProcessDetailsState : uint
	{
		Created,
		FetchingTransaction,
		ConnectingToAccessory,
		SendingToPrinter,
		SentToPrinter,
		Aborted,
		Failed
	}

	public enum MPPrintingProcessDetailsStateDetails : uint
	{
		Created,
		FetchingTransaction,
		ConnectingToAccessory,
		ConnectingToAccessoryWaitingForPrinter,
		SendingToPrinterCheckingState,
		SendingToPrinter,
		SentToPrinter,
		Aborted,
		FailedPaperEmpty,
		FailedCoverOpen,
		Failed
	}

	public enum MPTransactionProcessDetailsState : uint
	{
		Created,
		ConnectingToAccessory,
		Preparing,
		InitializingTransaction,
		WaitingForCardPresentation,
		WaitingForCardRemoval,
		Processing,
		Approved,
		Declined,
		Aborted,
		Failed,
		NotRefundable,
		Inconclusive
	}

	public enum MPTransactionProcessDetailsStateDetails : uint
	{
		Created,
		ConnectingToAccessory,
		ConnectingToAccessoryCheckingForUpdate,
		ConnectingToAccessoryUpdating,
		ConnectingToAccessoryWaitingForReader,
		PreparingAskingForTip,
		InitializingTransactionRegistering,
		InitializingTransactionQuerying,
		WaitingForCardPresentation,
		WaitingForCardRemoval,
		Processing,
		ProcessingActionRequired,
		ProcessingWaitingForPIN,
		ProcessingCompleted,
		Approved,
		Declined,
		Aborted,
		Failed,
		NotRefundable,
		Inconclusive
	}

	public enum MPTransactionParametersType : uint
	{
		Charge,
		Refund,
		Capture
	}
}
