using System;
using Foundation;

// @interface Lockbox : NSObject
[BaseType (typeof(NSObject))]
interface Lockbox
{
	// -(instancetype)initWithKeyPrefix:(NSString *)keyPrefix;
	[Export ("initWithKeyPrefix:")]
	IntPtr Constructor (string keyPrefix);

	// -(BOOL)setString:(NSString *)value forKey:(NSString *)key;
	[Export ("setString:forKey:")]
	bool SetString (string value, string key);

	// -(BOOL)setString:(NSString *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Export ("setString:forKey:accessibility:")]
	unsafe bool SetString (string value, string key, void* accessibility);

	// -(NSString *)stringForKey:(NSString *)key;
	[Export ("stringForKey:")]
	string StringForKey (string key);

	// -(BOOL)setArray:(NSArray *)value forKey:(NSString *)key;
	[Export ("setArray:forKey:")]
	[Verify (StronglyTypedNSArray)]
	bool SetArray (NSObject[] value, string key);

	// -(BOOL)setArray:(NSArray *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Export ("setArray:forKey:accessibility:")]
	[Verify (StronglyTypedNSArray)]
	unsafe bool SetArray (NSObject[] value, string key, void* accessibility);

	// -(NSArray *)arrayForKey:(NSString *)key;
	[Export ("arrayForKey:")]
	[Verify (StronglyTypedNSArray)]
	NSObject[] ArrayForKey (string key);

	// -(BOOL)setSet:(NSSet *)value forKey:(NSString *)key;
	[Export ("setSet:forKey:")]
	bool SetSet (NSSet value, string key);

	// -(BOOL)setSet:(NSSet *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Export ("setSet:forKey:accessibility:")]
	unsafe bool SetSet (NSSet value, string key, void* accessibility);

	// -(NSSet *)setForKey:(NSString *)key;
	[Export ("setForKey:")]
	NSSet SetForKey (string key);

	// -(BOOL)setDictionary:(NSDictionary *)value forKey:(NSString *)key;
	[Export ("setDictionary:forKey:")]
	bool SetDictionary (NSDictionary value, string key);

	// -(BOOL)setDictionary:(NSDictionary *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Export ("setDictionary:forKey:accessibility:")]
	unsafe bool SetDictionary (NSDictionary value, string key, void* accessibility);

	// -(NSDictionary *)dictionaryForKey:(NSString *)key;
	[Export ("dictionaryForKey:")]
	NSDictionary DictionaryForKey (string key);

	// -(BOOL)setDate:(NSDate *)value forKey:(NSString *)key;
	[Export ("setDate:forKey:")]
	bool SetDate (NSDate value, string key);

	// -(BOOL)setDate:(NSDate *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Export ("setDate:forKey:accessibility:")]
	unsafe bool SetDate (NSDate value, string key, void* accessibility);

	// -(NSDate *)dateForKey:(NSString *)key;
	[Export ("dateForKey:")]
	NSDate DateForKey (string key);

	// +(BOOL)setString:(NSString *)value forKey:(NSString *)key;
	[Static]
	[Export ("setString:forKey:")]
	bool SetString (string value, string key);

	// +(BOOL)setString:(NSString *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Static]
	[Export ("setString:forKey:accessibility:")]
	unsafe bool SetString (string value, string key, void* accessibility);

	// +(NSString *)stringForKey:(NSString *)key;
	[Static]
	[Export ("stringForKey:")]
	string StringForKey (string key);

	// +(BOOL)setArray:(NSArray *)value forKey:(NSString *)key;
	[Static]
	[Export ("setArray:forKey:")]
	[Verify (StronglyTypedNSArray)]
	bool SetArray (NSObject[] value, string key);

	// +(BOOL)setArray:(NSArray *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Static]
	[Export ("setArray:forKey:accessibility:")]
	[Verify (StronglyTypedNSArray)]
	unsafe bool SetArray (NSObject[] value, string key, void* accessibility);

	// +(NSArray *)arrayForKey:(NSString *)key;
	[Static]
	[Export ("arrayForKey:")]
	[Verify (StronglyTypedNSArray)]
	NSObject[] ArrayForKey (string key);

	// +(BOOL)setSet:(NSSet *)value forKey:(NSString *)key;
	[Static]
	[Export ("setSet:forKey:")]
	bool SetSet (NSSet value, string key);

	// +(BOOL)setSet:(NSSet *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Static]
	[Export ("setSet:forKey:accessibility:")]
	unsafe bool SetSet (NSSet value, string key, void* accessibility);

	// +(NSSet *)setForKey:(NSString *)key;
	[Static]
	[Export ("setForKey:")]
	NSSet SetForKey (string key);

	// +(BOOL)setDictionary:(NSDictionary *)value forKey:(NSString *)key;
	[Static]
	[Export ("setDictionary:forKey:")]
	bool SetDictionary (NSDictionary value, string key);

	// +(BOOL)setDictionary:(NSDictionary *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Static]
	[Export ("setDictionary:forKey:accessibility:")]
	unsafe bool SetDictionary (NSDictionary value, string key, void* accessibility);

	// +(NSDictionary *)dictionaryForKey:(NSString *)key;
	[Static]
	[Export ("dictionaryForKey:")]
	NSDictionary DictionaryForKey (string key);

	// +(BOOL)setDate:(NSDate *)value forKey:(NSString *)key;
	[Static]
	[Export ("setDate:forKey:")]
	bool SetDate (NSDate value, string key);

	// +(BOOL)setDate:(NSDate *)value forKey:(NSString *)key accessibility:(CFTypeRef)accessibility;
	[Static]
	[Export ("setDate:forKey:accessibility:")]
	unsafe bool SetDate (NSDate value, string key, void* accessibility);

	// +(NSDate *)dateForKey:(NSString *)key;
	[Static]
	[Export ("dateForKey:")]
	NSDate DateForKey (string key);
}

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double LockboxVersionNumber;
	[Field ("LockboxVersionNumber", "__Internal")]
	double LockboxVersionNumber { get; }

	// extern const unsigned char [] LockboxVersionString;
	[Field ("LockboxVersionString", "__Internal")]
	byte[] LockboxVersionString { get; }
}
