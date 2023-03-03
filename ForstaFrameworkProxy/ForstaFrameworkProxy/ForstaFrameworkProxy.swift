import Foundation
import ConfirmitMobileSDK

@objc(ForstaFrameworkProxy)
public class ForstaFrameworkProxy : NSObject {

    @objc
    public func getServerId() -> String {
      ConfirmitSDK.Setup().configure();
      // Initialize server with received Client ID and Client Secret keys
      try! ConfirmitServer.configureUK(clientId: "<Client ID>", clientSecret: "<Client Secret>")
      return ConfirmitServer.uk.serverId;
    }
}
