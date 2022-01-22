using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Animal_Project
{
    class Datahandler
    {
        public Datahandler() { }

        public SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog = Animals;Integrated Security=SSPI");
        SqlCommand cmd = new SqlCommand();
        

        public void RegisterPeople(string username, string password , string accounttype) 
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    cmd = new SqlCommand("register", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mode", "reg");
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@acctype", accounttype);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("User Has Been Registered");

                }

            }
            catch (Exception c)
            {

                MessageBox.Show("AddPeople()"+ c.Message);
            }
        } //works

        public void AddAnimal(int id ,string food, string purpose, string name, string nickname, string dateOfBirth, string gender, string typeOfAnimal, byte [] image ) 
        {
            try
            {            
                 if(conn.State == ConnectionState.Closed)
                 {
                    conn.Open();
                    cmd = new SqlCommand("AddAnimals", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mode", "AddAnimals");
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Nickname", nickname);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@TypeOFAnimal", typeOfAnimal);
                    cmd.Parameters.AddWithValue("@DateOFBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@TypeofFood", food);
                    cmd.Parameters.AddWithValue("@Purpose", purpose);
                    cmd.Parameters.AddWithValue("@Image", image);
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Your Animal Has Been Added");
                 }
            }
            catch (Exception a)
            {

                MessageBox.Show(" public void AddAnimal()  " + a.Message);
            }
        } // works

        public void RemoveAnimal(int id)
        {
            try
            {
                if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    cmd = new SqlCommand("DeleteAnimal", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Animal Has been Removed From The Database.");
                    conn.Close();
                    
                }
            }
            catch (Exception b)
            {

                MessageBox.Show("public void RemoveAnimal() " + b.Message);
            }
        } // works 

    }
}
