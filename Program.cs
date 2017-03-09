using System;
using DbConnection;
namespace ConsoleApplication {
    public class User {
        public string FirstName;
        public string LastName;
        public string FavoriteColor;
        private int idtable1;
        public User (string nm, string nm2, string col, int id) {
            FirstName = nm;
            LastName = nm2;
            FavoriteColor = col;
            idtable1 = id;
        }
    }
    public class Program {
        public static void Main (string[] args) {
            //Placed inside the code block where you want to query the database
            var output = DbConnector.Query ("SELECT * FROM consoledb.users ;");
            foreach (var user in output) {
                foreach (string key in user.Keys) {
                    System.Console.WriteLine (key + ": "+ user[key]);
                }
                System.Console.WriteLine("--------------------------------");
            }
            //or
            DbConnector.Execute ("INSERT INTO `consoledb`.`users` (`FirstName`, `LastName`, `FavoriteNumber`) VALUES ('John', 'Smith', '3');");
        }
    }
}