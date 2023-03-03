using System;
using UIKit;
using ForstaBinding;

namespace XamarinTestApp
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var proxy = new ForstaFrameworkProxy();
            Console.Out.WriteLine("TEST - Server ID=" + proxy.ServerId);
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
        }
    }
}
