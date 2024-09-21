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

        #region READ

        #region - Read All
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

        #region - Read By Id
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
    }
}
