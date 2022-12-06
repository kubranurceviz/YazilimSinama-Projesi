using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace yaz.sın_4
{
    class PersonDataBase
    {
        SqlDataReader reader;
        SqlCommand command;
        DBConnection dBConnection = new DBConnection();
        public Person GetPerson(string hash)
        {
            Person person = null;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from tabloAdi where hash=@hash"; //Tablo adı düzeltilecek

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@hash", hash); //Sql tablosuna göre düzeltilecek 

                    reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        person = new Person()
                        {
                            //Sutun isimleri düzgün girilecek
                            // ID = int.Parse(reader["ID"].ToString()),
                            username = reader["Name"].ToString(),
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

            return person;
        }
        public Account GetAccount(string hash)
        {
            Account account = null;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "select * from tabloAdi where hash=@hash"; //Tablo adı düzeltilecek

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@hash", hash); //Sql tablosuna göre düzeltilecek 

                    reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        account = new Account()
                        {
                            //Sutun isimleri düzgün girilecek
                            // ID = int.Parse(reader["ID"].ToString()),
                            recycleCoin = reader.GetDouble(0),
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

            return account;
        }

        public int CreatePerson(Person p)
        {
            int result = 0;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "insert into tabloAdi () VALUES ()"; //Sorgu düzeltilecek
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@personname", p.username);//Paramtere eklenecek
                

                    result = command.ExecuteNonQuery();

                    Console.WriteLine($"{result} adet kayıt eklendi");

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

            return result;
        }
        public int CreateAccount(Account account)
        {
            int result = 0;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "insert into tabloAdi () VALUES ()"; //Sorgu düzeltilecek
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@personname", account.recycleCoin);//Paramtere eklenecek


                    result = command.ExecuteNonQuery();

                    Console.WriteLine($"{result} adet kayıt eklendi");

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

            return result;
        }

        public int Update(Account account)
        {
            int result = 0;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "update tabloAdi set ProductName=@productname, UnitPrice=@unitprice where ProductId=@productid"; //Sorgu düzeltilecek
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@productname", account.person.Hash);
                    command.Parameters.AddWithValue("@unitprice", account.recycleCoin);
                 

                    result = command.ExecuteNonQuery();

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

            return result;
        }


    }
}
