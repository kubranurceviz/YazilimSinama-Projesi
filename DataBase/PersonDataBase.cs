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

                    string sql = "select * from Person where hashCode=@hash"; //Tablo adı düzeltilecek

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@hash", hash); //Sql tablosuna göre düzeltilecek 

                    reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        person = new Person()
                        {
                            username = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                            lastname = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                            firstname = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                            password = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                            email= reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            Hash = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
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

                    string sql = "select * from Account where hashCode=@hash"; //Tablo adı düzeltilecek

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@hash", hash); //Sql tablosuna göre düzeltilecek 

                    reader = command.ExecuteReader();

                    reader.Read();

                    if (reader.HasRows)
                    {
                        account = new Account()
                        {                
                           recycleCoin = reader.GetDouble(1)
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

                    string sql = "insert into Person (username,lastname,firstname,password,hashCode,email) values(@username,@lastname,@firstname,@password,@hashCode,@email)"; 
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@username", p.username);
                    command.Parameters.AddWithValue("@lastname", p.lastname);
                    command.Parameters.AddWithValue("@firstname", p.firstname);
                    command.Parameters.AddWithValue("@password", p.password);
                    command.Parameters.AddWithValue("@hashCode", p.Hash);
                    command.Parameters.AddWithValue("@email", p.email);

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
        public int CreateAccount(Account account)
        {
            int result = 0;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "insert into Account (hashCode,recycleCoin) VALUES (@hashCode,@recycleCoin)"; 
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@recycleCoin", account.recycleCoin);
                    command.Parameters.AddWithValue("@hashCode", account.person.Hash);

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

        public int Update(Account account)
        {
            int result = 0;

            using (var connection = dBConnection.GetMsSqlConnection())
            {
                try
                {
                    connection.Open();

                    string sql = "update Account set recycleCoin=@recycleCoin where hashCode=@hashCode"; 
                    SqlCommand command = new SqlCommand(sql, connection);

                    command.Parameters.AddWithValue("@hashCode", account.person.Hash);
                    command.Parameters.AddWithValue("@recycleCoin", account.recycleCoin);

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
