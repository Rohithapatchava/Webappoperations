using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Webappoperations
{
    public class adodatalayer
    {
        string constr = " ";
        public adodatalayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }



        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string sqlquery = "select * from Student";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }
            }
            catch (Exception Ex)
            {


            }
            return ds;
        }
        public DataSet Insertrecords()
        {
            DataSet dd = new DataSet();
            string sqlquery = "insert into Student values(5,'alex','javascript','11/2/2020') ";

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(sqlquery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(dd);
                }
            }
            catch (Exception Ex)
            {


            }
            return dd;
        }
        public DataSet GetaStudent(int id)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.CommandText = "PrGetaStudent";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet Insertrow(int id, string name, string course, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.Parameters.AddWithValue("@Sname", name);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "InsertRows";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch (Exception e)
            {


            }
            return ds;

        }

        public DataSet UpdateStudent(int id,string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "UpdateDate";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }
        public DataSet InsertData(int id, string name, string course, string date)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
                    cmd.Parameters.AddWithValue("@Sname", name);
                    cmd.Parameters.AddWithValue("@Course", course);
                    cmd.Parameters.AddWithValue("@StartDate", date);
                    cmd.CommandText = "InsertData";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch (Exception e)
            {


            }
            return ds;

        }
        public DataSet DeleteStudent(int id)

        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@SId", id);
              
                    cmd.CommandText = "UpdateDate";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }


            }
            catch (Exception e)
            {

            }
            return ds;
        }

    }
}
    
