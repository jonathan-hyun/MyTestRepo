using Foundation;

namespace ForstaBinding
{
	// @interface ForstaFrameworkProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface ForstaFrameworkProxy
	{
		// -(NSString * _Nonnull)getServerId __attribute__((warn_unused_result("")));
		[Export ("getServerId")]
		[Verify (MethodToProperty)]
		string ServerId { get; }
	}
}
