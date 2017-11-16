using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWorld
{
	public partial class App : Application
	{
        //データベースのパスを格納
        public static string dbPath;

        //コンストラクタの引数にstring型の引数を追加

        public App (string dbPath)
		{
            App.dbPath = dbPath;

			InitializeComponent();

			MainPage = new HelloWorld.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
