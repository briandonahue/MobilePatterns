
using System;
using System.Collections.Generic;
using System.Linq;
using MobilePatterns.Core;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace MobilePatterns
{
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : UIApplicationDelegate
	{
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
		    IoCBootStrapper.Initialize();
		    
			var homeController = new UIViewController();
			var homeView = new UIView(new RectangleF(0, 0, 320,480));
			var label = new UILabel(new RectangleF(30,30,200, 100));
			label.Text = "I'm here";
			homeView.AddSubview(label);
			window.AddSubview(homeView);
			
			window.MakeKeyAndVisible ();
			
			return true;
		}

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}
	}
}

