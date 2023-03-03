using Foundation;

namespace ForstaBinding
{
	// @interface ForstaFrameworkProxy : NSObject
	[BaseType (typeof(NSObject))]
	interface ForstaFrameworkProxy
	{
		// -(void)setupWithClinetId:(NSString * _Nonnull)clinetId clientSecret:(NSString * _Nonnull)clientSecret;
		[Export ("setupWithClinetId:clientSecret:")]
		void SetupWithClinetId (string clinetId, string clientSecret);

		// -(NSString * _Nonnull)getServerId __attribute__((warn_unused_result("")));
		[Export ("getServerId")]
		[Verify (MethodToProperty)]
		string ServerId { get; }
	}
}
