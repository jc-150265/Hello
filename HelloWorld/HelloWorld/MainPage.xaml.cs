using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloWorld
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Bookテーブルにデータを追加
            //Insert文的なもの
            BookModel.insertBook("Book1");
            BookModel.insertBook("Book2");
            BookModel.insertBook("Book3");

            //Bookテーブルの行データを習得
            var query = BookModel.selectBook();

            foreach(var book in query)
            {
                //Bookテーブルの名前列をLabelに書き出す
                layout.Children.Add(new Label { Text = book.Name });
            }
            Content = layout;
		}
	}
}
