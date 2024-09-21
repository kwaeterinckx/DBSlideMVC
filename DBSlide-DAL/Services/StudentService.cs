using DBSlide_Common.Repositories;
using DBSlide_DAL.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DBSlide_DAL.Mapper;

namespace DBSlide_DAL.Services
{
    public class StudentService : BaseService, IStudentRepository<Student>
    {
        public StudentService(IConfiguration configuration) : base(configuration, "DBSlideMVC")
        {
        }

        #region CREATE
        public int Insert(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Student_Create";
                    command.Parameters.AddWithValue("FirstName", student.FirstName);
                    command.Parameters.AddWithValue("LastName", student.LastName);
                    command.Parameters.AddWithValue("BirthDate", student.BirthDate);
                    command.Parameters.AddWithValue("Login", student.Login);
                    command.Parameters.AddWithValue("SectionId", student.SectionId);
                    command.Parameters.AddWithValue("YearResult", (object?)student.YearResult ?? DBNull.Value);
                    command.Parameters.AddWithValue("CourseId", (object?)student.CourseId ?? DBNull.Value);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        #endregion

        #region READ
        #region - List
        public IEnumerable<Student> Get()
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Student_GetAll";

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToDAL();
                        }
                    }
                }
            }
        }
        #endregion
        #region - Details
        public Student Get(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Student_GetById";
                    command.Parameters.AddWithValue("StudentId", studentId);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToDAL();
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException(nameof(studentId));
                        }
                    }
                }
            }
        }
        #endregion

        #endregion

        #region UPDATE
        public int Update(Student student)
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Student_Update";
                    command.Parameters.AddWithValue("StudentId", student.StudentId);
                    command.Parameters.AddWithValue("FirstName", student.FirstName);
                    command.Parameters.AddWithValue("LastName", student.LastName);
                    command.Parameters.AddWithValue("BirthDate", student.BirthDate);
                    command.Parameters.AddWithValue("Login", student.Login);
                    command.Parameters.AddWithValue("SectionId", student.SectionId);
                    command.Parameters.AddWithValue("YearResult", (object?)student.YearResult ?? DBNull.Value);
                    command.Parameters.AddWithValue("CourseId", (object?)student.CourseId ?? DBNull.Value);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }
        #endregion

        #region DELETE
        public void Delete(int studentId)
        {
            using (SqlConnection connection = new SqlConnection(_ConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Student_Delete";
                    command.Parameters.AddWithValue("StudentId", studentId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
