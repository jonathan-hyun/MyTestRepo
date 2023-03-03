import ConfirmitMobileSDK
import Foundation

@objc(ForstaFrameworkProxy)
public class ForstaFrameworkProxy: NSObject {
  @objc
  public func setup(clinetId: String, clientSecret: String) {
    ConfirmitSDK.Setup().configure()
    // Initialize server with received Client ID and Client Secret keys
    try! ConfirmitServer.configureUK(clientId: clinetId, clientSecret: clientSecret)
  }

  @objc
  public func getServerId() -> String {
    return ConfirmitServer.uk.serverId
  }
}
