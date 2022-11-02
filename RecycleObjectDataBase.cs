using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace yaz.sın_4
{
    public class RecycleObjectDataBase
    {
        SqlDataReader reader;
        SqlCommand command;
        private SqlConnection GetMsSqlConnection()
        {
            string connectionString = "Data Source=!!"; //Sql adresi girilecek
            return new SqlConnection(connectionString);
        }

        #region Bütün atık nesnlelerin sqlden veri çekme methodu
        public List<RecycleObject> GetAllProducts()
        {
            List<RecycleObject> recycleObjects = null;

            using (var connection = GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from tabloAdi"; //Tablo adı düzeltilecek

                    command = new SqlCommand(sql, connection);

                    reader = command.ExecuteReader();
                    recycleObjects = new List<RecycleObject>();

                    while (reader.Read())
                    {
                        recycleObjects.Add(
                            new RecycleObject
                            {
                                //Sutun isimleri düzgün girilecek
                                // ID= int.Parse(reader["ID"].ToString()),
                                recycleObjectName = reader["Name"].ToString(),
                                carbonAmount = int.Parse(reader["point"]?.ToString())
                              
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
        public RecycleObject GetProductById(int id)
        {
            RecycleObject recycleObject = null;

            using (var connection = GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from tabloAdi where Id=@id"; //Tablo adı düzeltilecek

                     command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@id", id); //Sql tablosuna göre düzeltilecek 

                    reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        recycleObject = new RecycleObject()
                        {
                           //Sutun isimleri düzgün girilecek
                           // ID = int.Parse(reader["ID"].ToString()),
                            recycleObjectName = reader["Name"].ToString(),
                           // recyclePoint = int.Parse(reader["point"]?.ToString())
                           
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

        #region Girilen isime göre  sqlden veri çekme methodu
        public List<RecycleObject> Find(string name)
        {
            List<RecycleObject> recyclesObjects = null;

            using (var connection = GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from tabloAdi where name LIKE %@name%";  //Tablo adı düzeltilecek

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@name", name); //Sql tablosuna göre düzeltilecek 

                    reader = command.ExecuteReader();

                    recyclesObjects = new List<RecycleObject>();

                    while (reader.Read())
                    {
                        recyclesObjects.Add(
                            new RecycleObject
                            {
                                //Sutun isimleri düzgün girilecek
                                //ID = int.Parse(reader["ID"].ToString()),
                                recycleObjectName = reader["Name"].ToString(),
                               // recyclePoint = int.Parse(reader["point"]?.ToString())
                                
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

            return recyclesObjects;
        }
        #endregion
    }
}
