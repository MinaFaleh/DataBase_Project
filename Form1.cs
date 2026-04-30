using System.Data.SqlClient;

namespace AirlinePhase2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AirlineDB;Integrated Security=True;");
                con.Open();

                string insertQuery = @"INSERT INTO Passengers (National_Id, Passport_No, Nationality, Gender, Name, Email, Phone_No) 
                           VALUES (@NID, @Passport, @Nat, @Gen, @Name, @Email, @Phone)";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.Add(new SqlParameter("@NID", txtNationalId.Text));
                cmd.Parameters.Add(new SqlParameter("@Passport", txtPassport.Text));
                cmd.Parameters.Add(new SqlParameter("@Nat", txtNationality.Text));
                cmd.Parameters.Add(new SqlParameter("@Gen", txtGender.Text));
                cmd.Parameters.Add(new SqlParameter("@Name", txtName.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", txtEmail.Text));
                cmd.Parameters.Add(new SqlParameter("@Phone", txtPhone.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Passenger successfully added to the system!");
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Error: A passenger with this National ID already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeletePassenger_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AirlineDB;Integrated Security=True;");
                con.Open();

                string deleteQuery = "DELETE FROM Passengers WHERE National_Id = @NID";

                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.Add(new SqlParameter("@NID", txtNationalId.Text));

                // ExecuteNonQuery returns the number of rows affected. 
                // If it is 0, it means the ID didn't exist in the database!
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Passenger successfully deleted from the system.");
                }
                else
                {
                    MessageBox.Show("No passenger found with that National ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtNationalId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
