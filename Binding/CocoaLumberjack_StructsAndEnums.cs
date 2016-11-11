using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;
using UIKit;

[Native]
public enum DDLogFlag : nuint
{
	Error = (1 << 0),
	Warning = (1 << 1),
	Info = (1 << 2),
	Debug = (1 << 3),
	Verbose = (1 << 4)
}

[Native]
public enum DDLogLevel : nuint
{
	Off = 0,
	Error = (DDLogFlagError),
	Warning = (Error | DDLogFlagWarning),
	Info = (Warning | DDLogFlagInfo),
	Debug = (Info | DDLogFlagDebug),
	Verbose = (Debug | DDLogFlagVerbose),
	All = (9223372036854775807L * 2 + 1)
}

static class CFunctions
{
	// extern NSString * DDExtractFileNameWithoutExtension (const char *filePath, BOOL copy);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern unsafe NSString DDExtractFileNameWithoutExtension (sbyte* filePath, bool copy);

	// DDColor * DDMakeColor (CGFloat r, CGFloat g, CGFloat b);
	[DllImport ("__Internal")]
	[Verify (PlatformInvoke)]
	static extern UIColor DDMakeColor (nfloat r, nfloat g, nfloat b);
}

[Native]
public enum DDLogMessageOptions : nint
{
	ile = 1 << 0,
	unction = 1 << 1
}
