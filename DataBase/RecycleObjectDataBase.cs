using System;
using System.Collections.Generic;
using System.Data.SqlClient;



namespace yaz.sın_4
{
    public class RecycleObjectDataBase
    {
        SqlDataReader reader;
        SqlCommand command;
        DBConnection dBConnection = new DBConnection();

        #region Bütün atık nesnlelerin sqlden veri çekme methodu
        public List<RecycleObject> GetAllRecycleObject()
        {
            List<RecycleObject> recycleObjects = null;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from RecycleObject"; 

                    command = new SqlCommand(sql, connection);

                    reader = command.ExecuteReader();
                    recycleObjects = new List<RecycleObject>();

                    while (reader.Read())
                    {
                        recycleObjects.Add(
                            new RecycleObject
                            {
                                carbonAmount = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                                typeOfRecycle = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                recycleObjectName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0)
                            }
                        );
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return recycleObjects;
        }
        #endregion

        #region  Idye göre sqlden veri çekme methodu
        public RecycleObject GetRecycleObjectById(int id)
        {
            RecycleObject recycleObject = null;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from RecycleObject where id=@id"; 

                     command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", id); 

                    reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        recycleObject = new RecycleObject()
                        {
                            carbonAmount = reader.IsDBNull(1) ? 0 : reader.GetInt32(1), 
                            typeOfRecycle = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            recycleObjectName = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                            ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0)

                    };
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return recycleObject;
        }
        #endregion

    }
}
