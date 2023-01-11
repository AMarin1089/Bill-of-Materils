using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesProject
{
    internal class DBHelper
    {
        public static SqlConnection CreateConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-PQHA94J;Initial Catalog=BillOfMaterialsDB;Integrated Security=True";
            return conn;
        }

        #region Material
        public static bool IsMaterialWithIdPresent(decimal id)
        {
            bool isPresent = false;
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM MATERIALS WHERE MATERIAL_ID=@ID", con);
                SqlParameter par1 = new SqlParameter("@ID", SqlDbType.Decimal);
                par1.Value = id;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isPresent = true;
                    }
                    else
                    {
                        isPresent = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return isPresent;
        }

        public static bool IsMaterialWithName(string name)
        {
            bool isPresent = false;
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM MATERIALS WHERE MATERIAL_NAME=@Name", con);
                SqlParameter par1 = new SqlParameter("@Name", SqlDbType.VarChar);
                par1.Value = name;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isPresent = true;
                    }
                    else
                    {
                        isPresent = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return isPresent;
        }

        public static bool IsMaterialUsedInProduct(decimal id)
        {
            bool isPresent = false;
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM BOM WHERE MATERIAL_ID=@ID", con);
                SqlParameter par1 = new SqlParameter("@ID", SqlDbType.Decimal);
                par1.Value = id;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isPresent = true;
                    }
                    else
                    {
                        isPresent = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return isPresent;
        }

        public static int HowManyProductsMaterialIsPresent(decimal id)
        {
            int value = 0;
            SqlConnection con = CreateConnection();
            using (con)
            {
                
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM BOM WHERE MATERIAL_ID=@ID", con);
                SqlParameter par1 = new SqlParameter("@ID", SqlDbType.Decimal);
                par1.Value = id;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    value = (int)command.ExecuteScalar();

                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return value;
        }

        #endregion

        #region PriceList
        public static void DeleteAllPricesByMaterialId(decimal id)
        {
            {
                SqlConnection con = CreateConnection();
                using (con)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM PRICE_LIST WHERE MATERIAL_ID=@ID", con);
                    SqlParameter par1 = new SqlParameter("@ID", SqlDbType.Decimal);
                    par1.Value = id;
                    command.Parameters.Add(par1);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = command.ExecuteReader();
                    }

                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        #endregion

        #region Product
        public static bool IsProductWithIdPresent(decimal id)
        {
            bool isPresent = false;
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM PRODUCT WHERE PRODUCT_ID=@ID", con);
                SqlParameter par1 = new SqlParameter("@ID", SqlDbType.Decimal);
                par1.Value = id;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isPresent = true;
                    }
                    else
                    {
                        isPresent = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return isPresent;
        }

        public static bool IsProductWithName(string name)
        {
            bool isPresent = false;
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM PRODUCT WHERE PRODUCT_NAME=@Name", con);
                SqlParameter par1 = new SqlParameter("@Name", SqlDbType.VarChar);
                par1.Value = name;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isPresent = true;
                    }
                    else
                    {
                        isPresent = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return isPresent;
        }

        public static bool AlreadyHasSpecificationById(decimal id)
        {
            bool isPresent = false;
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM BOM WHERE PRODUCT_ID=@ID", con);
                SqlParameter par1 = new SqlParameter("@ID", SqlDbType.VarChar);
                par1.Value = id;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        isPresent = true;
                    }
                    else
                    {
                        isPresent = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return isPresent;
        }
        #endregion

        #region Expenses
        public static bool ExistsExpenseTypeByName(string expenseName)
        {
            string capitalizedExpenseName = expenseName.First().ToString().ToUpper() + String.Join("", expenseName.Skip(1));
            DataTable dt = new DataTable();
            SqlConnection con = CreateConnection();
            bool result = false;
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM EXPENCES WHERE EXPENCE_NAME=@Name", con);
                SqlParameter par1 = new SqlParameter("@Name", SqlDbType.VarChar);
                par1.Value = capitalizedExpenseName;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
                return result;
            }
        }

        internal static void InsertIntoBom(decimal productId, decimal materialId, decimal materialValue)
        {
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("INSERT INTO BOM VALUES(@ProductId, @MaterialId, @Value)", con);
                SqlParameter par1 = new SqlParameter("@ProductId", SqlDbType.Int);
                par1.Value = productId;
                command.Parameters.Add(par1);

                SqlParameter par2 = new SqlParameter("@MaterialId", SqlDbType.Int);
                par2.Value = materialId;
                command.Parameters.Add(par2);

                SqlParameter par3 = new SqlParameter("@Value", SqlDbType.Int);
                par3.Value = materialValue;
                command.Parameters.Add(par3);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public static void InsertExpense(string expenseName)
        {
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("INSERT INTO EXPENCES VALUES(@Name)", con);
                SqlParameter par1 = new SqlParameter("@Name", SqlDbType.VarChar);
                par1.Value = expenseName;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        #endregion

        #region Other Expenses
        public static void InsertOtherExpenses(decimal productId, decimal expenseId, decimal value)
        {
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("INSERT INTO OTHER_EXPENCES VALUES(@ProductId, @ExpenseId, @Value)", con);
                SqlParameter par1 = new SqlParameter("@ProductId", SqlDbType.Int);
                par1.Value = productId;
                command.Parameters.Add(par1);

                SqlParameter par2 = new SqlParameter("@ExpenseId", SqlDbType.Int);
                par2.Value = expenseId;
                command.Parameters.Add(par2);

                SqlParameter par3 = new SqlParameter("@Value", SqlDbType.Int);
                par3.Value = value;
                command.Parameters.Add(par3);

                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Close();
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        #endregion

        public static DataTable GetAllPrices()
        {
            DataTable dt = new DataTable();
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT m.MATERIAL_NAME, p.PRICE_DATE, p.PRICE_PRICE FROM PRICE_LIST p INNER JOIN MATERIALS m on m.MATERIAL_ID = p.MATERIAL_ID", con);
               
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    else
                    {
                        //
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return dt;
        }

        public static DataTable GetExpenseIdByExpenseName(string name)
        {
            DataTable dt = new DataTable();
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT EXPENCE_ID FROM EXPENCES WHERE EXPENCE_NAME = @Name", con);
                SqlParameter par1 = new SqlParameter("@Name", SqlDbType.VarChar);
                par1.Value = name;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    else
                    {
                        //
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return dt;
        }

        public static DataTable GetMaterialIdByMaterialName(string name)
        {
            DataTable dt = new DataTable();
            SqlConnection con = CreateConnection();
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT MATERIAL_ID FROM MATERIALS WHERE MATERIAL_NAME = @Name", con);
                SqlParameter par1 = new SqlParameter("@Name", SqlDbType.VarChar);
                par1.Value = name;
                command.Parameters.Add(par1);
                try
                {
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                    else
                    {
                        //
                    }
                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return dt;
        }

    }
}
