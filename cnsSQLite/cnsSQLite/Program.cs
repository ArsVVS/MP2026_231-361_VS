using SQLite;

namespace cnsSQLite
{
    internal class Program
    {
        private static SQLiteConnection db;

        static void Main(string[] args)
        {
            db = new SQLiteConnection("myDB.db");
            db.CreateTable<Logs>();
            db.CreateTable<Users>();
        }
    }
}
