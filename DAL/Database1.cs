using System.Data.SQLite;

namespace DAL
{
    public class Database1
    {
        public SQLiteDataReader ReadFromDbStudents()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\User.DESKTOP-HT62HRR\Desktop\C#\lesson_9_Sqlite\SchoolApp-master\DAL\School.db");
            conn.Open();
            var command = new SQLiteCommand("SELECT * FROM Students", conn);
            var reader = command.ExecuteReader();
            return reader;
        }
        public SQLiteDataReader ReadFromDbTeachers ()
        {
            var conn = new SQLiteConnection(@"Data Source=C:\Users\User.DESKTOP-HT62HRR\Desktop\C#\lesson_9_Sqlite\SchoolApp-master\DAL\School.db");
            conn.Open();
            var command = new SQLiteCommand("SELECT * FROM Teachers", conn);
            var reader = command.ExecuteReader();
            return reader;
        }
    }
}
