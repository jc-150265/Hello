using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace HelloWorld.iOS
{
    
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

            //指定したファイルのパスを習得
            var dbPath = GetLocalFilePath("Book.db3");

            LoadApplication(new App(dbPath));

			return base.FinishedLaunching (app, options);
		}

        public static string GetLocalFilePath(string filename)
        {
            //指定されたファイルのパスを習得　なければ作成してそのパスを返却
            var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libFolder = System.IO.Path.Combine(docFolder, "..", "Library", "Databases");

            if (!System.IO.Directory.Exists(libFolder))
            {
                System.IO.Directory.CreateDirectory(libFolder);
            }

            return System.IO.Path.Combine(libFolder, filename);
        }
	}
}
