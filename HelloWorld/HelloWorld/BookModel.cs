using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace HelloWorld
{
    //テーブル名を指定
    [Table("Book")]

    public class BookModel
    {
        //プライマリキー　自動で決まるらしい
        [PrimaryKey, AutoIncrement, Column("_id")]
        
        //idカラム
        public int Id { get; set; }

        //名前カラム
        public string Name { get; set; }

        //Bookテーブルに行追加するためのメソッド
        public static void insertBook(string name)
        {
            //データベースに接続
            using(SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにBookテーブルを作成
                    db.CreateTable<BookModel>();

                    //Bookテーブルに行を追加
                    db.Insert(new BookModel() { Name = name });

                    db.Commit();
                }catch(Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
        //Bookテーブルの行データを習得
        public static List<BookModel> selectBook()
        {
            using(SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースに指定したSQLを発行
                    //ここにSQLが入るよ!
                    return db.Query<BookModel>("SELECT * FROM[Book]");
                }catch(Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }
    }
}
