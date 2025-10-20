
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace _91733_Quizmester_sd23e
{
    internal class Question
    {
        // properties for each question

        public string id { get; set; }
        public string QuestionText { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public int CorrectAnswer { get; set; }
        public int CategoryId { get; set; }

        // static method to fetch questions from db
        public static List<Question> FetchQuestions(int categoryId)
        {
            string connStr = @"Data Source=localhost\sqlexpress;Initial Catalog=quiz;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
            List<Question> questions = new List<Question>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string sql = "SELECT * FROM questions";
                if (categoryId != 0)
                    sql += " WHERE categoryId = @categoryId";

                sql += " ORDER BY NEWID()";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (categoryId != 0)
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(new Question
                            {
                                id = reader["id"].ToString(),
                                QuestionText = reader["questionText"].ToString(),
                                Answer1 = reader["answer1"].ToString(),
                                Answer2 = reader["answer2"].ToString(),
                                Answer3 = reader["answer3"].ToString(),
                                Answer4 = reader["answer4"].ToString(),
                                CorrectAnswer = (int)reader["correctAnswer"],
                                CategoryId = (int)reader["categoryId"]
                            });
                            Console.WriteLine($"Fetched {questions.Count} questions from DB");
                        }
                    }
                }
            }

            return questions;
        }
    }
}
