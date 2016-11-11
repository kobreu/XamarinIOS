using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;
//using mpos.core;

namespace Payworks
{
	// @interface MPTransaction
	[BaseType(typeof(NSObject))]
	interface MPTransaction
	{
		// @property (readonly, nonatomic, strong) int * _Nonnull amount;
		[Export("amount", ArgumentSemantic.Strong)]
		String Amount { get; }

		// @property (readonly, assign, nonatomic) int currency;
		[Export("currency")]
		int Currency { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable subject;
		[NullAllowed, Export("subject", ArgumentSemantic.Strong)]
		String Subject { get; }

		// @property (readonly, nonatomic, strong) int * _Nonnull statementDescriptor;
		[Export("statementDescriptor", ArgumentSemantic.Strong)]
		String StatementDescriptor { get; }

		// @property (readonly, assign, nonatomic) int type;
		[Export("type")]
		int Type { get; }

		// @property (readonly, assign, nonatomic) int captured;
		[Export("captured")]
		int Captured { get; }

		// @property (readonly, nonatomic, strong) MPPaymentDetails * _Nonnull paymentDetails;
		[Export("paymentDetails", ArgumentSemantic.Strong)]
		MPPaymentDetails PaymentDetails { get; }

		// @property (readonly, nonatomic, strong) MPRefundDetails * _Nonnull refundDetails;
		[Export("refundDetails", ArgumentSemantic.Strong)]
		MPRefundDetails RefundDetails { get; }

		// @property (readonly, nonatomic, strong) MPClearingDetails * _Nonnull clearingDetails;
		[Export("clearingDetails", ArgumentSemantic.Strong)]
		MPClearingDetails ClearingDetails { get; }

		// @property (readonly, nonatomic, strong) MPCardDetails * _Nonnull cardDetails;
		[Export("cardDetails", ArgumentSemantic.Strong)]
		MPCardDetails CardDetails { get; }

		// @property (readonly, nonatomic, strong) MPShopperDetails * _Nonnull shopperDetails;
		[Export("shopperDetails", ArgumentSemantic.Strong)]
		MPShopperDetails ShopperDetails { get; }

		// @property (readonly, nonatomic, strong) MPTransactionDetails * _Nonnull details;
		[Export("details", ArgumentSemantic.Strong)]
		MPTransactionDetails Details { get; }

		// @property (readonly, assign, nonatomic) int status;
		[Export("status")]
		int Status { get; }

		// @property (readonly, nonatomic, strong) MPStatusDetails * _Nullable statusDetails;
		[NullAllowed, Export("statusDetails", ArgumentSemantic.Strong)]
		MPStatusDetails StatusDetails { get; }

		// @property (readonly, assign, nonatomic) int state;
		[Export("state")]
		int State { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable error;
		[NullAllowed, Export("error", ArgumentSemantic.Strong)]
		String Error { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable sessionIdentifier;
		[NullAllowed, Export("sessionIdentifier", ArgumentSemantic.Strong)]
		String SessionIdentifier { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable identifier;
		[NullAllowed, Export("identifier", ArgumentSemantic.Strong)]
		String Identifier { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable groupIdentifier;
		[NullAllowed, Export("groupIdentifier", ArgumentSemantic.Strong)]
		String GroupIdentifier { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable referencedTransactionIdentifier;
		[NullAllowed, Export("referencedTransactionIdentifier", ArgumentSemantic.Strong)]
		String ReferencedTransactionIdentifier { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable customIdentifier;
		[NullAllowed, Export("customIdentifier", ArgumentSemantic.Strong)]
		String CustomIdentifier { get; }

		// @property (readonly, nonatomic, strong) int * _Nullable created;
		[NullAllowed, Export("created", ArgumentSemantic.Strong)]
		String Created { get; }

		// -(id)canBeAborted;
		[Export("canBeAborted")]
		//[Verify (MethodToProperty)]
		NSObject CanBeAborted { get; }

		// @property (readonly, nonatomic, strong) MPProcessingDetails * _Nonnull processingDetails;
		[Export("processingDetails", ArgumentSemantic.Strong)]
		MPProcessingDetails ProcessingDetails { get; }

		// @property (readonly, nonatomic, strong) MPReceipt * _Nullable customerReceipt;
		[NullAllowed, Export("customerReceipt", ArgumentSemantic.Strong)]
		MPReceipt CustomerReceipt { get; }

		// @property (readonly, nonatomic, strong) MPReceipt * _Nullable merchantReceipt;
		[NullAllowed, Export("merchantReceipt", ArgumentSemantic.Strong)]
		MPReceipt MerchantReceipt { get; }
	}

	// @interface MPAccessory
	[BaseType(typeof(NSObject))]
	interface MPAccessory
	{
		// @property (readonly, assign, nonatomic) int type;
		[Export("type")]
		int Type { get; }

		// @property (readonly, nonatomic, strong) MPAccessoryDetails * _Nonnull details;
		[Export("details", ArgumentSemantic.Strong)]
		MPAccessoryDetails Details { get; }

		// @property (readonly, assign, nonatomic) int connectionType;
		[Export("connectionType")]
		int ConnectionType { get; }

		// @property (readonly, assign, nonatomic) int connectionState;
		[Export("connectionState")]
		int ConnectionState { get; }

		// @property (readonly, assign, nonatomic) int batteryState;
		[Export("batteryState")]
		int BatteryState { get; }

		// @property (readonly, assign, nonatomic) int batteryLevel;
		[Export("batteryLevel")]
		int BatteryLevel { get; }

		// @property (readonly, assign, nonatomic) int state;
		[Export("state")]
		int State { get; }

		// @property (readonly, assign, nonatomic) int components;
		[Export("components")]
		int Components { get; }

		// -(MPAccessoryComponent * _Nullable)componentForType:(id)component;
		[Export("componentForType:")]
		[return: NullAllowed]
		MPAccessoryComponent ComponentForType(NSObject component);
	}

	// @interface MPReceiptLineItem : NSObject
	[BaseType(typeof(NSObject))]
	interface MPReceiptLineItem
	{
		// @property (readonly, assign, nonatomic) MPReceiptLineKey key;
		[Export("key", ArgumentSemantic.Assign)]
		MPReceiptLineKey Key { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull label;
		[Export("label", ArgumentSemantic.Strong)]
		string Label { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull value;
		[Export("value", ArgumentSemantic.Strong)]
		string Value { get; }
	}

	// @interface MPReceipt : NSObject
	[BaseType(typeof(NSObject))]
	interface MPReceipt
	{
		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull receiptType;
		[Export("receiptType", ArgumentSemantic.Strong)]
		MPReceiptLineItem ReceiptType { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull transactionType;
		[Export("transactionType", ArgumentSemantic.Strong)]
		MPReceiptLineItem TransactionType { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nullable subject;
		[NullAllowed, Export("subject", ArgumentSemantic.Strong)]
		MPReceiptLineItem Subject { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull identifier;
		[Export("identifier", ArgumentSemantic.Strong)]
		MPReceiptLineItem Identifier { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull amountAndCurrency;
		[Export("amountAndCurrency", ArgumentSemantic.Strong)]
		MPReceiptLineItem AmountAndCurrency { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull date;
		[Export("date", ArgumentSemantic.Strong)]
		MPReceiptLineItem Date { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull time;
		[Export("time", ArgumentSemantic.Strong)]
		MPReceiptLineItem Time { get; }

		// @property (readonly, nonatomic, strong) MPReceiptLineItem * _Nonnull statusText;
		[Export("statusText", ArgumentSemantic.Strong)]
		MPReceiptLineItem StatusText { get; }

		// @property (readonly, assign, nonatomic) BOOL printSignatureLine;
		[Export("printSignatureLine")]
		bool PrintSignatureLine { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull clearingDetails;
		[Export("clearingDetails", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] ClearingDetails { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull paymentDetails;
		[Export("paymentDetails", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] PaymentDetails { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull merchantDetails;
		[Export("merchantDetails", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] MerchantDetails { get; }

		// -(MPReceiptLineItem * _Nullable)receiptLineItemForKey:(MPReceiptLineKey)key;
		[Export("receiptLineItemForKey:")]
		[return: NullAllowed]
		MPReceiptLineItem ReceiptLineItemForKey(MPReceiptLineKey key);

		// -(NSString * _Nonnull)prettyPrinted;
		[Export("prettyPrinted")]
		//[Verify (MethodToProperty)]
		string PrettyPrinted { get; }
	}

	// typedef void (^MPAccessoryConnectSuccess)(MPAccessory * _Nonnull);
	delegate void MPAccessoryConnectSuccess(MPAccessory arg0);

	// typedef void (^MPAccessoryConnectFailure)(NSError * _Nonnull);
	delegate void MPAccessoryConnectFailure(NSError arg0);

	// typedef void (^MPAccessoryCheckUpdateSuccess)(MPAccessory * _Nonnull, MPAccessoryUpdateRequirement * _Nonnull);
	delegate void MPAccessoryCheckUpdateSuccess(MPAccessory arg0, MPAccessoryUpdateRequirement arg1);

	// typedef void (^MPAccessoryCheckUpdateFailure)(MPAccessory * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryCheckUpdateFailure(MPAccessory arg0, NSError arg1);

	// typedef void (^MPAccessoryUpdateSuccess)(MPAccessory * _Nonnull);
	delegate void MPAccessoryUpdateSuccess(MPAccessory arg0);

	// typedef void (^MPAccessoryUpdateFailure)(MPAccessory * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryUpdateFailure(MPAccessory arg0, NSError arg1);

	// typedef void (^MPAccessoryProvisionSuccess)(MPAccessory * _Nonnull);
	delegate void MPAccessoryProvisionSuccess(MPAccessory arg0);

	// typedef void (^MPAccessoryProvisionFailure)(MPAccessory * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryProvisionFailure(MPAccessory arg0, NSError arg1);

	// typedef void (^MPAccessoryUpdateStateSuccess)(MPAccessory * _Nonnull);
	delegate void MPAccessoryUpdateStateSuccess(MPAccessory arg0);

	// typedef void (^MPAccessoryUpdateStateFailure)(MPAccessory * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryUpdateStateFailure(MPAccessory arg0, NSError arg1);

	// typedef void (^MPAccessoryDisconnectSuccess)(MPAccessory * _Nonnull);
	delegate void MPAccessoryDisconnectSuccess(MPAccessory arg0);

	// typedef void (^MPAccessoryDisconnectFailure)(MPAccessory * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryDisconnectFailure(MPAccessory arg0, NSError arg1);

	// typedef void (^MPTransactionLookupSuccess)(MPTransaction * _Nonnull);
	delegate void MPTransactionLookupSuccess(MPTransaction arg0);

	// typedef void (^MPTransactionLookupFailure)(NSString * _Nonnull, NSError * _Nonnull);
	delegate void MPTransactionLookupFailure(string arg0, NSError arg1);

	// typedef void (^MPTransactionApproval)(MPTransaction * _Nonnull);
	delegate void MPTransactionApproval(MPTransaction arg0);

	// typedef void (^MPTransactionDecline)(MPTransaction * _Nonnull);
	delegate void MPTransactionDecline(MPTransaction arg0);

	// typedef void (^MPTransactionAbort)(MPTransaction * _Nonnull);
	delegate void MPTransactionAbort(MPTransaction arg0);

	// typedef void (^MPTransactionFailure)(MPTransaction * _Nonnull, NSError * _Nonnull);
	delegate void MPTransactionFailure(MPTransaction arg0, NSError arg1);

	// typedef void (^MPTransactionCaptureSuccess)(MPTransaction * _Nonnull);
	delegate void MPTransactionCaptureSuccess(MPTransaction arg0);

	// typedef void (^MPTransactionCaptureFailure)(NSError * _Nonnull);
	delegate void MPTransactionCaptureFailure(NSError arg0);

	// typedef void (^MPTransactionActionRequired)(MPTransaction * _Nonnull, int, MPTransactionActionSupport * _Nullable);
	delegate void MPTransactionActionRequired(MPTransaction arg0, int arg1, [NullAllowed] MPTransactionActionSupport arg2);

	// typedef void (^MPTransactionAbortSuccess)(MPTransaction * _Nonnull);
	delegate void MPTransactionAbortSuccess(MPTransaction arg0);

	// typedef void (^MPTransactionAbortFailure)(MPTransaction * _Nonnull, NSError * _Nonnull);
	delegate void MPTransactionAbortFailure(MPTransaction arg0, NSError arg1);

	// typedef void (^MPRefundTransactionWithoutCardApproved)(MPTransaction * _Nonnull);
	delegate void MPRefundTransactionWithoutCardApproved(MPTransaction arg0);

	// typedef void (^MPRefundTransactionWithoutCardDeclined)(MPTransaction * _Nonnull);
	delegate void MPRefundTransactionWithoutCardDeclined(MPTransaction arg0);

	// typedef void (^MPRefundTransactionParamsWithoutCardFailure)(MPTransactionParameters * _Nonnull, NSError * _Nonnull);
	delegate void MPRefundTransactionParamsWithoutCardFailure(MPTransactionParameters arg0, NSError arg1);

	// typedef void (^MPRefundTransactionApproved)(MPTransaction * _Nonnull);
	delegate void MPRefundTransactionApproved(MPTransaction arg0);

	// typedef void (^MPRefundTransactionDeclined)(MPTransaction * _Nonnull);
	delegate void MPRefundTransactionDeclined(MPTransaction arg0);

	// typedef void (^MPRefundTransactionFailure)(MPTransactionParameters * _Nonnull, NSError * _Nonnull);
	delegate void MPRefundTransactionFailure(MPTransactionParameters arg0, NSError arg1);

	// typedef void (^MPCustomerReceiptSendingSuccess)(NSString * _Nonnull, NSString * _Nonnull);
	delegate void MPCustomerReceiptSendingSuccess(string arg0, string arg1);

	// typedef void (^MPCustomerReceiptSendingFailure)(NSString * _Nonnull, NSString * _Nonnull, NSError * _Nonnull);
	delegate void MPCustomerReceiptSendingFailure(string arg0, string arg1, NSError arg2);

	// typedef void (^MPTransactionQuerySuccess)(NSArray * _Nonnull);
	delegate void MPTransactionQuerySuccess(NSObject[] arg0);

	// typedef void (^MPTransactionQueryFailure)(NSError * _Nonnull);
	delegate void MPTransactionQueryFailure(NSError arg0);

	// @interface MPProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface MPProvider
	{
		// @property (readonly, assign, nonatomic) int supportedActions;
		[Export("supportedActions")]
		int SupportedActions { get; }

		// @property (readonly, assign, nonatomic) MPProviderMode providerMode;
		[Export("providerMode", ArgumentSemantic.Assign)]
		MPProviderMode ProviderMode { get; }

		// @property (readonly, nonatomic, strong) MPPaymentDetailsFactory * _Nonnull paymentDetailsFactory;
		[Export("paymentDetailsFactory", ArgumentSemantic.Strong)]
		MPPaymentDetailsFactory PaymentDetailsFactory { get; }

		// @property (readonly, nonatomic, strong) MPTransactionActionResponseFactory * _Nonnull transactionActionResponseFactory;
		[Export("transactionActionResponseFactory", ArgumentSemantic.Strong)]
		MPTransactionActionResponseFactory TransactionActionResponseFactory { get; }

		// @property (readonly, nonatomic, strong) NSSet * _Nonnull accessories;
		[Export("accessories", ArgumentSemantic.Strong)]
		NSSet Accessories { get; }

		// @property (nonatomic, strong) dispatch_queue_t _Nonnull callbackQueue;
		[Export("callbackQueue", ArgumentSemantic.Strong)]
		DispatchQueue CallbackQueue { get; set; }

		// -(void)connectToAccessoryWithParameters:(MPAccessoryParameters * _Nonnull)parameters success:(MPAccessoryConnectSuccess _Nonnull)success failure:(MPAccessoryConnectFailure _Nonnull)failure;
		[Export("connectToAccessoryWithParameters:success:failure:")]
		void ConnectToAccessoryWithParameters(MPAccessoryParameters parameters, MPAccessoryConnectSuccess success, MPAccessoryConnectFailure failure);

		// -(void)checkUpdateRequirementForAccessory:(MPAccessory * _Nonnull)accessory success:(MPAccessoryCheckUpdateSuccess _Nonnull)success failure:(MPAccessoryCheckUpdateFailure _Nonnull)failure;
		[Export("checkUpdateRequirementForAccessory:success:failure:")]
		void CheckUpdateRequirementForAccessory(MPAccessory accessory, MPAccessoryCheckUpdateSuccess success, MPAccessoryCheckUpdateFailure failure);

		// -(void)updateAccessory:(MPAccessory * _Nonnull)accessory success:(MPAccessoryUpdateSuccess _Nonnull)success failure:(MPAccessoryUpdateFailure _Nonnull)failure;
		[Export("updateAccessory:success:failure:")]
		void UpdateAccessory(MPAccessory accessory, MPAccessoryUpdateSuccess success, MPAccessoryUpdateFailure failure);

		// -(void)provisionAccessory:(MPAccessory * _Nonnull)accessory success:(MPAccessoryProvisionSuccess _Nonnull)success failure:(MPAccessoryProvisionFailure _Nonnull)failure;
		[Export("provisionAccessory:success:failure:")]
		void ProvisionAccessory(MPAccessory accessory, MPAccessoryProvisionSuccess success, MPAccessoryProvisionFailure failure);

		// -(void)updateAccessoryState:(MPAccessory * _Nonnull)accessory success:(MPAccessoryUpdateStateSuccess _Nonnull)success failure:(MPAccessoryUpdateStateFailure _Nonnull)failure;
		[Export("updateAccessoryState:success:failure:")]
		void UpdateAccessoryState(MPAccessory accessory, MPAccessoryUpdateStateSuccess success, MPAccessoryUpdateStateFailure failure);

		// -(void)disconnectFromAccessory:(MPAccessory * _Nonnull)accessory success:(MPAccessoryDisconnectSuccess _Nonnull)success failure:(MPAccessoryDisconnectFailure _Nonnull)failure;
		[Export("disconnectFromAccessory:success:failure:")]
		void DisconnectFromAccessory(MPAccessory accessory, MPAccessoryDisconnectSuccess success, MPAccessoryDisconnectFailure failure);

		// -(void)lookupTransactionWithSessionIdentifier:(NSString * _Nonnull)identifier success:(MPTransactionLookupSuccess _Nonnull)success failure:(MPTransactionLookupFailure _Nonnull)failure;
		[Export("lookupTransactionWithSessionIdentifier:success:failure:")]
		void LookupTransactionWithSessionIdentifier(string identifier, MPTransactionLookupSuccess success, MPTransactionLookupFailure failure);

		// -(void)lookupTransactionWithTransactionIdentifier:(NSString * _Nonnull)identifier success:(MPTransactionLookupSuccess _Nonnull)success failure:(MPTransactionLookupFailure _Nonnull)failure;
		[Export("lookupTransactionWithTransactionIdentifier:success:failure:")]
		void LookupTransactionWithTransactionIdentifier(string identifier, MPTransactionLookupSuccess success, MPTransactionLookupFailure failure);

		// -(void)startTransaction:(MPTransaction * _Nonnull)transaction usingAccessory:(MPAccessory * _Nonnull)accessory approval:(MPTransactionApproval _Nonnull)approval decline:(MPTransactionDecline _Nonnull)decline abort:(MPTransactionAbort _Nonnull)abort failure:(MPTransactionFailure _Nonnull)failure actionRequired:(MPTransactionActionRequired _Nonnull)actionRequired;
		[Export("startTransaction:usingAccessory:approval:decline:abort:failure:actionRequired:")]
		void StartTransaction(MPTransaction transaction, MPAccessory accessory, MPTransactionApproval approval, MPTransactionDecline decline, MPTransactionAbort abort, MPTransactionFailure failure, MPTransactionActionRequired actionRequired);

		// -(void)continueTransaction:(MPTransaction * _Nonnull)transaction withAction:(id)action response:(MPTransactionActionResponse * _Nullable)response;
		[Export("continueTransaction:withAction:response:")]
		void ContinueTransaction(MPTransaction transaction, NSObject action, [NullAllowed] MPTransactionActionResponse response);

		// -(void)abortTransaction:(MPTransaction * _Nonnull)transaction success:(MPTransactionAbortSuccess _Nonnull)success failure:(MPTransactionAbortFailure _Nonnull)failure;
		[Export("abortTransaction:success:failure:")]
		void AbortTransaction(MPTransaction transaction, MPTransactionAbortSuccess success, MPTransactionAbortFailure failure);

		// -(void)abortTransaction:(MPTransaction * _Nonnull)transaction reason:(MPTransactionAbortReason)reason success:(MPTransactionAbortSuccess _Nonnull)success failure:(MPTransactionAbortFailure _Nonnull)failure;
		[Export("abortTransaction:reason:success:failure:")]
		void AbortTransaction(MPTransaction transaction, MPTransactionAbortReason reason, MPTransactionAbortSuccess success, MPTransactionAbortFailure failure);

		// -(void)captureTransactionWithParameters:(MPTransactionParameters * _Nonnull)parameters success:(MPTransactionCaptureSuccess _Nonnull)success failure:(MPTransactionCaptureFailure _Nonnull)failure;
		[Export("captureTransactionWithParameters:success:failure:")]
		void CaptureTransactionWithParameters(MPTransactionParameters parameters, MPTransactionCaptureSuccess success, MPTransactionCaptureFailure failure);

		// -(void)sendCustomerReceiptForTransactionIdentifier:(NSString * _Nonnull)transactionIdentifier emailAddress:(NSString * _Nonnull)emailAddress success:(MPCustomerReceiptSendingSuccess _Nonnull)success failure:(MPCustomerReceiptSendingFailure _Nonnull)failure;
		[Export("sendCustomerReceiptForTransactionIdentifier:emailAddress:success:failure:")]
		void SendCustomerReceiptForTransactionIdentifier(string transactionIdentifier, string emailAddress, MPCustomerReceiptSendingSuccess success, MPCustomerReceiptSendingFailure failure);

		// -(void)refundTransactionWithoutCardForParameters:(MPTransactionParameters * _Nonnull)transactionParameters approved:(MPRefundTransactionWithoutCardApproved _Nonnull)approved declined:(MPRefundTransactionWithoutCardDeclined _Nonnull)declined failure:(MPRefundTransactionParamsWithoutCardFailure _Nonnull)failure;
		[Export("refundTransactionWithoutCardForParameters:approved:declined:failure:")]
		void RefundTransactionWithoutCardForParameters(MPTransactionParameters transactionParameters, MPRefundTransactionWithoutCardApproved approved, MPRefundTransactionWithoutCardDeclined declined, MPRefundTransactionParamsWithoutCardFailure failure);

		// -(void)refundTransactionWithParameters:(MPTransactionParameters * _Nonnull)transactionParameters approved:(MPRefundTransactionApproved _Nonnull)approved declined:(MPRefundTransactionDeclined _Nonnull)declined failure:(MPRefundTransactionFailure _Nonnull)failure;
		[Export("refundTransactionWithParameters:approved:declined:failure:")]
		void RefundTransactionWithParameters(MPTransactionParameters transactionParameters, MPRefundTransactionApproved approved, MPRefundTransactionDeclined declined, MPRefundTransactionFailure failure);

		// -(void)queryTransactionsUsingFilters:(MPTransactionFilterParameters * _Nonnull)filterParameters includeReceipts:(BOOL)includeReceipts range:(NSRange)range success:(MPTransactionQuerySuccess _Nonnull)success failure:(MPTransactionQueryFailure _Nonnull)failure;
		[Export("queryTransactionsUsingFilters:includeReceipts:range:success:failure:")]
		void QueryTransactionsUsingFilters(MPTransactionFilterParameters filterParameters, bool includeReceipts, NSRange range, MPTransactionQuerySuccess success, MPTransactionQueryFailure failure);

		// -(void)addProviderComponentDelegate:(id<MPProviderComponentDelegate> _Nonnull)delegate;
		[Export("addProviderComponentDelegate:")]
		void AddProviderComponentDelegate(MPProviderComponentDelegate @delegate);

		// -(void)removeProviderComponentDelegate:(id<MPProviderComponentDelegate> _Nonnull)delegate;
		[Export("removeProviderComponentDelegate:")]
		void RemoveProviderComponentDelegate(MPProviderComponentDelegate @delegate);

		// -(void)addAccessoryComponentCallback:(id<MPAccessoryComponentDelegate> _Nonnull)delegate;
		[Export("addAccessoryComponentCallback:")]
		void AddAccessoryComponentCallback(MPAccessoryComponentDelegate @delegate);

		// -(void)removeAccessoryComponentCallback:(id<MPAccessoryComponentDelegate> _Nonnull)delegate;
		[Export("removeAccessoryComponentCallback:")]
		void RemoveAccessoryComponentCallback(MPAccessoryComponentDelegate @delegate);
	}

	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	/*partial interface Constants
	{
		// extern NSString *const _Nonnull MPConnectSDKVersion;
		[Field("MPConnectSDKVersion", "__Internal")]
		NSString MPConnectSDKVersion { get; }
	}*/

	// @interface MPMpos : NSObject
	[BaseType(typeof(NSObject))]
	interface MPMpos
	{
		// +(MPProviderOptionsFactory * _Nonnull)providerOptionsFactory;
		[Static]
		[Export("providerOptionsFactory")]
		//[Verify (MethodToProperty)]
		MPProviderOptionsFactory ProviderOptionsFactory { get; }

		// +(MPProvider * _Nonnull)providerWithOptions:(MPProviderOptions * _Nonnull)options;
		[Static]
		[Export("providerWithOptions:")]
		MPProvider ProviderWithOptions(MPProviderOptions options);

		// +(NSString * _Nonnull)version;
		[Static]
		[Export("version")]
		//[Verify (MethodToProperty)]
		string Version { get; }

		// +(NSString * _Nonnull)build;
		[Static]
		[Export("build")]
		//[Verify (MethodToProperty)]
		string Build { get; }

		// +(MPTransactionProvider * _Nonnull)transactionProviderForMode:(MPProviderMode)mode merchantIdentifier:(NSString * _Nonnull)merchantIdentifier merchantSecretKey:(NSString * _Nonnull)merchantSecretKey;
		[Static]
		[Export("transactionProviderForMode:merchantIdentifier:merchantSecretKey:")]
		MPTransactionProvider TransactionProviderForMode(MPProviderMode mode, string merchantIdentifier, string merchantSecretKey);
	}

	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull MPErrorDomainKey;
		[Field("MPErrorDomainKey", "__Internal")]
		NSString MPErrorDomainKey { get; }

		// extern NSString *const _Nonnull MPErrorSourceKey;
		[Field("MPErrorSourceKey", "__Internal")]
		NSString MPErrorSourceKey { get; }

		// extern NSString *const _Nonnull MPErrorTypeKey;
		[Field("MPErrorTypeKey", "__Internal")]
		NSString MPErrorTypeKey { get; }

		// extern NSString *const _Nonnull MPErrorInfoKey;
		[Field("MPErrorInfoKey", "__Internal")]
		NSString MPErrorInfoKey { get; }

		// extern NSString *const _Nonnull MPErrorDeveloperInfoKey;
		[Field("MPErrorDeveloperInfoKey", "__Internal")]
		NSString MPErrorDeveloperInfoKey { get; }

		// extern NSString *const _Nonnull MPErrorLocalizedDescriptionKey;
		[Field("MPErrorLocalizedDescriptionKey", "__Internal")]
		NSString MPErrorLocalizedDescriptionKey { get; }
	}

	// @interface MPAdditions (NSError)
	[Category]
	[BaseType(typeof(NSError))]
	interface NSError_MPAdditions
	{
		// @property (readonly, assign, nonatomic) MPErrorSource source;
		//[Export ("source", ArgumentSemantic.Assign)]
		//MPErrorSource Source { get; }

		// @property (readonly, assign, nonatomic) MPErrorType type;
		//[Export ("type", ArgumentSemantic.Assign)]
		//MPErrorType Type { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable info;
		//[NullAllowed, Export ("info", ArgumentSemantic.Strong)]
		//string Info { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable developerInfo;
		//[NullAllowed, Export ("developerInfo", ArgumentSemantic.Strong)]
		//string DeveloperInfo { get; }

		// -(BOOL)isMPError;
		//[Export ("isMPError")]
		//[Verify (MethodToProperty)]
		//bool IsMPError { get; }
	}

	//[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull MPErrorKey;
		[Field("MPErrorKey", "__Internal")]
		NSString MPErrorKey { get; }
	}

	// @interface MPAdditions (NSException)
	[Category]
	[BaseType(typeof(NSException))]
	interface NSException_MPAdditions
	{
		// @property (readonly, nonatomic, strong) NSError * _Nullable errorInfo;
		//[NullAllowed, Export ("errorInfo", ArgumentSemantic.Strong)]
		//NSError ErrorInfo { get; }
	}

	// @interface MPLogFormatter : NSObject
	[BaseType(typeof(NSObject))]
	interface MPLogFormatter
	{
	}

	// @interface MPProviderOptionsFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface MPProviderOptionsFactory
	{
		// -(MPProviderOptions * _Nonnull)providerOptionsWithMode:(MPProviderMode)mode merchantIdentifer:(NSString * _Nonnull)merchantIdentifier merchantSecretKey:(NSString * _Nonnull)merchantSecretKey supportedActions:(id)supportedActions;
		[Export("providerOptionsWithMode:merchantIdentifer:merchantSecretKey:supportedActions:")]
		MPProviderOptions ProviderOptionsWithMode(MPProviderMode mode, string merchantIdentifier, string merchantSecretKey, NSObject supportedActions);

		// -(MPProviderOptions * _Nonnull)mockOptionsWithSupportedActions:(id)supportedActions;
		[Export("mockOptionsWithSupportedActions:")]
		MPProviderOptions MockOptionsWithSupportedActions(NSObject supportedActions);
	}

	// @interface MPProviderOptions : NSObject
	[BaseType(typeof(NSObject))]
	interface MPProviderOptions
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull merchantIdentifier;
		[Export("merchantIdentifier", ArgumentSemantic.Strong)]
		string MerchantIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull merchantSecretKey;
		[Export("merchantSecretKey", ArgumentSemantic.Strong)]
		string MerchantSecretKey { get; }

		// @property (readonly, assign, nonatomic) MPProviderMode mode;
		[Export("mode", ArgumentSemantic.Assign)]
		MPProviderMode Mode { get; }

		// @property (assign, nonatomic) int supportedActions;
		[Export("supportedActions")]
		int SupportedActions { get; set; }
	}

	// @interface MPProcessingDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPProcessingDetails
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable sessionIdentifier;
		[NullAllowed, Export("sessionIdentifier", ArgumentSemantic.Strong)]
		string SessionIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull identifier;
		[Export("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull timestamp;
		[Export("timestamp", ArgumentSemantic.Strong)]
		string Timestamp { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nonnull additionalInformation;
		[Export("additionalInformation", ArgumentSemantic.Strong)]
		NSDictionary AdditionalInformation { get; }
	}

	// @interface MPStatusDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPStatusDetails
	{
		// @property (readonly, assign, nonatomic) MPTransactionStatusDetailsCode code;
		[Export("code", ArgumentSemantic.Assign)]
		MPTransactionStatusDetailsCode Code { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable detailedDescription;
		[NullAllowed, Export("detailedDescription", ArgumentSemantic.Strong)]
		string DetailedDescription { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable developerDescription;
		[NullAllowed, Export("developerDescription", ArgumentSemantic.Strong)]
		string DeveloperDescription { get; }
	}

	// @interface MPPaymentDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPPaymentDetails
	{
		// @property (readonly, assign, nonatomic) MPPaymentDetailsSource source;
		[Export("source", ArgumentSemantic.Assign)]
		MPPaymentDetailsSource Source { get; }

		// @property (readonly, assign, nonatomic) MPPaymentDetailsScheme scheme;
		[Export("scheme", ArgumentSemantic.Assign)]
		MPPaymentDetailsScheme Scheme { get; }

		// @property (readonly, assign, nonatomic) MPPaymentDetailsCustomerVerification customerVerification;
		[Export("customerVerification", ArgumentSemantic.Assign)]
		MPPaymentDetailsCustomerVerification CustomerVerification { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable accountNumber;
		[NullAllowed, Export("accountNumber", ArgumentSemantic.Strong)]
		string AccountNumber { get; }
	}

	// @interface MPRefundDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPRefundDetails
	{
		// @property (readonly, assign, nonatomic) MPRefundDetailsStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		MPRefundDetailsStatus Status { get; }

		// @property (readonly, assign, nonatomic) MPRefundDetailsProcess process;
		[Export("process", ArgumentSemantic.Assign)]
		MPRefundDetailsProcess Process { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull refundTransactions;
		[Export("refundTransactions", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] RefundTransactions { get; }
	}

	// @interface MPTransactionDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionDetails
	{
		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable applicationFee;
		[NullAllowed, Export("applicationFee", ArgumentSemantic.Strong)]
		NSDecimalNumber ApplicationFee { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nullable includedTipAmount;
		[NullAllowed, Export("includedTipAmount", ArgumentSemantic.Strong)]
		NSDecimalNumber IncludedTipAmount { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Strong)]
		NSDictionary Metadata { get; }
	}

	// @interface MPClearingDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPClearingDetails
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable institute;
		[NullAllowed, Export("institute", ArgumentSemantic.Strong)]
		string Institute { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable transactionIdentifier;
		[NullAllowed, Export("transactionIdentifier", ArgumentSemantic.Strong)]
		string TransactionIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable originalTransactionIdentifier;
		[NullAllowed, Export("originalTransactionIdentifier", ArgumentSemantic.Strong)]
		string OriginalTransactionIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable completed;
		[NullAllowed, Export("completed", ArgumentSemantic.Strong)]
		NSDate Completed { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable authorizationCode;
		[NullAllowed, Export("authorizationCode", ArgumentSemantic.Strong)]
		string AuthorizationCode { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable merchantId;
		[NullAllowed, Export("merchantId", ArgumentSemantic.Strong)]
		string MerchantId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable terminalId;
		[NullAllowed, Export("terminalId", ArgumentSemantic.Strong)]
		string TerminalId { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable statusText;
		[NullAllowed, Export("statusText", ArgumentSemantic.Strong)]
		string StatusText { get; }
	}

	// @interface MPCardDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPCardDetails
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable cardHolderName;
		[NullAllowed, Export("cardHolderName", ArgumentSemantic.Strong)]
		string CardHolderName { get; }

		// @property (readonly, assign, nonatomic) NSUInteger expiryMonth;
		[Export("expiryMonth")]
		uint ExpiryMonth { get; }

		// @property (readonly, assign, nonatomic) NSUInteger expiryYear;
		[Export("expiryYear")]
		uint ExpiryYear { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable fingerprint;
		[NullAllowed, Export("fingerprint", ArgumentSemantic.Strong)]
		string Fingerprint { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable maskedCardNumber;
		[NullAllowed, Export("maskedCardNumber", ArgumentSemantic.Strong)]
		string MaskedCardNumber { get; }

		// @property (readonly, assign, nonatomic) MPPaymentDetailsScheme scheme;
		[Export("scheme", ArgumentSemantic.Assign)]
		MPPaymentDetailsScheme Scheme { get; }
	}

	// @interface MPRefundTransaction : NSObject
	[BaseType(typeof(NSObject))]
	interface MPRefundTransaction
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable identifier;
		[NullAllowed, Export("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable created;
		[NullAllowed, Export("created", ArgumentSemantic.Strong)]
		NSDate Created { get; }

		// @property (readonly, nonatomic, strong) NSDecimalNumber * _Nonnull amount;
		[Export("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; }

		// @property (readonly, assign, nonatomic) int currency;
		[Export("currency")]
		int Currency { get; }

		// @property (readonly, assign, nonatomic) int type;
		[Export("type")]
		int Type { get; }

		// @property (readonly, assign, nonatomic) MPRefundTransactionCode code;
		[Export("code", ArgumentSemantic.Assign)]
		MPRefundTransactionCode Code { get; }

		// @property (readonly, assign, nonatomic) int status;
		[Export("status")]
		int Status { get; }

		// @property (readonly, nonatomic, strong) MPStatusDetails * _Nullable statusDetails;
		[NullAllowed, Export("statusDetails", ArgumentSemantic.Strong)]
		MPStatusDetails StatusDetails { get; }
	}

	// @interface MPShopperDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPShopperDetails
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable email;
		[NullAllowed, Export("email", ArgumentSemantic.Strong)]
		string Email { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable identifier;
		[NullAllowed, Export("identifier", ArgumentSemantic.Strong)]
		string Identifier { get; }
	}

	// @interface MPTransactionActionSupport : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionActionSupport
	{
	}

	// @interface MPTransactionActionResponse : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionActionResponse
	{
	}

	// @interface MPTransactionActionResponseFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionActionResponseFactory
	{
		// -(MPTransactionActionResponse * _Nonnull)responseForCustomerSignatureWithResult:(BOOL)signatureVerified signature:(UIImage * _Nonnull)signature;
		[Export("responseForCustomerSignatureWithResult:signature:")]
		MPTransactionActionResponse ResponseForCustomerSignatureWithResult(bool signatureVerified, UIImage signature);

		// -(MPTransactionActionResponse * _Nonnull)responseForCustomerSignatureOnReceipt;
		[Export("responseForCustomerSignatureOnReceipt")]
		//[Verify (MethodToProperty)]
		MPTransactionActionResponse ResponseForCustomerSignatureOnReceipt { get; }

		// -(MPTransactionActionResponse * _Nonnull)responseForCustomerIdentificationWithResult:(BOOL)customerVerified;
		[Export("responseForCustomerIdentificationWithResult:")]
		MPTransactionActionResponse ResponseForCustomerIdentificationWithResult(bool customerVerified);

		// -(MPTransactionActionResponse * _Nonnull)responseForApplicationSelectionWithApplication:(MPApplicationInformation * _Nonnull)application;
		[Export("responseForApplicationSelectionWithApplication:")]
		MPTransactionActionResponse ResponseForApplicationSelectionWithApplication(MPApplicationInformation application);
	}

	// @interface MPAccessoryDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryDetails
	{
		// @property (readonly, nonatomic, strong) NSString * _Nullable serialNumber;
		[NullAllowed, Export("serialNumber", ArgumentSemantic.Strong)]
		string SerialNumber { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable osVersion;
		[NullAllowed, Export("osVersion", ArgumentSemantic.Strong)]
		string OsVersion { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable softwareVersion;
		[NullAllowed, Export("softwareVersion", ArgumentSemantic.Strong)]
		string SoftwareVersion { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable type;
		[NullAllowed, Export("type", ArgumentSemantic.Strong)]
		string Type { get; }
	}

	// typedef void (^MPPaymentAccessoryDisplayTextSuccess)(MPAccessory * _Nonnull, NSArray * _Nonnull);
	delegate void MPPaymentAccessoryDisplayTextSuccess(MPAccessory arg0, NSObject[] arg1);

	// typedef void (^MPPaymentAccessoryDisplayTextFailure)(MPAccessory * _Nonnull, NSArray * _Nonnull, NSError * _Nonnull);
	delegate void MPPaymentAccessoryDisplayTextFailure(MPAccessory arg0, NSObject[] arg1, NSError arg2);

	// typedef void (^MPPaymentAccessoryDisplayIdleScreenSuccess)(MPAccessory * _Nonnull);
	delegate void MPPaymentAccessoryDisplayIdleScreenSuccess(MPAccessory arg0);

	// typedef void (^MPPaymentAccessoryDisplayIdleScreenFailure)(MPAccessory * _Nonnull, NSError * _Nonnull);
	delegate void MPPaymentAccessoryDisplayIdleScreenFailure(MPAccessory arg0, NSError arg1);

	// @interface MPPaymentAccessory : MPAccessory
	[BaseType(typeof(MPAccessory))]
	interface MPPaymentAccessory
	{
		// @property (readonly, assign, nonatomic) int locale;
		[Export("locale")]
		int Locale { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull idleScreenText;
		[Export("idleScreenText", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] IdleScreenText { get; }

		// @property (readonly, assign, nonatomic) MPPaymentAccessoryFeature features;
		[Export("features", ArgumentSemantic.Assign)]
		MPPaymentAccessoryFeature Features { get; }

		// @property (readonly, assign, nonatomic) MPPaymentAccessoryRequirement requirements;
		[Export("requirements", ArgumentSemantic.Assign)]
		MPPaymentAccessoryRequirement Requirements { get; }

		// -(void)displayText:(NSArray * _Nonnull)text success:(MPPaymentAccessoryDisplayTextSuccess _Nonnull)success failure:(MPPaymentAccessoryDisplayTextFailure _Nonnull)failure __attribute__((deprecated("Use MPAccessoryComponentInteraction.")));
		[Export("displayText:success:failure:")]
		//[Verify (StronglyTypedNSArray)]
		void DisplayText(NSObject[] text, MPPaymentAccessoryDisplayTextSuccess success, MPPaymentAccessoryDisplayTextFailure failure);

		// -(void)displayIdleScreenWithSuccess:(MPPaymentAccessoryDisplayIdleScreenSuccess _Nonnull)success failure:(MPPaymentAccessoryDisplayIdleScreenFailure _Nonnull)failure __attribute__((deprecated("Use MPAccessoryComponentInteraction.")));
		[Export("displayIdleScreenWithSuccess:failure:")]
		void DisplayIdleScreenWithSuccess(MPPaymentAccessoryDisplayIdleScreenSuccess success, MPPaymentAccessoryDisplayIdleScreenFailure failure);
	}

	// @interface MPAccessoryUpdateRequirement : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryUpdateRequirement
	{
		// @property (readonly, assign, nonatomic) MPAccessoryUpdateRequirementStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		MPAccessoryUpdateRequirementStatus Status { get; }

		// @property (readonly, assign, nonatomic) MPAccessoryUpdateRequirementComponent affectedComponents;
		[Export("affectedComponents", ArgumentSemantic.Assign)]
		MPAccessoryUpdateRequirementComponent AffectedComponents { get; }
	}

	// @interface MPAbstractTransactionActionSupportWrapper : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAbstractTransactionActionSupportWrapper
	{
		// +(instancetype _Nonnull)wrapAround:(MPTransactionActionSupport * _Nonnull)wrappedSupport;
		[Static]
		[Export("wrapAround:")]
		MPAbstractTransactionActionSupportWrapper WrapAround(MPTransactionActionSupport wrappedSupport);
	}

	// @interface MPTransactionActionApplicationSelectionSupportWrapper : MPAbstractTransactionActionSupportWrapper
	[BaseType(typeof(MPAbstractTransactionActionSupportWrapper))]
	interface MPTransactionActionApplicationSelectionSupportWrapper
	{
		// @property (readonly, nonatomic, strong) NSArray * _Nonnull text;
		[Export("text", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Text { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull applications;
		[Export("applications", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Applications { get; }
	}

	// @protocol MPProviderComponentDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPProviderComponentDelegate
	{
		// @optional -(void)accessory:(MPAccessory * _Nonnull)accessory didChangeState:(id)state;
		[Export("accessory:didChangeState:")]
		void Accessory(MPAccessory accessory, NSObject state);

		// @optional -(void)transaction:(MPTransaction * _Nonnull)transaction didChangeState:(id)state abortable:(BOOL)abortable;
		[Export("transaction:didChangeState:abortable:")]
		void Transaction(MPTransaction transaction, NSObject state, bool abortable);

		// @optional -(void)provider:(MPProvider * _Nonnull)provider didRequestDisplayUpdateForType:(MPProviderComponentDelegateDisplayUpdateType)type text:(NSArray * _Nonnull)text support:(MPDisplayUpdateSupport * _Nonnull)support;
		//[Export ("provider:didRequestDisplayUpdateForType:text:support:")]
		//[Verify (StronglyTypedNSArray)]
		//void Provider (MPProvider provider, MPProviderComponentDelegateDisplayUpdateType type, NSObject[] text, MPDisplayUpdateSupport support);
	}

	// @protocol MPAccessoryComponentDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentDelegate
	{
		// @optional -(void)accessory:(MPAccessory * _Nonnull)accessory didChangeBatteryState:(id)state level:(NSInteger)level;
		[Export("accessory:didChangeBatteryState:level:")]
		void DidChangeBatteryState(MPAccessory accessory, NSObject state, int level);

		// @optional -(void)accessory:(MPAccessory * _Nonnull)accessory didEmitCardEvent:(MPAccessoryCardEvent)event;
		[Export("accessory:didEmitCardEvent:")]
		void DidEmitCardEvent(MPAccessory accessory, MPAccessoryCardEvent @event);

		// @optional -(void)accessory:(MPAccessory * _Nonnull)accessory didEmitKeyEvent:(MPAccessoryKeyEvent)event;
		[Export("accessory:didEmitKeyEvent:")]
		void DidEmitKeyEvent(MPAccessory accessory, MPAccessoryKeyEvent @event);
	}

	// @interface MPAbstractDisplayUpdateSupportWrapper : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAbstractDisplayUpdateSupportWrapper
	{
		// +(instancetype _Nonnull)wrapAround:(MPDisplayUpdateSupport * _Nonnull)support;
		//[Static]
		//[Export ("wrapAround:")]
		//MPAbstractDisplayUpdateSupportWrapper WrapAround (MPDisplayUpdateSupport support);
	}

	// @interface MPPINInformation : NSObject
	[BaseType(typeof(NSObject))]
	interface MPPINInformation
	{
		// @property (readonly, assign, nonatomic) MPPINInformationStatus status;
		[Export("status", ArgumentSemantic.Assign)]
		MPPINInformationStatus Status { get; }

		// @property (readonly, assign, nonatomic) NSInteger digits;
		[Export("digits")]
		int Digits { get; }
	}

	// @interface MPPINDisplayUpdateSupportWrapper : MPAbstractDisplayUpdateSupportWrapper
	[BaseType(typeof(MPAbstractDisplayUpdateSupportWrapper))]
	interface MPPINDisplayUpdateSupportWrapper
	{
		// @property (readonly, nonatomic, strong) MPPINInformation * _Nonnull information;
		[Export("information", ArgumentSemantic.Strong)]
		MPPINInformation Information { get; }
	}

	// @interface MPAccessoryComponent : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponent
	{
		// -(BOOL)isBusy;
		[Export("isBusy")]
		//[Verify (MethodToProperty)]
		bool IsBusy { get; }

		// -(void)abort;
		[Export("abort")]
		void Abort();
	}

	// typedef void (^MPAccessoryComponentPrinterPrintSuccess)(MPAccessoryComponentPrinter * _Nonnull, MPReceipt * _Nonnull);
	delegate void MPAccessoryComponentPrinterPrintSuccess(MPAccessoryComponentPrinter arg0, MPReceipt arg1);

	// typedef void (^MPAccessoryComponentPrinterPrintFailure)(MPAccessoryComponentPrinter * _Nonnull, MPReceipt * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentPrinterPrintFailure(MPAccessoryComponentPrinter arg0, MPReceipt arg1, NSError arg2);

	// @interface MPAccessoryComponentPrinter : MPAccessoryComponent
	[BaseType(typeof(MPAccessoryComponent))]
	interface MPAccessoryComponentPrinter
	{
		// @property (readonly, assign, nonatomic) MPAccessoryComponentPrinterState state;
		[Export("state", ArgumentSemantic.Assign)]
		MPAccessoryComponentPrinterState State { get; }

		// -(void)printReceipt:(MPReceipt * _Nonnull)receipt success:(MPAccessoryComponentPrinterPrintSuccess _Nonnull)success failure:(MPAccessoryComponentPrinterPrintFailure _Nonnull)failure;
		[Export("printReceipt:success:failure:")]
		void PrintReceipt(MPReceipt receipt, MPAccessoryComponentPrinterPrintSuccess success, MPAccessoryComponentPrinterPrintFailure failure);
	}

	// typedef void (^MPAccessoryComponentLogDownloadLogSuccess)(MPAccessoryComponentLog * _Nonnull, NSData * _Nonnull);
	delegate void MPAccessoryComponentLogDownloadLogSuccess(MPAccessoryComponentLog arg0, NSData arg1);

	// typedef void (^MPAccessoryComponentLogDownloadLogFailure)(MPAccessoryComponentLog * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentLogDownloadLogFailure(MPAccessoryComponentLog arg0, NSError arg1);

	// typedef void (^MPAccessoryComponentLogDeleteLogSuccess)(MPAccessoryComponentLog * _Nonnull);
	delegate void MPAccessoryComponentLogDeleteLogSuccess(MPAccessoryComponentLog arg0);

	// typedef void (^MPAccessoryComponentLogDeleteLogFailure)(MPAccessoryComponentLog * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentLogDeleteLogFailure(MPAccessoryComponentLog arg0, NSError arg1);

	// @interface MPAccessoryComponentLog : MPAccessoryComponent
	[BaseType(typeof(MPAccessoryComponent))]
	interface MPAccessoryComponentLog
	{
		// -(void)downloadLogWithSuccess:(MPAccessoryComponentLogDownloadLogSuccess _Nonnull)success failure:(MPAccessoryComponentLogDownloadLogFailure _Nonnull)failure;
		[Export("downloadLogWithSuccess:failure:")]
		void DownloadLogWithSuccess(MPAccessoryComponentLogDownloadLogSuccess success, MPAccessoryComponentLogDownloadLogFailure failure);

		// -(void)deleteLogWithSuccess:(MPAccessoryComponentLogDeleteLogSuccess _Nonnull)success failure:(MPAccessoryComponentLogDeleteLogFailure _Nonnull)failure;
		[Export("deleteLogWithSuccess:failure:")]
		void DeleteLogWithSuccess(MPAccessoryComponentLogDeleteLogSuccess success, MPAccessoryComponentLogDeleteLogFailure failure);
	}

	// @interface MPAccessoryComponentBarcodeScannerConfiguration : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentBarcodeScannerConfiguration
	{
		// @property (assign, nonatomic) MPAccessoryComponentBarcodeScannerConfigurationTriggerMode triggerMode;
		[Export("triggerMode", ArgumentSemantic.Assign)]
		MPAccessoryComponentBarcodeScannerConfigurationTriggerMode TriggerMode { get; set; }

		// @property (assign, nonatomic) MPAccessoryComponentBarcodeScannerConfigurationScanMode scanMode;
		[Export("scanMode", ArgumentSemantic.Assign)]
		MPAccessoryComponentBarcodeScannerConfigurationScanMode ScanMode { get; set; }

		// @property (assign, nonatomic) MPAccessoryComponentBarcodeScannerConfigurationContinuousMode continuousMode;
		[Export("continuousMode", ArgumentSemantic.Assign)]
		MPAccessoryComponentBarcodeScannerConfigurationContinuousMode ContinuousMode { get; set; }
	}

	// @interface MPAccessoryComponentBarcodeScannerData : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentBarcodeScannerData
	{
		// @property (assign, nonatomic) MPAccessoryComponentBarcodeScannerConfigurationBarcodeType type;
		[Export("type", ArgumentSemantic.Assign)]
		MPAccessoryComponentBarcodeScannerConfigurationBarcodeType Type { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable barcode;
		[NullAllowed, Export("barcode", ArgumentSemantic.Strong)]
		string Barcode { get; set; }

		// @property (nonatomic, strong) NSData * _Nonnull rawResponse;
		[Export("rawResponse", ArgumentSemantic.Strong)]
		NSData RawResponse { get; set; }

		// @property (nonatomic, strong) NSData * _Nonnull rawBarcode;
		[Export("rawBarcode", ArgumentSemantic.Strong)]
		NSData RawBarcode { get; set; }
	}

	// typedef void (^MPAccessoryComponentBarcodeScannerStartScanSuccess)(MPAccessoryComponentBarcodeScanner * _Nonnull);
	delegate void MPAccessoryComponentBarcodeScannerStartScanSuccess(MPAccessoryComponentBarcodeScanner arg0);

	// typedef void (^MPAccessoryComponentBarcodeScannerStartScanScan)(MPAccessoryComponentBarcodeScanner * _Nonnull, MPAccessoryComponentBarcodeScannerData * _Nonnull);
	delegate void MPAccessoryComponentBarcodeScannerStartScanScan(MPAccessoryComponentBarcodeScanner arg0, MPAccessoryComponentBarcodeScannerData arg1);

	// typedef void (^MPAccessoryComponentBarcodeScannerStartScanButton)(MPAccessoryComponentBarcodeScanner * _Nonnull, NSUInteger);
	delegate void MPAccessoryComponentBarcodeScannerStartScanButton(MPAccessoryComponentBarcodeScanner arg0, uint arg1);

	// typedef void (^MPAccessoryComponentBarcodeScannerStartScanAbort)(MPAccessoryComponentBarcodeScanner * _Nonnull);
	delegate void MPAccessoryComponentBarcodeScannerStartScanAbort(MPAccessoryComponentBarcodeScanner arg0);

	// typedef void (^MPAccessoryComponentBarcodeScannerStartScanFailure)(MPAccessoryComponentBarcodeScanner * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentBarcodeScannerStartScanFailure(MPAccessoryComponentBarcodeScanner arg0, NSError arg1);

	// typedef void (^MPAccessoryComponentBarcodeScannerStopScanSuccess)(MPAccessoryComponentBarcodeScanner * _Nonnull);
	delegate void MPAccessoryComponentBarcodeScannerStopScanSuccess(MPAccessoryComponentBarcodeScanner arg0);

	// typedef void (^MPAccessoryComponentBarcodeScannerStopScanFailure)(MPAccessoryComponentBarcodeScanner * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentBarcodeScannerStopScanFailure(MPAccessoryComponentBarcodeScanner arg0, NSError arg1);

	// @interface MPAccessoryComponentBarcodeScanner : MPAccessoryComponent
	[BaseType(typeof(MPAccessoryComponent))]
	interface MPAccessoryComponentBarcodeScanner
	{
		// -(void)startScanWithConfiguration:(MPAccessoryComponentBarcodeScannerConfiguration * _Nullable)configuration success:(MPAccessoryComponentBarcodeScannerStartScanSuccess _Nonnull)success scan:(MPAccessoryComponentBarcodeScannerStartScanScan _Nonnull)scan button:(MPAccessoryComponentBarcodeScannerStartScanButton _Nonnull)button failure:(MPAccessoryComponentBarcodeScannerStartScanFailure _Nonnull)failure __attribute__((deprecated("Use the startScanWithConfiguration:success:scan:button:abort:failure: method")));
		[Export("startScanWithConfiguration:success:scan:button:failure:")]
		void StartScanWithConfiguration([NullAllowed] MPAccessoryComponentBarcodeScannerConfiguration configuration, MPAccessoryComponentBarcodeScannerStartScanSuccess success, MPAccessoryComponentBarcodeScannerStartScanScan scan, MPAccessoryComponentBarcodeScannerStartScanButton button, MPAccessoryComponentBarcodeScannerStartScanFailure failure);

		// -(void)startScanWithSuccess:(MPAccessoryComponentBarcodeScannerStartScanSuccess _Nonnull)success scan:(MPAccessoryComponentBarcodeScannerStartScanScan _Nonnull)scan button:(MPAccessoryComponentBarcodeScannerStartScanButton _Nonnull)button failure:(MPAccessoryComponentBarcodeScannerStartScanFailure _Nonnull)failure __attribute__((deprecated("Use the startScanWithSuccess:scan:button:abort:failure: method")));
		[Export("startScanWithSuccess:scan:button:failure:")]
		void StartScanWithSuccess(MPAccessoryComponentBarcodeScannerStartScanSuccess success, MPAccessoryComponentBarcodeScannerStartScanScan scan, MPAccessoryComponentBarcodeScannerStartScanButton button, MPAccessoryComponentBarcodeScannerStartScanFailure failure);

		// -(void)startScanWithConfiguration:(MPAccessoryComponentBarcodeScannerConfiguration * _Nullable)configuration success:(MPAccessoryComponentBarcodeScannerStartScanSuccess _Nonnull)success scan:(MPAccessoryComponentBarcodeScannerStartScanScan _Nonnull)scan button:(MPAccessoryComponentBarcodeScannerStartScanButton _Nonnull)button abort:(MPAccessoryComponentBarcodeScannerStartScanAbort _Nonnull)abort failure:(MPAccessoryComponentBarcodeScannerStartScanFailure _Nonnull)failure;
		[Export("startScanWithConfiguration:success:scan:button:abort:failure:")]
		void StartScanWithConfiguration([NullAllowed] MPAccessoryComponentBarcodeScannerConfiguration configuration, MPAccessoryComponentBarcodeScannerStartScanSuccess success, MPAccessoryComponentBarcodeScannerStartScanScan scan, MPAccessoryComponentBarcodeScannerStartScanButton button, MPAccessoryComponentBarcodeScannerStartScanAbort abort, MPAccessoryComponentBarcodeScannerStartScanFailure failure);

		// -(void)startScanWithSuccess:(MPAccessoryComponentBarcodeScannerStartScanSuccess _Nonnull)success scan:(MPAccessoryComponentBarcodeScannerStartScanScan _Nonnull)scan button:(MPAccessoryComponentBarcodeScannerStartScanButton _Nonnull)button abort:(MPAccessoryComponentBarcodeScannerStartScanAbort _Nonnull)abort failure:(MPAccessoryComponentBarcodeScannerStartScanFailure _Nonnull)failure;
		[Export("startScanWithSuccess:scan:button:abort:failure:")]
		void StartScanWithSuccess(MPAccessoryComponentBarcodeScannerStartScanSuccess success, MPAccessoryComponentBarcodeScannerStartScanScan scan, MPAccessoryComponentBarcodeScannerStartScanButton button, MPAccessoryComponentBarcodeScannerStartScanAbort abort, MPAccessoryComponentBarcodeScannerStartScanFailure failure);

		// -(void)stopScanWithSuccess:(MPAccessoryComponentBarcodeScannerStopScanSuccess _Nonnull)success failure:(MPAccessoryComponentBarcodeScannerStopScanFailure _Nonnull)failure __attribute__((deprecated("Use the abort method")));
		[Export("stopScanWithSuccess:failure:")]
		void StopScanWithSuccess(MPAccessoryComponentBarcodeScannerStopScanSuccess success, MPAccessoryComponentBarcodeScannerStopScanFailure failure);
	}

	// typedef void (^MPAccessoryComponentTippingSuccess)(BOOL, NSDecimalNumber * _Nullable);
	delegate void MPAccessoryComponentTippingSuccess(bool arg0, [NullAllowed] NSDecimalNumber arg1);

	// typedef void (^MPAccessoryComponentTippingFailure)(NSError * _Nonnull);
	delegate void MPAccessoryComponentTippingFailure(NSError arg0);

	// typedef void (^MPAccessoryComponentTippingAskForTipSuccess)(MPAccessoryComponentTipping * _Nonnull, NSDecimalNumber * _Nonnull);
	delegate void MPAccessoryComponentTippingAskForTipSuccess(MPAccessoryComponentTipping arg0, NSDecimalNumber arg1);

	// typedef void (^MPAccessoryComponentTippingAskForTipFailure)(MPAccessoryComponentTipping * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentTippingAskForTipFailure(MPAccessoryComponentTipping arg0, NSError arg1);

	// typedef void (^MPAccessoryComponentTippingAskForTipAbort)(MPAccessoryComponentTipping * _Nonnull);
	delegate void MPAccessoryComponentTippingAskForTipAbort(MPAccessoryComponentTipping arg0);

	// @interface MPAccessoryComponentTipping : MPAccessoryComponent
	[BaseType(typeof(MPAccessoryComponent))]
	interface MPAccessoryComponentTipping
	{
		// -(void)askForTipForAmount:(NSDecimalNumber * _Nonnull)transactionAmmount currency:(id)currency suggestedTip:(NSDecimalNumber * _Nullable)suggestedTip success:(MPAccessoryComponentTippingSuccess _Nonnull)success failure:(MPAccessoryComponentTippingFailure _Nonnull)failure __attribute__((deprecated("")));
		[Export("askForTipForAmount:currency:suggestedTip:success:failure:")]
		void AskForTipForAmount(NSDecimalNumber transactionAmmount, NSObject currency, [NullAllowed] NSDecimalNumber suggestedTip, MPAccessoryComponentTippingSuccess success, MPAccessoryComponentTippingFailure failure);

		// -(void)askForTipForAmount:(NSDecimalNumber * _Nonnull)transactionAmmount currency:(id)currency suggestedTip:(NSDecimalNumber * _Nullable)suggestedTip success:(MPAccessoryComponentTippingAskForTipSuccess _Nonnull)success abort:(MPAccessoryComponentTippingAskForTipAbort _Nonnull)abort failure:(MPAccessoryComponentTippingAskForTipFailure _Nonnull)failure;
		[Export("askForTipForAmount:currency:suggestedTip:success:abort:failure:")]
		void AskForTipForAmount(NSDecimalNumber transactionAmmount, NSObject currency, [NullAllowed] NSDecimalNumber suggestedTip, MPAccessoryComponentTippingAskForTipSuccess success, MPAccessoryComponentTippingAskForTipAbort abort, MPAccessoryComponentTippingAskForTipFailure failure);
	}

	// @protocol MPAccessoryComponentInteractionAskForNumberOptionals <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentInteractionAskForNumberOptionals
	{
		// @required -(void)setFormatWithIntegerDigits:(NSUInteger)integerDigits fractionDigits:(NSUInteger)fractionDigits;
		[Abstract]
		[Export("setFormatWithIntegerDigits:fractionDigits:")]
		void SetFormatWithIntegerDigits(uint integerDigits, uint fractionDigits);

		// @required -(void)setAutoConfirm:(BOOL)autoConfirm;
		[Abstract]
		[Export("setAutoConfirm:")]
		void SetAutoConfirm(bool autoConfirm);

		// @required -(void)setDefaultNumber:(NSDecimalNumber * _Nonnull)defaultNumber;
		[Abstract]
		[Export("setDefaultNumber:")]
		void SetDefaultNumber(NSDecimalNumber defaultNumber);

		// @required -(void)setDisplayAmount:(NSDecimalNumber * _Nonnull)amount currency:(id)currency;
		[Abstract]
		[Export("setDisplayAmount:currency:")]
		void SetDisplayAmount(NSDecimalNumber amount, NSObject currency);

		// @required -(void)setShowIdleScreen:(BOOL)showIdleScreen;
		[Abstract]
		[Export("setShowIdleScreen:")]
		void SetShowIdleScreen(bool showIdleScreen);
	}

	// typedef void (^MPAccessoryComponentInteractionAskForNumberOptionals)(id<MPAccessoryComponentInteractionAskForNumberOptionals> _Nonnull);
	delegate void MPAccessoryComponentInteractionAskForNumberOptionalsY(MPAccessoryComponentInteractionAskForNumberOptionals arg0);

	// @interface MPAccessoryComponentInteractionAskForNumberParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentInteractionAskForNumberParameters
	{
		// +(instancetype _Nonnull)parametersWithPrompt:(MPAccessoryComponentInteractionPrompt)prompt optionals:(MPAccessoryComponentInteractionAskForNumberOptionals _Nullable)optionalsBlock;
		[Static]
		[Export("parametersWithPrompt:optionals:")]
		MPAccessoryComponentInteractionAskForNumberParameters ParametersWithPrompt(MPAccessoryComponentInteractionPrompt prompt, [NullAllowed] MPAccessoryComponentInteractionAskForNumberOptionals optionalsBlock);

		// +(instancetype _Nonnull)parametersWithPromptIndexes:(NSArray * _Nonnull)promptIndexes optionals:(MPAccessoryComponentInteractionAskForNumberOptionals _Nullable)optionalsBlock;
		[Static]
		[Export("parametersWithPromptIndexes:optionals:")]
		//[Verify (StronglyTypedNSArray)]
		MPAccessoryComponentInteractionAskForNumberParameters ParametersWithPromptIndexes(NSObject[] promptIndexes, [NullAllowed] MPAccessoryComponentInteractionAskForNumberOptionals optionalsBlock);
	}

	// @protocol MPAccessoryComponentInteractionAskForConfirmationParametersOptionals <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentInteractionAskForConfirmationParametersOptionals
	{
		// @required -(void)setCenterText:(BOOL)centered;
		[Abstract]
		[Export("setCenterText:")]
		void SetCenterText(bool centered);

		// @required -(void)setShowIdleScreen:(BOOL)showIdleScreen;
		[Abstract]
		[Export("setShowIdleScreen:")]
		void SetShowIdleScreen(bool showIdleScreen);

		// @required -(void)setConfirmationKeys:(MPAccessoryComponentInteractionConfirmationKey)keys;
		[Abstract]
		[Export("setConfirmationKeys:")]
		void SetConfirmationKeys(MPAccessoryComponentInteractionConfirmationKey keys);
	}

	// typedef void (^MPAccessoryComponentInteractionAskForConfirmationParametersOptionals)(id<MPAccessoryComponentInteractionAskForConfirmationParametersOptionals> _Nonnull);
	delegate void MPAccessoryComponentInteractionAskForConfirmationParametersOptionalsX(MPAccessoryComponentInteractionAskForConfirmationParametersOptionals arg0);

	// @interface MPAccessoryComponentInteractionAskForConfirmationParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryComponentInteractionAskForConfirmationParameters
	{
		// +(instancetype _Nonnull)parametersWithText:(NSArray * _Nonnull)text optionals:(MPAccessoryComponentInteractionAskForConfirmationParametersOptionals _Nullable)optionalsBlock;
		[Static]
		[Export("parametersWithText:optionals:")]
		//[Verify (StronglyTypedNSArray)]
		MPAccessoryComponentInteractionAskForConfirmationParameters ParametersWithText(NSObject[] text, [NullAllowed] MPAccessoryComponentInteractionAskForConfirmationParametersOptionals optionalsBlock);
	}

	// typedef void (^MPAccessoryComponentInteractionConfirmationSuccess)(MPAccessoryComponentInteraction * _Nonnull, MPAccessoryComponentInteractionConfirmationKey);
	delegate void MPAccessoryComponentInteractionConfirmationSuccess(MPAccessoryComponentInteraction arg0, MPAccessoryComponentInteractionConfirmationKey arg1);

	// typedef void (^MPAccessoryComponentInteractionConfirmationFailure)(MPAccessoryComponentInteraction * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentInteractionConfirmationFailure(MPAccessoryComponentInteraction arg0, NSError arg1);

	// typedef void (^MPAccessoryComponentInteractionConfirmationAbort)(MPAccessoryComponentInteraction * _Nonnull);
	delegate void MPAccessoryComponentInteractionConfirmationAbort(MPAccessoryComponentInteraction arg0);

	// typedef void (^MPAccessoryComponentInteractionAskForNumberSuccess)(MPAccessoryComponentInteraction * _Nonnull, NSString * _Nonnull);
	delegate void MPAccessoryComponentInteractionAskForNumberSuccess(MPAccessoryComponentInteraction arg0, string arg1);

	// typedef void (^MPAccessoryComponentInteractionAskForNumberFailure)(MPAccessoryComponentInteraction * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentInteractionAskForNumberFailure(MPAccessoryComponentInteraction arg0, NSError arg1);

	// typedef void (^MPAccessoryComponentInteractionAskForNumberAbort)(MPAccessoryComponentInteraction * _Nonnull);
	delegate void MPAccessoryComponentInteractionAskForNumberAbort(MPAccessoryComponentInteraction arg0);

	// typedef void (^MPAccessoryComponentInteractionDisplayTextSuccess)(MPAccessoryComponentInteraction * _Nonnull);
	delegate void MPAccessoryComponentInteractionDisplayTextSuccess(MPAccessoryComponentInteraction arg0);

	// typedef void (^MPAccessoryComponentInteractionDisplayTextFailure)(MPAccessoryComponentInteraction * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentInteractionDisplayTextFailure(MPAccessoryComponentInteraction arg0, NSError arg1);

	// typedef void (^MPAccessoryComponentInteractionDisplayIdleScreenSuccess)(MPAccessoryComponentInteraction * _Nonnull);
	delegate void MPAccessoryComponentInteractionDisplayIdleScreenSuccess(MPAccessoryComponentInteraction arg0);

	// typedef void (^MPAccessoryComponentInteractionDisplayIdleScreenFailure)(MPAccessoryComponentInteraction * _Nonnull, NSError * _Nonnull);
	delegate void MPAccessoryComponentInteractionDisplayIdleScreenFailure(MPAccessoryComponentInteraction arg0, NSError arg1);

	// @interface MPAccessoryComponentInteraction : MPAccessoryComponent
	[BaseType(typeof(MPAccessoryComponent))]
	interface MPAccessoryComponentInteraction
	{
		// -(void)askForConfirmationWithParameters:(MPAccessoryComponentInteractionAskForConfirmationParameters * _Nonnull)params success:(MPAccessoryComponentInteractionConfirmationSuccess _Nonnull)success abort:(MPAccessoryComponentInteractionConfirmationAbort _Nonnull)abort failure:(MPAccessoryComponentInteractionConfirmationFailure _Nonnull)failure;
		[Export("askForConfirmationWithParameters:success:abort:failure:")]
		void AskForConfirmationWithParameters(MPAccessoryComponentInteractionAskForConfirmationParameters @params, MPAccessoryComponentInteractionConfirmationSuccess success, MPAccessoryComponentInteractionConfirmationAbort abort, MPAccessoryComponentInteractionConfirmationFailure failure);

		// -(void)askForNumberWithParameters:(MPAccessoryComponentInteractionAskForNumberParameters * _Nonnull)params success:(MPAccessoryComponentInteractionAskForNumberSuccess _Nonnull)success abort:(MPAccessoryComponentInteractionAskForNumberAbort _Nonnull)abort failure:(MPAccessoryComponentInteractionAskForNumberFailure _Nonnull)failure;
		[Export("askForNumberWithParameters:success:abort:failure:")]
		void AskForNumberWithParameters(MPAccessoryComponentInteractionAskForNumberParameters @params, MPAccessoryComponentInteractionAskForNumberSuccess success, MPAccessoryComponentInteractionAskForNumberAbort abort, MPAccessoryComponentInteractionAskForNumberFailure failure);

		// -(void)displayText:(NSArray * _Nonnull)text success:(MPAccessoryComponentInteractionDisplayTextSuccess _Nonnull)success failure:(MPAccessoryComponentInteractionDisplayTextFailure _Nonnull)failure;
		[Export("displayText:success:failure:")]
		//[Verify (StronglyTypedNSArray)]
		void DisplayText(NSObject[] text, MPAccessoryComponentInteractionDisplayTextSuccess success, MPAccessoryComponentInteractionDisplayTextFailure failure);

		// -(void)displayIdleScreenSuccess:(MPAccessoryComponentInteractionDisplayIdleScreenSuccess _Nonnull)success failure:(MPAccessoryComponentInteractionDisplayIdleScreenFailure _Nonnull)failure;
		[Export("displayIdleScreenSuccess:failure:")]
		void DisplayIdleScreenSuccess(MPAccessoryComponentInteractionDisplayIdleScreenSuccess success, MPAccessoryComponentInteractionDisplayIdleScreenFailure failure);
	}

	// @interface MPApplicationInformation : NSObject
	[BaseType(typeof(NSObject))]
	interface MPApplicationInformation
	{
		// @property (readonly, nonatomic, strong) NSString * _Nonnull applicationIdentifier;
		[Export("applicationIdentifier", ArgumentSemantic.Strong)]
		string ApplicationIdentifier { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nonnull applicationName;
		[Export("applicationName", ArgumentSemantic.Strong)]
		string ApplicationName { get; }
	}

	// @interface MPPaymentDetailsFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface MPPaymentDetailsFactory
	{
		// -(MPPaymentDetails * _Nonnull)paymentDetails;
		[Export("paymentDetails")]
		//[Verify (MethodToProperty)]
		MPPaymentDetails PaymentDetails { get; }
	}

	// typedef void (^MPPrintingProcessStatusChanged)(MPPrintingProcess * _Nonnull, MPTransaction * _Nullable, MPPrintingProcessDetails * _Nonnull);
	delegate void MPPrintingProcessStatusChanged(MPPrintingProcess arg0, [NullAllowed] MPTransaction arg1, MPPrintingProcessDetails arg2);

	// typedef void (^MPPrintingProcessCompleted)(MPPrintingProcess * _Nonnull, MPTransaction * _Nullable, MPPrintingProcessDetails * _Nonnull);
	delegate void MPPrintingProcessCompleted(MPPrintingProcess arg0, [NullAllowed] MPTransaction arg1, MPPrintingProcessDetails arg2);

	// @interface MPPrintingProcess : NSObject
	[BaseType(typeof(NSObject))]
	interface MPPrintingProcess
	{
		// @property (readonly, nonatomic, strong) MPTransactionProvider * _Nullable provider;
		[NullAllowed, Export("provider", ArgumentSemantic.Strong)]
		MPTransactionProvider Provider { get; }

		// @property (readonly, nonatomic, strong) MPAccessory * _Nullable accessory;
		[NullAllowed, Export("accessory", ArgumentSemantic.Strong)]
		MPAccessory Accessory { get; }

		// @property (readonly, nonatomic, strong) MPPrintingProcessDetails * _Nonnull details;
		[Export("details", ArgumentSemantic.Strong)]
		MPPrintingProcessDetails Details { get; }

		// -(BOOL)requestAbort;
		[Export("requestAbort")]
		//[Verify (MethodToProperty)]
		bool RequestAbort { get; }

		// -(BOOL)canBeAborted;
		[Export("canBeAborted")]
		//[Verify (MethodToProperty)]
		bool CanBeAborted { get; }
	}

	// @interface MPPrintingProcessDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPPrintingProcessDetails
	{
		// @property (readonly, assign, nonatomic) MPPrintingProcessDetailsState state;
		[Export("state", ArgumentSemantic.Assign)]
		MPPrintingProcessDetailsState State { get; }

		// @property (readonly, assign, nonatomic) MPPrintingProcessDetailsStateDetails stateDetails;
		[Export("stateDetails", ArgumentSemantic.Assign)]
		MPPrintingProcessDetailsStateDetails StateDetails { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull information;
		[Export("information", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Information { get; }

		// @property (readonly, nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export("error", ArgumentSemantic.Strong)]
		NSError Error { get; }
	}

	// typedef void (^MPTransactionProcessRegistered)(MPTransactionProcess * _Nonnull, MPTransaction * _Nonnull);
	delegate void MPTransactionProcessRegistered(MPTransactionProcess arg0, MPTransaction arg1);

	// typedef void (^MPTransactionProcessStatusChanged)(MPTransactionProcess * _Nonnull, MPTransaction * _Nullable, MPTransactionProcessDetails * _Nonnull);
	delegate void MPTransactionProcessStatusChanged(MPTransactionProcess arg0, [NullAllowed] MPTransaction arg1, MPTransactionProcessDetails arg2);

	// typedef void (^MPTransactionProcessActionRequired)(MPTransactionProcess * _Nonnull, MPTransaction * _Nonnull, int, MPTransactionActionSupport * _Nullable);
	delegate void MPTransactionProcessActionRequired(MPTransactionProcess arg0, MPTransaction arg1, int arg2, [NullAllowed] MPTransactionActionSupport arg3);

	// typedef void (^MPTransactionProcessCompleted)(MPTransactionProcess * _Nonnull, MPTransaction * _Nullable, MPTransactionProcessDetails * _Nonnull);
	delegate void MPTransactionProcessCompleted(MPTransactionProcess arg0, [NullAllowed] MPTransaction arg1, MPTransactionProcessDetails arg2);

	// @interface MPTransactionProcess : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionProcess
	{
		// @property (readonly, nonatomic, strong) MPTransactionProvider * _Nullable provider;
		[NullAllowed, Export("provider", ArgumentSemantic.Strong)]
		MPTransactionProvider Provider { get; }

		// @property (readonly, nonatomic, strong) MPTransaction * _Nullable transaction;
		[NullAllowed, Export("transaction", ArgumentSemantic.Strong)]
		MPTransaction Transaction { get; }

		// @property (readonly, nonatomic, strong) MPAccessory * _Nullable accessory;
		[NullAllowed, Export("accessory", ArgumentSemantic.Strong)]
		MPAccessory Accessory { get; }

		// @property (readonly, nonatomic, strong) MPTransactionProcessDetails * _Nonnull details;
		[Export("details", ArgumentSemantic.Strong)]
		MPTransactionProcessDetails Details { get; }

		// -(void)continueWithCustomerSignature:(UIImage * _Nullable)signature verified:(BOOL)verified;
		[Export("continueWithCustomerSignature:verified:")]
		void ContinueWithCustomerSignature([NullAllowed] UIImage signature, bool verified);

		// -(void)continueWithCustomerSignatureOnReceipt;
		[Export("continueWithCustomerSignatureOnReceipt")]
		void ContinueWithCustomerSignatureOnReceipt();

		// -(void)continueWithCustomerIdentityVerified:(BOOL)verified;
		[Export("continueWithCustomerIdentityVerified:")]
		void ContinueWithCustomerIdentityVerified(bool verified);

		// -(void)continueWithSelectedApplication:(MPApplicationInformation * _Nonnull)application;
		[Export("continueWithSelectedApplication:")]
		void ContinueWithSelectedApplication(MPApplicationInformation application);

		// -(BOOL)requestAbort;
		[Export("requestAbort")]
		//[Verify (MethodToProperty)]
		bool RequestAbort { get; }

		// -(BOOL)canBeAborted;
		[Export("canBeAborted")]
		//[Verify (MethodToProperty)]
		bool CanBeAborted { get; }
	}

	// @interface MPTransactionProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionProvider
	{
		// @property (readonly, nonatomic, strong) MPLocalizationToolbox * _Nonnull localizationToolbox;
		[Export("localizationToolbox", ArgumentSemantic.Strong)]
		MPLocalizationToolbox LocalizationToolbox { get; }

		// @property (readonly, nonatomic, strong) MPTransactionModule * _Nonnull transactionModule;
		[Export("transactionModule", ArgumentSemantic.Strong)]
		MPTransactionModule TransactionModule { get; }

		// -(MPTransactionProcess * _Nonnull)startTransactionWithSessionIdentifier:(NSString * _Nonnull)sessionIdentifier accessoryParameters:(MPAccessoryParameters * _Nonnull)accessoryParameters statusChanged:(MPTransactionProcessStatusChanged _Nonnull)statusChanged actionRequired:(MPTransactionProcessActionRequired _Nonnull)actionRequired completed:(MPTransactionProcessCompleted _Nonnull)completed;
		[Export("startTransactionWithSessionIdentifier:accessoryParameters:statusChanged:actionRequired:completed:")]
		MPTransactionProcess StartTransactionWithSessionIdentifier(string sessionIdentifier, MPAccessoryParameters accessoryParameters, MPTransactionProcessStatusChanged statusChanged, MPTransactionProcessActionRequired actionRequired, MPTransactionProcessCompleted completed);

		// -(MPTransactionProcess * _Nonnull)startTransactionWithSessionIdentifier:(NSString * _Nonnull)sessionIdentifier accessoryParameters:(MPAccessoryParameters * _Nonnull)accessoryParameters processParameters:(MPTransactionProcessParameters * _Nonnull)processParameters statusChanged:(MPTransactionProcessStatusChanged _Nonnull)statusChanged actionRequired:(MPTransactionProcessActionRequired _Nonnull)actionRequired completed:(MPTransactionProcessCompleted _Nonnull)completed;
		[Export("startTransactionWithSessionIdentifier:accessoryParameters:processParameters:statusChanged:actionRequired:completed:")]
		MPTransactionProcess StartTransactionWithSessionIdentifier(string sessionIdentifier, MPAccessoryParameters accessoryParameters, MPTransactionProcessParameters processParameters, MPTransactionProcessStatusChanged statusChanged, MPTransactionProcessActionRequired actionRequired, MPTransactionProcessCompleted completed);

		// -(MPTransactionProcess * _Nonnull)startTransactionWithParameters:(MPTransactionParameters * _Nonnull)transactionParameters accessoryParameters:(MPAccessoryParameters * _Nonnull)accessoryParameters registered:(MPTransactionProcessRegistered _Nonnull)registered statusChanged:(MPTransactionProcessStatusChanged _Nonnull)statusChanged actionRequired:(MPTransactionProcessActionRequired _Nonnull)actionRequired completed:(MPTransactionProcessCompleted _Nonnull)completed;
		[Export("startTransactionWithParameters:accessoryParameters:registered:statusChanged:actionRequired:completed:")]
		MPTransactionProcess StartTransactionWithParameters(MPTransactionParameters transactionParameters, MPAccessoryParameters accessoryParameters, MPTransactionProcessRegistered registered, MPTransactionProcessStatusChanged statusChanged, MPTransactionProcessActionRequired actionRequired, MPTransactionProcessCompleted completed);

		// -(MPTransactionProcess * _Nonnull)startTransactionWithParameters:(MPTransactionParameters * _Nonnull)transactionParameters accessoryParameters:(MPAccessoryParameters * _Nonnull)accessoryParameters processParameters:(MPTransactionProcessParameters * _Nullable)processParameters registered:(MPTransactionProcessRegistered _Nonnull)registered statusChanged:(MPTransactionProcessStatusChanged _Nonnull)statusChanged actionRequired:(MPTransactionProcessActionRequired _Nonnull)actionRequired completed:(MPTransactionProcessCompleted _Nonnull)completed;
		[Export("startTransactionWithParameters:accessoryParameters:processParameters:registered:statusChanged:actionRequired:completed:")]
		MPTransactionProcess StartTransactionWithParameters(MPTransactionParameters transactionParameters, MPAccessoryParameters accessoryParameters, [NullAllowed] MPTransactionProcessParameters processParameters, MPTransactionProcessRegistered registered, MPTransactionProcessStatusChanged statusChanged, MPTransactionProcessActionRequired actionRequired, MPTransactionProcessCompleted completed);

		// -(MPTransactionProcess * _Nonnull)amendTransactionWithParameters:(MPTransactionParameters * _Nonnull)transactionParameters statusChanged:(MPTransactionProcessStatusChanged _Nonnull)statusChanged completed:(MPTransactionProcessCompleted _Nonnull)completed;
		[Export("amendTransactionWithParameters:statusChanged:completed:")]
		MPTransactionProcess AmendTransactionWithParameters(MPTransactionParameters transactionParameters, MPTransactionProcessStatusChanged statusChanged, MPTransactionProcessCompleted completed);

		// -(MPPrintingProcess * _Nonnull)printCustomerReceiptForTransactionIdentifier:(NSString * _Nonnull)transactionIdentifier accessoryParameters:(MPAccessoryParameters * _Nonnull)accessoryParameters statusChanged:(MPPrintingProcessStatusChanged _Nonnull)statusChanged completed:(MPPrintingProcessCompleted _Nonnull)completed;
		[Export("printCustomerReceiptForTransactionIdentifier:accessoryParameters:statusChanged:completed:")]
		MPPrintingProcess PrintCustomerReceiptForTransactionIdentifier(string transactionIdentifier, MPAccessoryParameters accessoryParameters, MPPrintingProcessStatusChanged statusChanged, MPPrintingProcessCompleted completed);
	}

	// @interface MPTransactionProcessDetails : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionProcessDetails
	{
		// @property (readonly, assign, nonatomic) MPTransactionProcessDetailsState state;
		[Export("state", ArgumentSemantic.Assign)]
		MPTransactionProcessDetailsState State { get; }

		// @property (readonly, assign, nonatomic) MPTransactionProcessDetailsStateDetails stateDetails;
		[Export("stateDetails", ArgumentSemantic.Assign)]
		MPTransactionProcessDetailsStateDetails StateDetails { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nonnull information;
		[Export("information", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] Information { get; }

		// @property (readonly, nonatomic, strong) NSError * _Nullable error;
		[NullAllowed, Export("error", ArgumentSemantic.Strong)]
		NSError Error { get; }
	}

	// @protocol MPTransactionParametersOptionals <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPTransactionParametersOptionals
	{
		// @required @property (nonatomic) NSString * _Nullable subject;
		[Abstract]
		[NullAllowed, Export("subject")]
		string Subject { get; set; }

		// @required @property (nonatomic) NSString * _Nullable customIdentifier;
		[Abstract]
		[NullAllowed, Export("customIdentifier")]
		string CustomIdentifier { get; set; }

		// @required @property (nonatomic) NSString * _Nullable statementDescriptor;
		[Abstract]
		[NullAllowed, Export("statementDescriptor")]
		string StatementDescriptor { get; set; }

		// @required @property (nonatomic) NSDecimalNumber * _Nullable applicationFee;
		[Abstract]
		[NullAllowed, Export("applicationFee", ArgumentSemantic.Assign)]
		NSDecimalNumber ApplicationFee { get; set; }

		// @required @property (nonatomic) NSDecimalNumber * _Nullable includedTipAmount;
		[Abstract]
		[NullAllowed, Export("includedTipAmount", ArgumentSemantic.Assign)]
		NSDecimalNumber IncludedTipAmount { get; set; }

		// @required @property (nonatomic) NSDictionary * _Nullable metadata;
		[Abstract]
		[NullAllowed, Export("metadata", ArgumentSemantic.Assign)]
		NSDictionary Metadata { get; set; }

		// @required @property (nonatomic) BOOL autoCapture;
		[Abstract]
		[Export("autoCapture")]
		bool AutoCapture { get; set; }
	}

	// @protocol MPTransactionParametersRefundOptionals <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPTransactionParametersRefundOptionals
	{
		// @required @property (nonatomic) NSString * _Nullable subject;
		[Abstract]
		[NullAllowed, Export("subject")]
		string Subject { get; set; }

		// @required @property (nonatomic) NSString * _Nullable customIdentifier;
		[Abstract]
		[NullAllowed, Export("customIdentifier")]
		string CustomIdentifier { get; set; }

		// @required -(void)setAmount:(NSDecimalNumber * _Nonnull)amount currency:(id)currency;
		[Abstract]
		[Export("setAmount:currency:")]
		void Currency(NSDecimalNumber amount, NSObject currency);
	}

	// @protocol MPTransactionParametersCaptureOptionals <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPTransactionParametersCaptureOptionals
	{
		// @required -(void)setAmount:(NSDecimalNumber * _Nonnull)amount currency:(id)currency;
		[Abstract]
		[Export("setAmount:currency:")]
		void Currency(NSDecimalNumber amount, NSObject currency);
	}

	// typedef void (^MPTransactionParametersOptionalsBlock)(id<MPTransactionParametersOptionals> _Nonnull);
	delegate void MPTransactionParametersOptionalsBlock(MPTransactionParametersOptionals arg0);

	// typedef void (^MPTransactionParametersRefundOptionalsBlock)(id<MPTransactionParametersRefundOptionals> _Nonnull);
	delegate void MPTransactionParametersRefundOptionalsBlock(MPTransactionParametersRefundOptionals arg0);

	// typedef void (^MPTransactionParametersCaptureOptionalsBlock)(id<MPTransactionParametersCaptureOptionals> _Nonnull);
	delegate void MPTransactionParametersCaptureOptionalsBlock(MPTransactionParametersCaptureOptionals arg0);

	// @interface MPTransactionParameters : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface MPTransactionParameters : INSCopying
	{
		// @property (readonly, assign, nonatomic) int transactionType;
		[Export("transactionType")]
		int TransactionType { get; }

		// @property (readonly, copy, nonatomic) NSDecimalNumber * _Nullable amount;
		[NullAllowed, Export("amount", ArgumentSemantic.Copy)]
		NSDecimalNumber Amount { get; }

		// @property (readonly, assign, nonatomic) int currency;
		[Export("currency")]
		int Currency { get; }

		// @property (readonly, assign, nonatomic) BOOL autoCapture;
		[Export("autoCapture")]
		bool AutoCapture { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable referencedTransactionIdentifier;
		[NullAllowed, Export("referencedTransactionIdentifier")]
		string ReferencedTransactionIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable referencedCustomIdentifier;
		[NullAllowed, Export("referencedCustomIdentifier")]
		string ReferencedCustomIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable subject;
		[NullAllowed, Export("subject")]
		string Subject { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable customIdentifier;
		[NullAllowed, Export("customIdentifier")]
		string CustomIdentifier { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable statementDescriptor;
		[NullAllowed, Export("statementDescriptor")]
		string StatementDescriptor { get; }

		// @property (readonly, copy, nonatomic) NSDecimalNumber * _Nullable applicationFee;
		[NullAllowed, Export("applicationFee", ArgumentSemantic.Copy)]
		NSDecimalNumber ApplicationFee { get; }

		// @property (readonly, copy, nonatomic) NSDecimalNumber * _Nullable includedTipAmount;
		[NullAllowed, Export("includedTipAmount", ArgumentSemantic.Copy)]
		NSDecimalNumber IncludedTipAmount { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * _Nullable metadata;
		[NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; }

		// @property (readonly, assign, nonatomic) MPTransactionParametersType parametersType;
		[Export("parametersType", ArgumentSemantic.Assign)]
		MPTransactionParametersType ParametersType { get; }

		// +(instancetype _Nonnull)chargeWithAmount:(NSDecimalNumber * _Nonnull)amount currency:(id)currency optionals:(MPTransactionParametersOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("chargeWithAmount:currency:optionals:")]
		MPTransactionParameters ChargeWithAmount(NSDecimalNumber amount, MPCurrency currency, [NullAllowed] MPTransactionParametersOptionalsBlock optionalsBlock);

		// +(instancetype _Nonnull)refundForTransactionIdentifier:(NSString * _Nonnull)transactionIdentifier optionals:(MPTransactionParametersRefundOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("refundForTransactionIdentifier:optionals:")]
		MPTransactionParameters RefundForTransactionIdentifier(string transactionIdentifier, [NullAllowed] MPTransactionParametersRefundOptionalsBlock optionalsBlock);

		// +(instancetype _Nonnull)refundForCustomIdentifier:(NSString * _Nonnull)customIdentifier optionals:(MPTransactionParametersRefundOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("refundForCustomIdentifier:optionals:")]
		MPTransactionParameters RefundForCustomIdentifier(string customIdentifier, [NullAllowed] MPTransactionParametersRefundOptionalsBlock optionalsBlock);

		// +(instancetype _Nonnull)captureTransactionWithIdentifier:(NSString * _Nonnull)transactionIdentifier optionals:(MPTransactionParametersCaptureOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("captureTransactionWithIdentifier:optionals:")]
		MPTransactionParameters CaptureTransactionWithIdentifier(string transactionIdentifier, [NullAllowed] MPTransactionParametersCaptureOptionalsBlock optionalsBlock);
	}

	// @protocol MPAccessoryOptionals <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPAccessoryOptionals
	{
		// @required @property (nonatomic) NSArray * _Nullable idleText;
		[Abstract]
		[NullAllowed, Export("idleText", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] IdleText { get; set; }

		// @required @property (nonatomic) int locale;
		[Abstract]
		[Export("locale")]
		int Locale { get; set; }
	}

	// @protocol MPExternalAccessoryOptionals <MPAccessoryOptionals>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPExternalAccessoryOptionals : MPAccessoryOptionals
	{
		// @required @property (nonatomic) NSString * _Nullable namePrefix;
		[Abstract]
		[NullAllowed, Export("namePrefix")]
		string NamePrefix { get; set; }
	}

	// typedef void (^MPAccessoryOptionalsBlock)(id<MPAccessoryOptionals> _Nonnull);
	delegate void MPAccessoryOptionalsBlock(MPAccessoryOptionals arg0);

	// typedef void (^MPExternalAccessoryOptionalsBlock)(id<MPExternalAccessoryOptionals> _Nonnull);
	delegate void MPExternalAccessoryOptionalsBlock(MPExternalAccessoryOptionals arg0);

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull MPAccessoryOptionalsProtocolKey;
		[Field("MPAccessoryOptionalsProtocolKey", "__Internal")]
		NSString MPAccessoryOptionalsProtocolKey { get; }

		// extern NSString *const _Nonnull MPAccessoryOptionalsNamePrefixKey;
		[Field("MPAccessoryOptionalsNamePrefixKey", "__Internal")]
		NSString MPAccessoryOptionalsNamePrefixKey { get; }

		// extern NSString *const _Nonnull MPAccessoryOptionalsRemoteKey;
		[Field("MPAccessoryOptionalsRemoteKey", "__Internal")]
		NSString MPAccessoryOptionalsRemoteKey { get; }

		// extern NSString *const _Nonnull MPAccessoryOptionalsPortKey;
		[Field("MPAccessoryOptionalsPortKey", "__Internal")]
		NSString MPAccessoryOptionalsPortKey { get; }
	}

	// @interface MPAccessoryParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface MPAccessoryParameters
	{
		// @property (readonly, assign, nonatomic) int accessoryFamily;
		[Export("accessoryFamily")]
		int AccessoryFamily { get; }

		// @property (readonly, assign, nonatomic) int connectionType;
		[Export("connectionType")]
		int ConnectionType { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * _Nullable filters;
		[NullAllowed, Export("filters", ArgumentSemantic.Strong)]
		NSDictionary Filters { get; }

		// @property (readonly, nonatomic, strong) NSArray * _Nullable idleText;
		[NullAllowed, Export("idleText", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] IdleText { get; }

		// @property (readonly, assign, nonatomic) int locale;
		[Export("locale")]
		int Locale { get; }

		// +(instancetype _Nonnull)externalAccessoryParametersWithFamily:(id)family protocol:(NSString * _Nonnull)protocol optionals:(MPExternalAccessoryOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("externalAccessoryParametersWithFamily:protocol:optionals:")]
		MPAccessoryParameters ExternalAccessoryParametersWithFamily(NSObject family, string protocol, [NullAllowed] MPExternalAccessoryOptionalsBlock optionalsBlock);

		// +(instancetype _Nonnull)audioJackAccessoryParametersWithFamily:(id)family optionals:(MPAccessoryOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("audioJackAccessoryParametersWithFamily:optionals:")]
		MPAccessoryParameters AudioJackAccessoryParametersWithFamily(NSObject family, [NullAllowed] MPAccessoryOptionalsBlock optionalsBlock);

		// +(instancetype _Nonnull)tcpAccessoryParametersWithFamily:(id)family remote:(NSString * _Nonnull)remote port:(NSUInteger)port optionals:(MPAccessoryOptionalsBlock _Nullable)optionalsBlock;
		[Static]
		[Export("tcpAccessoryParametersWithFamily:remote:port:optionals:")]
		MPAccessoryParameters TcpAccessoryParametersWithFamily(NSObject family, string remote, uint port, [NullAllowed] MPAccessoryOptionalsBlock optionalsBlock);

		// +(instancetype _Nonnull)mockAccessoryParameters;
		[Static]
		[Export("mockAccessoryParameters")]
		MPAccessoryParameters MockAccessoryParameters();
	}

	// @protocol MPTransactionProcessParametersSteps <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MPTransactionProcessParametersSteps
	{
		// @required -(void)addAskForTipStepWithSuggestedAmount:(NSDecimalNumber * _Nullable)suggestedAmount;
		[Abstract]
		[Export("addAskForTipStepWithSuggestedAmount:")]
		void AddAskForTipStepWithSuggestedAmount([NullAllowed] NSDecimalNumber suggestedAmount);
	}

	// typedef void (^MPTransactionProcessParametersStepsBlock)(id<MPTransactionProcessParametersSteps> _Nonnull);
	delegate void MPTransactionProcessParametersStepsBlock(MPTransactionProcessParametersSteps arg0);

	// @interface MPTransactionProcessParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionProcessParameters
	{
		// +(instancetype _Nonnull)parametersWithSteps:(MPTransactionProcessParametersStepsBlock _Nonnull)stepsBlock;
		[Static]
		[Export("parametersWithSteps:")]
		MPTransactionProcessParameters ParametersWithSteps(MPTransactionProcessParametersStepsBlock stepsBlock);
	}

	// @interface MPLocalizationToolbox : NSObject
	[BaseType(typeof(NSObject))]
	interface MPLocalizationToolbox
	{
		// -(NSString * _Nullable)textFormattedForAmount:(NSDecimalNumber * _Nullable)amount currency:(id)currency;
		[Export("textFormattedForAmount:currency:")]
		[return: NullAllowed]
		string TextFormattedForAmount([NullAllowed] NSDecimalNumber amount, NSObject currency);

		// -(NSString * _Nullable)textFormattedForDate:(NSDate * _Nullable)date;
		[Export("textFormattedForDate:")]
		[return: NullAllowed]
		string TextFormattedForDate([NullAllowed] NSDate date);

		// -(NSString * _Nullable)textFormattedForTime:(NSDate * _Nullable)time;
		[Export("textFormattedForTime:")]
		[return: NullAllowed]
		string TextFormattedForTime([NullAllowed] NSDate time);

		// -(NSString * _Nullable)textFormattedForTimeAndDate:(NSDate * _Nullable)datetime;
		[Export("textFormattedForTimeAndDate:")]
		[return: NullAllowed]
		string TextFormattedForTimeAndDate([NullAllowed] NSDate datetime);

		// -(NSString * _Nullable)informationForTransactionStatusDetailsCode:(MPTransactionStatusDetailsCode)code;
		[Export("informationForTransactionStatusDetailsCode:")]
		[return: NullAllowed]
		string InformationForTransactionStatusDetailsCode(MPTransactionStatusDetailsCode code);
	}

	// @interface MPTransactionFilterParameters : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionFilterParameters
	{
		// +(instancetype)emptyFilter;
		[Static]
		[Export("emptyFilter")]
		MPTransactionFilterParameters EmptyFilter();

		// +(instancetype)filterWithCustomIdentifier:(NSString *)customIdentifier;
		[Static]
		[Export("filterWithCustomIdentifier:")]
		MPTransactionFilterParameters FilterWithCustomIdentifier(string customIdentifier);
	}

	// typedef void (^MPTransactionModuleLookupByTransactionIdentifierCompleted)(MPTransaction * _Nullable, NSError * _Nullable);
	delegate void MPTransactionModuleLookupByTransactionIdentifierCompleted([NullAllowed] MPTransaction arg0, [NullAllowed] NSError arg1);

	// typedef void (^MPTransactionModulQueryCompleted)(NSArray * _Nullable, NSError * _Nullable);
	delegate void MPTransactionModulQueryCompleted([NullAllowed] NSObject[] arg0, [NullAllowed] NSError arg1);

	// typedef void (^MPTransactionModuleSendingCustomerReceiptCompleted)(NSString * _Nonnull, NSString * _Nonnull, NSError * _Nullable);
	delegate void MPTransactionModuleSendingCustomerReceiptCompleted(string arg0, string arg1, [NullAllowed] NSError arg2);

	// @interface MPTransactionModule : NSObject
	[BaseType(typeof(NSObject))]
	interface MPTransactionModule
	{
		// -(void)lookupTransactionWithTransactionIdentifier:(NSString * _Nonnull)transactionIdentifier completed:(MPTransactionModuleLookupByTransactionIdentifierCompleted _Nonnull)completed;
		[Export("lookupTransactionWithTransactionIdentifier:completed:")]
		void LookupTransactionWithTransactionIdentifier(string transactionIdentifier, MPTransactionModuleLookupByTransactionIdentifierCompleted completed);

		// -(void)queryTransactionsUsingFilters:(MPTransactionFilterParameters * _Nullable)filterParameters completed:(MPTransactionModulQueryCompleted _Nonnull)completed;
		[Export("queryTransactionsUsingFilters:completed:")]
		void QueryTransactionsUsingFilters([NullAllowed] MPTransactionFilterParameters filterParameters, MPTransactionModulQueryCompleted completed);

		// -(void)queryTransactionsUsingFilters:(MPTransactionFilterParameters * _Nullable)filterParameters includeReceipts:(BOOL)includeReceipts range:(NSRange)range completed:(MPTransactionModulQueryCompleted _Nonnull)completed;
		[Export("queryTransactionsUsingFilters:includeReceipts:range:completed:")]
		void QueryTransactionsUsingFilters([NullAllowed] MPTransactionFilterParameters filterParameters, bool includeReceipts, NSRange range, MPTransactionModulQueryCompleted completed);

		// -(void)sendCustomerReceiptForTransactionIdentifier:(NSString * _Nonnull)transactionIdentifier emailAddress:(NSString * _Nonnull)emailAddress completed:(MPTransactionModuleSendingCustomerReceiptCompleted _Nonnull)completed;
		[Export("sendCustomerReceiptForTransactionIdentifier:emailAddress:completed:")]
		void SendCustomerReceiptForTransactionIdentifier(string transactionIdentifier, string emailAddress, MPTransactionModuleSendingCustomerReceiptCompleted completed);
	}
}
