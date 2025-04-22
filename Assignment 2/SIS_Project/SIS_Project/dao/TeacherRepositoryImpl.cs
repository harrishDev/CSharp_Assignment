using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SIS_Project.entity;
using SIS_Project.util;
using Microsoft.Data.SqlClient;

namespace SIS_Project.dao
{
    public class TeacherRepositoryImpl : ITeacherRepository
    {
        

        public void AddTeacher(Teacher teacher)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Teacher (first_name, last_name, email) " +
                               "VALUES (@FirstName, @LastName, @Email)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FirstName", teacher.FirstName);
                cmd.Parameters.AddWithValue("@LastName", teacher.LastName);
                cmd.Parameters.AddWithValue("@Email", teacher.Email);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTeacher(int teacherId)
        {
            using (SqlConnection conn = DBConnUtil.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Teacher WHERE teacher_id=@TeacherId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();

            using (SqlConnection conn = DBConnUtil.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Teacher";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    teachers.Add(new Teacher(
                        Convert.ToInt32(reader["teacher_id"]),
                        reader["first_name"].ToString(),
                        reader["last_name"].ToString(),
                        reader["email"].ToString()
                    ));
                }
            }

            return teachers;
        }
    }
}
