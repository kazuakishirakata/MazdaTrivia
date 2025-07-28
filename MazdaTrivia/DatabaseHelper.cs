using System;
using System.Data.SQLite;
using System.IO;

public static class DatabaseHelper
{
    private static string dbPath = "TriviaDB.db";

    public static void EnsureDatabaseExists()
    {
        if (!File.Exists(dbPath))
        {
            SQLiteConnection.CreateFile(dbPath);
            using var con = new SQLiteConnection($"Data Source={dbPath};Version=3;");
            con.Open(); // you need the .Open() to edit the database

            string createTableSql = @"
                CREATE TABLE TriviaDB ( 
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Question TEXT NOT NULL,
                    Answer TEXT NOT NULL
                );
            "; 
            // Id is the unique identifier for each question, INTEGER PRIMARY KEY means there are no duplicates and no nulls in the entity
            /// AUTOINCREMENT means SQLite will automatically assign an increasing number everytime you insert a new row
            /// NOT NULL means it cannot be empty
            using var cmd = new SQLiteCommand(createTableSql, con);
            cmd.ExecuteNonQuery(); // this isn't to add, it's just the execute the command that is specified in the line above
        }
    }

    public static void InsertRow(string question, string answer)
    {//public static void InsertRow(string question, string answer)
        using var con = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        con.Open();

        //delete the bottom two
        //string question = "besides the name of the founder, what is the name “mazda” derived from? (hint: it is the zoroastrian god of harmony, intelligence and wisdom)";
        //string answer = "ahura mazda";

        string Sql = @"
            INSERT INTO TriviaDB  
            (Question, Answer) 
            VALUES 
            (@question, @answer)     
            ";

        using var cmd = new SQLiteCommand(Sql, con);
        cmd.Parameters.AddWithValue("@question", question);
        cmd.Parameters.AddWithValue("@answer", answer);

        cmd.ExecuteNonQuery();

    }

    public static (string question, string answer) GetRandomQuestion()
    {
        using var con = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        con.Open();

        string selectSql = "SELECT * FROM TriviaDB ORDER BY RANDOM() LIMIT 1"; // grabbing a row at random from TriviaDB
        using var cmd = new SQLiteCommand(selectSql, con);
        using var reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            string q = reader["Question"].ToString();
            string correct = reader["Answer"].ToString();
            return (q, correct);
        }
        return ("No question found, database empty...", "");
    }

    public static void UpdateRow(int id, string newquestion, string newanswer)
    {
        using var con = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        con.Open();

        string sql = @"
            UPDATE TriviaDB 
            SET Question = @question, Answer = @answer 
            WHERE Id = @Id";

        using var cmd = new SQLiteCommand(sql, con);
        cmd.Parameters.AddWithValue("@question", newquestion);
        cmd.Parameters.AddWithValue("@answer", newanswer);
        cmd.Parameters.AddWithValue("@Id", id);

        cmd.ExecuteNonQuery();
    }

    public static int GetRowCount()
    {
        using var con = new SQLiteConnection($"Data Source={dbPath};Version=3;");
        con.Open();

        string sql = "SELECT COUNT(*) FROM TriviaDB";

        using var cmd = new SQLiteCommand(sql, con);
        int count = Convert.ToInt32(cmd.ExecuteScalar());

        return count;
    }

}
