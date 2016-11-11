using System;
using CocoaLumberjack;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Payworks
{
	// @interface DDLog : NSObject
	[BaseType (typeof(NSObject))]
	interface DDLog
	{
		// +(dispatch_queue_t)loggingQueue;
		[Static]
		[Export ("loggingQueue")]
		[Verify (MethodToProperty)]
		DispatchQueue LoggingQueue { get; }

		// +(void)log:(BOOL)asynchronous level:(DDLogLevel)level flag:(DDLogFlag)flag context:(NSInteger)context file:(const char *)file function:(const char *)function line:(NSUInteger)line tag:(id)tag format:(NSString *)format, ... __attribute__((format(NSString, 9, 10)));
		[Static, Internal]
		[Export ("log:level:flag:context:file:function:line:tag:format:", IsVariadic = true)]
		unsafe void Log (bool asynchronous, DDLogLevel level, DDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, NSObject tag, string format, IntPtr varArgs);

		// +(void)log:(BOOL)asynchronous level:(DDLogLevel)level flag:(DDLogFlag)flag context:(NSInteger)context file:(const char *)file function:(const char *)function line:(NSUInteger)line tag:(id)tag format:(NSString *)format args:(va_list)argList;
		[Static]
		[Export ("log:level:flag:context:file:function:line:tag:format:args:")]
		unsafe void Log (bool asynchronous, DDLogLevel level, DDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, NSObject tag, string format, sbyte* argList);

		// +(void)log:(BOOL)asynchronous message:(NSString *)message level:(DDLogLevel)level flag:(DDLogFlag)flag context:(NSInteger)context file:(const char *)file function:(const char *)function line:(NSUInteger)line tag:(id)tag;
		[Static]
		[Export ("log:message:level:flag:context:file:function:line:tag:")]
		unsafe void Log (bool asynchronous, string message, DDLogLevel level, DDLogFlag flag, nint context, sbyte* file, sbyte* function, nuint line, NSObject tag);

		// +(void)log:(BOOL)asynchronous message:(DDLogMessage *)logMessage;
		[Static]
		[Export ("log:message:")]
		void Log (bool asynchronous, DDLogMessage logMessage);

		// +(void)flushLog;
		[Static]
		[Export ("flushLog")]
		void FlushLog ();

		// +(void)addLogger:(id<DDLogger>)logger;
		[Static]
		[Export ("addLogger:")]
		void AddLogger (DDLogger logger);

		// +(void)addLogger:(id<DDLogger>)logger withLevel:(DDLogLevel)level;
		[Static]
		[Export ("addLogger:withLevel:")]
		void AddLogger (DDLogger logger, DDLogLevel level);

		// +(void)removeLogger:(id<DDLogger>)logger;
		[Static]
		[Export ("removeLogger:")]
		void RemoveLogger (DDLogger logger);

		// +(void)removeAllLoggers;
		[Static]
		[Export ("removeAllLoggers")]
		void RemoveAllLoggers ();

		// +(NSArray *)allLoggers;
		[Static]
		[Export ("allLoggers")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] AllLoggers { get; }

		// +(NSArray *)registeredClasses;
		[Static]
		[Export ("registeredClasses")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] RegisteredClasses { get; }

		// +(NSArray *)registeredClassNames;
		[Static]
		[Export ("registeredClassNames")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] RegisteredClassNames { get; }

		// +(DDLogLevel)levelForClass:(Class)aClass;
		[Static]
		[Export ("levelForClass:")]
		DDLogLevel LevelForClass (Class aClass);

		// +(DDLogLevel)levelForClassWithName:(NSString *)aClassName;
		[Static]
		[Export ("levelForClassWithName:")]
		DDLogLevel LevelForClassWithName (string aClassName);

		// +(void)setLevel:(DDLogLevel)level forClass:(Class)aClass;
		[Static]
		[Export ("setLevel:forClass:")]
		void SetLevel (DDLogLevel level, Class aClass);

		// +(void)setLevel:(DDLogLevel)level forClassWithName:(NSString *)aClassName;
		[Static]
		[Export ("setLevel:forClassWithName:")]
		void SetLevel (DDLogLevel level, string aClassName);
	}

	// @protocol DDLogger <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DDLogger
	{
		// @required -(void)logMessage:(DDLogMessage *)logMessage;
		[Abstract]
		[Export ("logMessage:")]
		void LogMessage (DDLogMessage logMessage);

		// @required @property (nonatomic, strong) id<DDLogFormatter> logFormatter;
		[Abstract]
		[Export ("logFormatter", ArgumentSemantic.Strong)]
		DDLogFormatter LogFormatter { get; set; }

		// @optional -(void)didAddLogger;
		[Export ("didAddLogger")]
		void DidAddLogger ();

		// @optional -(void)willRemoveLogger;
		[Export ("willRemoveLogger")]
		void WillRemoveLogger ();

		// @optional -(void)flush;
		[Export ("flush")]
		void Flush ();

		// @optional @property (readonly, nonatomic, strong) dispatch_queue_t loggerQueue;
		[Export ("loggerQueue", ArgumentSemantic.Strong)]
		DispatchQueue LoggerQueue { get; }

		// @optional @property (readonly, nonatomic) NSString * loggerName;
		[Export ("loggerName")]
		string LoggerName { get; }
	}

	// @protocol DDLogFormatter <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DDLogFormatter
	{
		// @required -(NSString *)formatLogMessage:(DDLogMessage *)logMessage;
		[Abstract]
		[Export ("formatLogMessage:")]
		string FormatLogMessage (DDLogMessage logMessage);

		// @optional -(void)didAddToLogger:(id<DDLogger>)logger;
		[Export ("didAddToLogger:")]
		void DidAddToLogger (DDLogger logger);

		// @optional -(void)willRemoveFromLogger:(id<DDLogger>)logger;
		[Export ("willRemoveFromLogger:")]
		void WillRemoveFromLogger (DDLogger logger);
	}

	// @protocol DDRegisteredDynamicLogging
	[Protocol, Model]
	interface DDRegisteredDynamicLogging
	{
		// @required +(DDLogLevel)ddLogLevel;
		[Static, Abstract]
		[Export ("ddLogLevel")]
		[Verify (MethodToProperty)]
		DDLogLevel DdLogLevel { get; }

		// @required +(void)ddSetLogLevel:(DDLogLevel)level;
		[Static, Abstract]
		[Export ("ddSetLogLevel:")]
		void DdSetLogLevel (DDLogLevel level);
	}

	// @interface DDLogMessage : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface DDLogMessage : INSCopying
	{
		// -(instancetype)initWithMessage:(NSString *)message level:(DDLogLevel)level flag:(DDLogFlag)flag context:(NSInteger)context file:(NSString *)file function:(NSString *)function line:(NSUInteger)line tag:(id)tag options:(DDLogMessageOptions)options timestamp:(NSDate *)timestamp;
		[Export ("initWithMessage:level:flag:context:file:function:line:tag:options:timestamp:")]
		IntPtr Constructor (string message, DDLogLevel level, DDLogFlag flag, nint context, string file, string function, nuint line, NSObject tag, DDLogMessageOptions options, NSDate timestamp);

		// @property (readonly, nonatomic) NSString * message;
		[Export ("message")]
		string Message { get; }

		// @property (readonly, nonatomic) DDLogLevel level;
		[Export ("level")]
		DDLogLevel Level { get; }

		// @property (readonly, nonatomic) DDLogFlag flag;
		[Export ("flag")]
		DDLogFlag Flag { get; }

		// @property (readonly, nonatomic) NSInteger context;
		[Export ("context")]
		nint Context { get; }

		// @property (readonly, nonatomic) NSString * file;
		[Export ("file")]
		string File { get; }

		// @property (readonly, nonatomic) NSString * fileName;
		[Export ("fileName")]
		string FileName { get; }

		// @property (readonly, nonatomic) NSString * function;
		[Export ("function")]
		string Function { get; }

		// @property (readonly, nonatomic) NSUInteger line;
		[Export ("line")]
		nuint Line { get; }

		// @property (readonly, nonatomic) id tag;
		[Export ("tag")]
		NSObject Tag { get; }

		// @property (readonly, nonatomic) DDLogMessageOptions options;
		[Export ("options")]
		DDLogMessageOptions Options { get; }

		// @property (readonly, nonatomic) NSDate * timestamp;
		[Export ("timestamp")]
		NSDate Timestamp { get; }

		// @property (readonly, nonatomic) NSString * threadID;
		[Export ("threadID")]
		string ThreadID { get; }

		// @property (readonly, nonatomic) NSString * threadName;
		[Export ("threadName")]
		string ThreadName { get; }

		// @property (readonly, nonatomic) NSString * queueLabel;
		[Export ("queueLabel")]
		string QueueLabel { get; }
	}

	// @interface DDAbstractLogger : NSObject <DDLogger>
	[BaseType (typeof(NSObject))]
	interface DDAbstractLogger : IDDLogger
	{
		// @property (nonatomic, strong) id<DDLogFormatter> logFormatter;
		[Export ("logFormatter", ArgumentSemantic.Strong)]
		DDLogFormatter LogFormatter { get; set; }

		// @property (nonatomic, strong) dispatch_queue_t loggerQueue;
		[Export ("loggerQueue", ArgumentSemantic.Strong)]
		DispatchQueue LoggerQueue { get; set; }

		// @property (readonly, getter = isOnGlobalLoggingQueue, nonatomic) BOOL onGlobalLoggingQueue;
		[Export ("onGlobalLoggingQueue")]
		bool OnGlobalLoggingQueue { [Bind ("isOnGlobalLoggingQueue")] get; }

		// @property (readonly, getter = isOnInternalLoggerQueue, nonatomic) BOOL onInternalLoggerQueue;
		[Export ("onInternalLoggerQueue")]
		bool OnInternalLoggerQueue { [Bind ("isOnInternalLoggerQueue")] get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const char *const kDDASLKeyDDLog;
		[Field ("kDDASLKeyDDLog", "__Internal")]
		unsafe sbyte* kDDASLKeyDDLog { get; }

		// extern const char *const kDDASLDDLogValue;
		[Field ("kDDASLDDLogValue", "__Internal")]
		unsafe sbyte* kDDASLDDLogValue { get; }
	}

	// @interface DDASLLogger : DDAbstractLogger <DDLogger>
	[BaseType (typeof(DDAbstractLogger))]
	interface DDASLLogger : IDDLogger
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		DDASLLogger SharedInstance ();
	}

	// @interface DDASLLogCapture : NSObject
	[BaseType (typeof(NSObject))]
	interface DDASLLogCapture
	{
		// +(void)start;
		[Static]
		[Export ("start")]
		void Start ();

		// +(void)stop;
		[Static]
		[Export ("stop")]
		void Stop ();

		// +(DDLogLevel)captureLevel;
		// +(void)setCaptureLevel:(DDLogLevel)level;
		[Static]
		[Export ("captureLevel")]
		[Verify (MethodToProperty)]
		DDLogLevel CaptureLevel { get; set; }
	}

	// @interface DDTTYLogger : DDAbstractLogger <DDLogger>
	[BaseType (typeof(DDAbstractLogger))]
	interface DDTTYLogger : IDDLogger
	{
		// +(instancetype)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		DDTTYLogger SharedInstance ();

		// @property (assign, readwrite) BOOL colorsEnabled;
		[Export ("colorsEnabled")]
		bool ColorsEnabled { get; set; }

		// @property (assign, readwrite, nonatomic) BOOL automaticallyAppendNewlineForCustomFormatters;
		[Export ("automaticallyAppendNewlineForCustomFormatters")]
		bool AutomaticallyAppendNewlineForCustomFormatters { get; set; }

		// -(void)setForegroundColor:(DDColor *)txtColor backgroundColor:(DDColor *)bgColor forFlag:(DDLogFlag)mask;
		[Export ("setForegroundColor:backgroundColor:forFlag:")]
		void SetForegroundColor (UIColor txtColor, UIColor bgColor, DDLogFlag mask);

		// -(void)setForegroundColor:(DDColor *)txtColor backgroundColor:(DDColor *)bgColor forFlag:(DDLogFlag)mask context:(NSInteger)ctxt;
		[Export ("setForegroundColor:backgroundColor:forFlag:context:")]
		void SetForegroundColor (UIColor txtColor, UIColor bgColor, DDLogFlag mask, nint ctxt);

		// -(void)setForegroundColor:(DDColor *)txtColor backgroundColor:(DDColor *)bgColor forTag:(id<NSCopying>)tag;
		[Export ("setForegroundColor:backgroundColor:forTag:")]
		void SetForegroundColor (UIColor txtColor, UIColor bgColor, NSCopying tag);

		// -(void)clearColorsForFlag:(DDLogFlag)mask;
		[Export ("clearColorsForFlag:")]
		void ClearColorsForFlag (DDLogFlag mask);

		// -(void)clearColorsForFlag:(DDLogFlag)mask context:(NSInteger)context;
		[Export ("clearColorsForFlag:context:")]
		void ClearColorsForFlag (DDLogFlag mask, nint context);

		// -(void)clearColorsForTag:(id<NSCopying>)tag;
		[Export ("clearColorsForTag:")]
		void ClearColorsForTag (NSCopying tag);

		// -(void)clearColorsForAllFlags;
		[Export ("clearColorsForAllFlags")]
		void ClearColorsForAllFlags ();

		// -(void)clearColorsForAllTags;
		[Export ("clearColorsForAllTags")]
		void ClearColorsForAllTags ();

		// -(void)clearAllColors;
		[Export ("clearAllColors")]
		void ClearAllColors ();
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const unsigned long long kDDDefaultLogMaxFileSize;
		[Field ("kDDDefaultLogMaxFileSize", "__Internal")]
		ulong kDDDefaultLogMaxFileSize { get; }

		// extern const NSTimeInterval kDDDefaultLogRollingFrequency;
		[Field ("kDDDefaultLogRollingFrequency", "__Internal")]
		double kDDDefaultLogRollingFrequency { get; }

		// extern const NSUInteger kDDDefaultLogMaxNumLogFiles;
		[Field ("kDDDefaultLogMaxNumLogFiles", "__Internal")]
		nuint kDDDefaultLogMaxNumLogFiles { get; }

		// extern const unsigned long long kDDDefaultLogFilesDiskQuota;
		[Field ("kDDDefaultLogFilesDiskQuota", "__Internal")]
		ulong kDDDefaultLogFilesDiskQuota { get; }
	}

	// @protocol DDLogFileManager <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface DDLogFileManager
	{
		// @required @property (assign, readwrite, atomic) NSUInteger maximumNumberOfLogFiles;
		[Abstract]
		[Export ("maximumNumberOfLogFiles")]
		nuint MaximumNumberOfLogFiles { get; set; }

		// @required @property (assign, readwrite, atomic) unsigned long long logFilesDiskQuota;
		[Abstract]
		[Export ("logFilesDiskQuota")]
		ulong LogFilesDiskQuota { get; set; }

		// @required -(NSString *)logsDirectory;
		[Abstract]
		[Export ("logsDirectory")]
		[Verify (MethodToProperty)]
		string LogsDirectory { get; }

		// @required -(NSArray *)unsortedLogFilePaths;
		[Abstract]
		[Export ("unsortedLogFilePaths")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] UnsortedLogFilePaths { get; }

		// @required -(NSArray *)unsortedLogFileNames;
		[Abstract]
		[Export ("unsortedLogFileNames")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] UnsortedLogFileNames { get; }

		// @required -(NSArray *)unsortedLogFileInfos;
		[Abstract]
		[Export ("unsortedLogFileInfos")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] UnsortedLogFileInfos { get; }

		// @required -(NSArray *)sortedLogFilePaths;
		[Abstract]
		[Export ("sortedLogFilePaths")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SortedLogFilePaths { get; }

		// @required -(NSArray *)sortedLogFileNames;
		[Abstract]
		[Export ("sortedLogFileNames")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SortedLogFileNames { get; }

		// @required -(NSArray *)sortedLogFileInfos;
		[Abstract]
		[Export ("sortedLogFileInfos")]
		[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] SortedLogFileInfos { get; }

		// @required -(NSString *)createNewLogFile;
		[Abstract]
		[Export ("createNewLogFile")]
		[Verify (MethodToProperty)]
		string CreateNewLogFile { get; }

		// @optional -(void)didArchiveLogFile:(NSString *)logFilePath;
		[Export ("didArchiveLogFile:")]
		void DidArchiveLogFile (string logFilePath);

		// @optional -(void)didRollAndArchiveLogFile:(NSString *)logFilePath;
		[Export ("didRollAndArchiveLogFile:")]
		void DidRollAndArchiveLogFile (string logFilePath);
	}

	// @interface DDLogFileManagerDefault : NSObject <DDLogFileManager>
	[BaseType (typeof(NSObject))]
	interface DDLogFileManagerDefault : IDDLogFileManager
	{
		// -(instancetype)initWithLogsDirectory:(NSString *)logsDirectory __attribute__((objc_designated_initializer));
		[Export ("initWithLogsDirectory:")]
		[DesignatedInitializer]
		IntPtr Constructor (string logsDirectory);

		// -(instancetype)initWithLogsDirectory:(NSString *)logsDirectory defaultFileProtectionLevel:(NSString *)fileProtectionLevel;
		[Export ("initWithLogsDirectory:defaultFileProtectionLevel:")]
		IntPtr Constructor (string logsDirectory, string fileProtectionLevel);

		// @property (readonly, copy) NSString * newLogFileName;
		[Export ("newLogFileName")]
		string NewLogFileName { get; }

		// -(BOOL)isLogFile:(NSString *)fileName;
		[Export ("isLogFile:")]
		bool IsLogFile (string fileName);
	}

	// @interface DDLogFileFormatterDefault : NSObject <DDLogFormatter>
	[BaseType (typeof(NSObject))]
	interface DDLogFileFormatterDefault : IDDLogFormatter
	{
		// -(instancetype)initWithDateFormatter:(NSDateFormatter *)dateFormatter __attribute__((objc_designated_initializer));
		[Export ("initWithDateFormatter:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSDateFormatter dateFormatter);
	}

	// @interface DDFileLogger : DDAbstractLogger <DDLogger>
	[BaseType (typeof(DDAbstractLogger))]
	interface DDFileLogger : IDDLogger
	{
		// -(instancetype)initWithLogFileManager:(id<DDLogFileManager>)logFileManager __attribute__((objc_designated_initializer));
		[Export ("initWithLogFileManager:")]
		[DesignatedInitializer]
		IntPtr Constructor (DDLogFileManager logFileManager);

		// @property (assign, readwrite) unsigned long long maximumFileSize;
		[Export ("maximumFileSize")]
		ulong MaximumFileSize { get; set; }

		// @property (assign, readwrite) NSTimeInterval rollingFrequency;
		[Export ("rollingFrequency")]
		double RollingFrequency { get; set; }

		// @property (assign, readwrite, atomic) BOOL doNotReuseLogFiles;
		[Export ("doNotReuseLogFiles")]
		bool DoNotReuseLogFiles { get; set; }

		// @property (readonly, nonatomic, strong) id<DDLogFileManager> logFileManager;
		[Export ("logFileManager", ArgumentSemantic.Strong)]
		DDLogFileManager LogFileManager { get; }

		// @property (assign, readwrite, nonatomic) BOOL automaticallyAppendNewlineForCustomFormatters;
		[Export ("automaticallyAppendNewlineForCustomFormatters")]
		bool AutomaticallyAppendNewlineForCustomFormatters { get; set; }

		// -(void)rollLogFileWithCompletionBlock:(void (^)())completionBlock;
		[Export ("rollLogFileWithCompletionBlock:")]
		void RollLogFileWithCompletionBlock (Action completionBlock);

		// -(void)rollLogFile __attribute__((deprecated("")));
		[Export ("rollLogFile")]
		void RollLogFile ();

		// -(DDLogFileInfo *)currentLogFileInfo;
		[Export ("currentLogFileInfo")]
		[Verify (MethodToProperty)]
		DDLogFileInfo CurrentLogFileInfo { get; }
	}

	// @interface DDLogFileInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface DDLogFileInfo
	{
		// @property (readonly, nonatomic, strong) NSString * filePath;
		[Export ("filePath", ArgumentSemantic.Strong)]
		string FilePath { get; }

		// @property (readonly, nonatomic, strong) NSString * fileName;
		[Export ("fileName", ArgumentSemantic.Strong)]
		string FileName { get; }

		// @property (readonly, nonatomic, strong) NSDictionary * fileAttributes;
		[Export ("fileAttributes", ArgumentSemantic.Strong)]
		NSDictionary FileAttributes { get; }

		// @property (readonly, nonatomic, strong) NSDate * creationDate;
		[Export ("creationDate", ArgumentSemantic.Strong)]
		NSDate CreationDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * modificationDate;
		[Export ("modificationDate", ArgumentSemantic.Strong)]
		NSDate ModificationDate { get; }

		// @property (readonly, nonatomic) unsigned long long fileSize;
		[Export ("fileSize")]
		ulong FileSize { get; }

		// @property (readonly, nonatomic) NSTimeInterval age;
		[Export ("age")]
		double Age { get; }

		// @property (readwrite, nonatomic) BOOL isArchived;
		[Export ("isArchived")]
		bool IsArchived { get; set; }

		// +(instancetype)logFileWithPath:(NSString *)filePath;
		[Static]
		[Export ("logFileWithPath:")]
		DDLogFileInfo LogFileWithPath (string filePath);

		// -(instancetype)initWithFilePath:(NSString *)filePath;
		[Export ("initWithFilePath:")]
		IntPtr Constructor (string filePath);

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)renameFile:(NSString *)newFileName;
		[Export ("renameFile:")]
		void RenameFile (string newFileName);

		// -(BOOL)hasExtendedAttributeWithName:(NSString *)attrName;
		[Export ("hasExtendedAttributeWithName:")]
		bool HasExtendedAttributeWithName (string attrName);

		// -(void)addExtendedAttributeWithName:(NSString *)attrName;
		[Export ("addExtendedAttributeWithName:")]
		void AddExtendedAttributeWithName (string attrName);

		// -(void)removeExtendedAttributeWithName:(NSString *)attrName;
		[Export ("removeExtendedAttributeWithName:")]
		void RemoveExtendedAttributeWithName (string attrName);

		// -(NSComparisonResult)reverseCompareByCreationDate:(DDLogFileInfo *)another;
		[Export ("reverseCompareByCreationDate:")]
		NSComparisonResult ReverseCompareByCreationDate (DDLogFileInfo another);

		// -(NSComparisonResult)reverseCompareByModificationDate:(DDLogFileInfo *)another;
		[Export ("reverseCompareByModificationDate:")]
		NSComparisonResult ReverseCompareByModificationDate (DDLogFileInfo another);
	}

	// @interface DDContextWhitelistFilterLogFormatter : NSObject <DDLogFormatter>
	[BaseType (typeof(NSObject))]
	interface DDContextWhitelistFilterLogFormatter : IDDLogFormatter
	{
		// -(void)addToWhitelist:(NSUInteger)loggingContext;
		[Export ("addToWhitelist:")]
		void AddToWhitelist (nuint loggingContext);

		// -(void)removeFromWhitelist:(NSUInteger)loggingContext;
		[Export ("removeFromWhitelist:")]
		void RemoveFromWhitelist (nuint loggingContext);

		// @property (readonly, copy) NSArray * whitelist;
		[Export ("whitelist", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Whitelist { get; }

		// -(BOOL)isOnWhitelist:(NSUInteger)loggingContext;
		[Export ("isOnWhitelist:")]
		bool IsOnWhitelist (nuint loggingContext);
	}

	// @interface DDContextBlacklistFilterLogFormatter : NSObject <DDLogFormatter>
	[BaseType (typeof(NSObject))]
	interface DDContextBlacklistFilterLogFormatter : IDDLogFormatter
	{
		// -(void)addToBlacklist:(NSUInteger)loggingContext;
		[Export ("addToBlacklist:")]
		void AddToBlacklist (nuint loggingContext);

		// -(void)removeFromBlacklist:(NSUInteger)loggingContext;
		[Export ("removeFromBlacklist:")]
		void RemoveFromBlacklist (nuint loggingContext);

		// @property (readonly, copy) NSArray * blacklist;
		[Export ("blacklist", ArgumentSemantic.Copy)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Blacklist { get; }

		// -(BOOL)isOnBlacklist:(NSUInteger)loggingContext;
		[Export ("isOnBlacklist:")]
		bool IsOnBlacklist (nuint loggingContext);
	}

	// @interface DDDispatchQueueLogFormatter : NSObject <DDLogFormatter>
	[BaseType (typeof(NSObject))]
	interface DDDispatchQueueLogFormatter : IDDLogFormatter
	{
		// @property (assign, atomic) NSUInteger minQueueLength;
		[Export ("minQueueLength")]
		nuint MinQueueLength { get; set; }

		// @property (assign, atomic) NSUInteger maxQueueLength;
		[Export ("maxQueueLength")]
		nuint MaxQueueLength { get; set; }

		// -(NSString *)replacementStringForQueueLabel:(NSString *)longLabel;
		[Export ("replacementStringForQueueLabel:")]
		string ReplacementStringForQueueLabel (string longLabel);

		// -(void)setReplacementString:(NSString *)shortLabel forQueueLabel:(NSString *)longLabel;
		[Export ("setReplacementString:forQueueLabel:")]
		void SetReplacementString (string shortLabel, string longLabel);
	}

	// @interface OverridableMethods (DDDispatchQueueLogFormatter)
	[Category]
	[BaseType (typeof(DDDispatchQueueLogFormatter))]
	interface DDDispatchQueueLogFormatter_OverridableMethods
	{
		// -(NSString *)stringFromDate:(NSDate *)date;
		[Export ("stringFromDate:")]
		string StringFromDate (NSDate date);

		// -(NSString *)queueThreadLabelForLogMessage:(DDLogMessage *)logMessage;
		[Export ("queueThreadLabelForLogMessage:")]
		string QueueThreadLabelForLogMessage (DDLogMessage logMessage);

		// -(NSString *)formatLogMessage:(DDLogMessage *)logMessage;
		[Export ("formatLogMessage:")]
		string FormatLogMessage (DDLogMessage logMessage);
	}

	// @interface DDMultiFormatter : NSObject <DDLogFormatter>
	[BaseType (typeof(NSObject))]
	interface DDMultiFormatter : IDDLogFormatter
	{
		// @property (readonly) NSArray * formatters;
		[Export ("formatters")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Formatters { get; }

		// -(void)addFormatter:(id<DDLogFormatter>)formatter;
		[Export ("addFormatter:")]
		void AddFormatter (DDLogFormatter formatter);

		// -(void)removeFormatter:(id<DDLogFormatter>)formatter;
		[Export ("removeFormatter:")]
		void RemoveFormatter (DDLogFormatter formatter);

		// -(void)removeAllFormatters;
		[Export ("removeAllFormatters")]
		void RemoveAllFormatters ();

		// -(BOOL)isFormattingWithFormatter:(id<DDLogFormatter>)formatter;
		[Export ("isFormattingWithFormatter:")]
		bool IsFormattingWithFormatter (DDLogFormatter formatter);
	}

	// @interface DDAbstractDatabaseLogger : DDAbstractLogger
	[BaseType (typeof(DDAbstractLogger))]
	interface DDAbstractDatabaseLogger
	{
		// @property (assign, readwrite) NSUInteger saveThreshold;
		[Export ("saveThreshold")]
		nuint SaveThreshold { get; set; }

		// @property (assign, readwrite) NSTimeInterval saveInterval;
		[Export ("saveInterval")]
		double SaveInterval { get; set; }

		// @property (assign, readwrite) NSTimeInterval maxAge;
		[Export ("maxAge")]
		double MaxAge { get; set; }

		// @property (assign, readwrite) NSTimeInterval deleteInterval;
		[Export ("deleteInterval")]
		double DeleteInterval { get; set; }

		// @property (assign, readwrite) BOOL deleteOnEverySave;
		[Export ("deleteOnEverySave")]
		bool DeleteOnEverySave { get; set; }

		// -(void)savePendingLogEntries;
		[Export ("savePendingLogEntries")]
		void SavePendingLogEntries ();

		// -(void)deleteOldLogEntries;
		[Export ("deleteOldLogEntries")]
		void DeleteOldLogEntries ();
	}
}
