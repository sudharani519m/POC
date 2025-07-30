using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonExamples
{
    public partial class EmployeeAddress : Form
    {
        SqlConnection obj = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=sampleDB;Integrated Security =True;TrustServerCertificate=True");



        public EmployeeAddress()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                // SqlConnection obj = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=sampleDB;Integrated Security =True;TrustServerCertificate=True");

                SqlCommand cmd = new SqlCommand("insert into Employee values(@p1,@p2,@p3,@p4)", obj);

                cmd.Parameters.AddWithValue("@p1", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@p2", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@p3", txtEmpSal.Text);
                cmd.Parameters.AddWithValue("@p4", txtEmpAdd.Text);

                obj.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("record Inserted sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                //  SqlConnection obj = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=sampleDB;Integrated Security =True;TrustServerCertificate=True");

                SqlCommand cmd = new SqlCommand(" update employee set EmpName =@p2,EmpSalary = @p3,EmpAddress = @p4 where  EmpId = @p1", obj);

                cmd.Parameters.AddWithValue("@p1", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@p2", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@p3", txtEmpSal.Text);
                cmd.Parameters.AddWithValue("@p4", txtEmpAdd.Text);

                obj.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("record Update sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                // SqlConnection obj = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=sampleDB;Integrated Security =True;TrustServerCertificate=True");

                SqlCommand cmd = new SqlCommand(" delete employee  where  EmpId = @p1", obj);

                cmd.Parameters.AddWithValue("@p1", txtEmpId.Text);
               
                obj.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show(" delete record sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee where EmpId=@p1", obj);

            cmd.Parameters.AddWithValue("@p1", txtEmpId.Text);

            obj.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                txtEmpId.Text = dr[0].ToString();
                txtEmpName.Text = dr[1].ToString();
                txtEmpSal.Text = dr[2].ToString();
                txtEmpAdd.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Employee Id");
            }
            obj.Close();




        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select  * from Employee where EmpId=@p1 ", obj);

            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(txtEmpId.Text) - 1);

            obj.Open();

             SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                txtEmpId.Text = dr[0].ToString();
                txtEmpName.Text = dr[1].ToString();
                txtEmpSal.Text = dr[2].ToString();
                txtEmpAdd.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Employee Id");
            }
            obj.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Employee where EmpId=@p1 ", obj);

            cmd.Parameters.AddWithValue("@p1", Convert.ToInt32(txtEmpId.Text)  + 1);


            obj.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                txtEmpId.Text = dr[0].ToString();
                txtEmpName.Text = dr[1].ToString();
                txtEmpSal.Text = dr[2].ToString();
                txtEmpAdd.Text = dr[3].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Employee Id");
            }
            obj.Close();
        }
    }
}
