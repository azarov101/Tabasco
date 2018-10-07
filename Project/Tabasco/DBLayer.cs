using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestDB
{
    public class DBLayer
    {
        private static  string connectionString = "Data Source=prjgr3.ddns.net\\SQLEXPRESS,1433;"+
        "Network Library=DBMSSOCN;Initial Catalog=Tabasco;User ID=sa;Password=Tabasco123";
        public static SqlConnection con= new SqlConnection(connectionString);

        /// <summary>
        /// insert value to table. 
        /// the insertion is done by columns and valus according: every column have a value(in values) in same index.
        /// example: table="Suppliers", columns={"code","name"}, values={"1","'Ariel'"}
        /// it inserts this in new row
        /// </summary>
        /// <param name="table">name of table(string)</param>
        /// <param name="columns">names of columns(array of string)</param>
        /// <param name="values">values that inserts(array of string)</param>
        public static void insert(string table,string[] columns,string[] values)
        {
            try {
                string allFields = "";
                string allValues = "";
                for (int i = 0; i < columns.Length; i++)
                {
                    if (i + 1 < columns.Length)
                    {
                        allFields += columns[i] + ", ";
                        allValues += values[i] + ", ";
                    }
                    else
                    {
                        allFields += columns[i];
                        allValues += values[i];
                    }
                }
                using(SqlCommand cmd=new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText= "INSERT into "+table+" ("+allFields+") VALUES ("+allValues+")";
                    try
                    {
                        con.Open();
                        int recordsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch(IndexOutOfRangeException e)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
            }
        }

        /// <summary>
        /// delete value from table. the condition are boolean expression that first argument is column name
        /// and second is value
        /// example: table="Suppliers", conditions={"Id=123456789","Name='Ariel'"} ,its delete the supplier that his details are
        /// id=123456789 and Name=Ariel
        /// </summary>
        /// <param name="table">name of table(string)</param>
        /// <param name="conditions">list of conditions(array of string).you can send null if there are no conditions</param>
        public static void delete(string table, string[] conditions)
        {
            try
            {
                string allConditions = "";
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (i + 1 < conditions.Length)
                        allConditions += conditions[i] + "AND ";
                    else
                        allConditions += conditions[i];
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "DELETE FROM " + table + " WHERE " + allConditions;
                    try
                    {
                        con.Open();
                        int recordsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
            }
        }
        /// <summary>
        /// update values in table. the assignment is done by columns and valus according: every column have a value (in values) in same index.
        /// the conditions to the change are located in "conditions"
        /// example: table="Suppliers", columns={"name"}, values={"'Ariel'"}, conditions={"code = 2"}
        /// it changes the name of the row with code 2 to Ariel 
        /// </summary>
        /// <param name="table">name of table(string)</param>
        /// <param name="columns">names of columns that will be updated(array of string)</param>
        /// <param name="values">new values(array of string)</param>
        /// <param name="conditions"></param>
        public static void update(string table, string[] columns, string[] values,string[] conditions)
        {
            try
            {
                string setValues = "";
                string allConditions = "";
                for (int i = 0; i < columns.Length; i++) //concatenation columns with values
                {
                    if (i + 1 < columns.Length)
                        setValues += columns[i] + " = " + values[i] + ", ";
                    else
                        setValues += columns[i] + " = " + values[i];
                }
                if (conditions != null)
                {
                    for (int i = 0; i < conditions.Length; i++) //concatenation conditions
                    {
                        if (i == 0)
                            allConditions += " WHERE ";
                        if (i + 1 < columns.Length)
                            allConditions += conditions[i] + " AND ";
                        else
                            allConditions += conditions[i];
                    }
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE " + table + " SET " + setValues + allConditions;
                    try
                    {
                        con.Open();
                        int recordsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
            }
        }
        /// <summary>
        /// import table from database
        /// ***importat- closing the connection after use, for example:
        /// DBLayer.con.close();
        /// </summary>
        /// <param name="table">sources of details</param>
        /// <param name="columns">you can send * to import all columns or send specific columns</param>
        /// <param name="conditions">condition to import. you can send null if there are no conditions</param>
        /// <returns>object of reader that enabler to move on the rows</returns>
        public static SqlDataReader select(string[] tables, string[] columns, string[] conditions)
        {
            try
            {
                string allTables = "";
                string allColumns = "";
                string allConditions = "";
                for (int i = 0; i < tables.Length; i++) //concatenation tables
                {
                    if (i + 1 < tables.Length)
                        allTables += tables[i] + ", ";
                    else
                        allTables += tables[i];
                }
                for (int i = 0; i < columns.Length; i++) //concatenation columns
                {
                    if (i + 1 < columns.Length)
                        allColumns += columns[i]+ ", ";
                    else
                        allColumns += columns[i];
                }
                if (conditions != null)
                {
                    for (int i = 0; i < conditions.Length; i++) //concatenation conditions
                    {
                        if (i == 0)
                            allConditions += " WHERE ";
                        if (i + 1 < columns.Length)
                            allConditions += conditions[i] + " AND ";
                        else
                            allConditions += conditions[i];
                    }
                }
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT " + allColumns + " FROM " + allTables + allConditions;
                    try
                    {
                        con.Open();
                        return cmd.ExecuteReader();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
                        return null;
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", e.Message));
                return null;
            }
        }
    }
}
