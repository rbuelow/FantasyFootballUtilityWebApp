using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FFwebApp.Models.PlayerPositions;

namespace FFwebApp.Repositories
{
    public class FootballStatsDbRepository
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["FootballStats"].ConnectionString;

        public static List<Individual> GetAllPlayers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                List<Individual> quarterbacks14 = new List<Individual>();

                SqlCommand command = new SqlCommand("select * FROM QuarterbacksFourteen WHERE PassYds IS NOT NULL", conn);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Models.PlayerPositions.Individual newPlayer = new Models.PlayerPositions.Individual
                    {
                        Name = reader.GetString(29),
                        PassYds = reader.GetInt32(9)
                    };
                    quarterbacks14.Add(newPlayer);
                }

                return quarterbacks14;
            }
        }
    }
}