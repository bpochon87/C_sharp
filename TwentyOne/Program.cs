using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to the Party Animal Game Service. Start by entering your name:");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only and no decimals.");
            }

            Console.WriteLine($"Hello, {playerName}. Would you like to join a game of 21 right now?");
            string answer = Console.ReadLine().ToLower();
            if (answer.Contains("y"))
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"D:\Users\bpoch\Desktop\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                // Adding player to the game via overloaded operator from 'Player' class.
                game += player;
                player.isActivelyPlaying = true;
                // Continue game while these two conditions continue to be true.
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    // Always start with specific exceptions and then have more generic exceptions below.
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact SysAdmin.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        // Returning a method in a method that returns void ends the program immediately.
                        return;
                    }
                    
                }
                // After game is over, remove player from game.
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            Console.WriteLine("Feel free to look around the Animal House.\n");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            // This 'using' statement is for managing and controlling memory when dealing with external resources.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;Integrated Security=True;
                                        Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;
        }
    }
}
