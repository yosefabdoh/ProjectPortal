using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectPortal.university
{
    public partial class SignUp : System.Web.UI.Page
    {
        public DataSet ds = new DataSet();
        SqlDataAdapter da;
        void load_data()
        {



            ds.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=ANDROID2W4356\MSSQLSERVER2017;Initial Catalog=ProjectsPortal;Integrated Security=True");



            da = new SqlDataAdapter("select * from UniversityType", con);
            da.Fill(ds, "UniversityType");
            DropUnvertype.DataSource = ds.Tables["UniversityType"];
            DropUnvertype.DataTextField = "TypeName";
            DropUnvertype.DataValueField = "TypeId";
            DropUnvertype.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_data();
            }
        }

        //protected void Submit_Click(object sender, EventArgs e)
        //{
        //    string CS = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(CS))
        //    {
        //        int y = 1; 
        //        SqlCommand cmd = new SqlCommand("CheckUserName", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        //string EnPassord = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassowrd.Text, "SHA1");
        //        SqlParameter username = new SqlParameter("@username", txtUserName.Text);
        //        SqlParameter password = new SqlParameter("@passowrd", txtPassowrd.Text);
        //        SqlParameter email = new SqlParameter("@email", txtEmail.Text);
        //        SqlParameter actype = new SqlParameter("@actype", y);
        //        SqlParameter acstatus = new SqlParameter("@acstatus", 1);
        //        cmd.Parameters.Add(username);
        //        cmd.Parameters.Add(password);
        //        cmd.Parameters.Add(email);
        //        cmd.Parameters.Add(actype);
        //        cmd.Parameters.Add(acstatus);
        //        con.Open();
        //        int ReturnCode = (int)cmd.ExecuteScalar();


        //        if (ReturnCode == -1)
        //        {

        //            feedback.Text = "هذا المستخدم موجود من قبل الرجاء ادخال اسم اخر";
        //        }

        //        else
        //        {
        //            string u;
        //            SqlCommand cmd2 = new SqlCommand();
        //            cmd2 = new SqlCommand("select max(AccountId) from Account ", con);
        //            u = cmd2.ExecuteScalar().ToString();

        //            cmd2 = new SqlCommand("insert into  University ([UnivName],[UnivType],[UnivFphone],[UnivSphone],[UnivSpokman],[UnivSpPhone],[ComercRegistNo],[AccountNo]) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8,p9)", con);
        //            cmd2.Parameters.AddWithValue("@p2", txtUnivName.Text);
        //            cmd2.Parameters.AddWithValue("@p3", DropUnvertype.Text);
        //            cmd2.Parameters.AddWithValue("@p4", txtUnivFphone.Text);
        //            cmd2.Parameters.AddWithValue("@p5", txtUnivSphone.Text);
        //            cmd2.Parameters.AddWithValue("@p6", txtUnivSpokman.Text);
        //            cmd2.Parameters.AddWithValue("@p7", txtUnivSpPhone.Text);
        //            cmd2.Parameters.AddWithValue("@p8", txtComercRegistNo.Text);
        //            cmd2.Parameters.AddWithValue("@p9", u);
        //            //  cmd.Parameters.AddWithValue("@p3", datatime);

        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            load_data();
        //            Response.Redirect("~/AddUnver.aspx");
        //        }

        //        //SqlParameter actype = new SqlParameter("@actype", DropUnvertype.Text);

        //    }
        //}
        protected void Submit_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                int y = 1;
                SqlCommand cmd = new SqlCommand("CheckUserName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string EnPassord = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassowrd.Text, "SHA1");
                SqlParameter username = new SqlParameter("@username", txtUserName.Text);
                SqlParameter password = new SqlParameter("@passowrd", EnPassord);
                SqlParameter email = new SqlParameter("@email", txtEmail.Text);
                SqlParameter actype = new SqlParameter("@actype", y);
                SqlParameter acstatus = new SqlParameter("@acstatus", 1);
                cmd.Parameters.Add(username);
                cmd.Parameters.Add(password);
                cmd.Parameters.Add(email);
                cmd.Parameters.Add(actype);
                cmd.Parameters.Add(acstatus);
                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();


                if (ReturnCode == -1)
                {

                    feedback.Text = "هذا المستخدم موجود من قبل الرجاء ادخال اسم اخر";
                }

                else
                {
                    
                    SqlCommand cmd2 = new SqlCommand("CheckandInsertUnevrs", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    SqlParameter univname = new SqlParameter("@p1", txtUnivName.Text);
                    SqlParameter Unvertype = new SqlParameter("@p2", DropUnvertype.Text);
                    SqlParameter UnivFphone = new SqlParameter("@p3", txtUnivFphone.Text);
                    SqlParameter UnivSphone = new SqlParameter("@p4", txtUnivSphone.Text);
                    SqlParameter UnivSpokman = new SqlParameter("@p5", txtUnivSpokman.Text);
                    SqlParameter UnivSpPhone = new SqlParameter("@p6", txtUnivSpPhone.Text);
                    SqlParameter ComercRegistNo = new SqlParameter("@p7", txtComercRegistNo.Text);
                    
                    cmd2.Parameters.Add(univname);
                    cmd2.Parameters.Add(Unvertype);
                    cmd2.Parameters.Add(UnivFphone);
                    cmd2.Parameters.Add(UnivSphone);
                    cmd2.Parameters.Add(UnivSpokman);
                    cmd2.Parameters.Add(UnivSpPhone);
                    cmd2.Parameters.Add(ComercRegistNo);
                    int ReturnCode2 = (int)cmd2.ExecuteScalar();
                    if (ReturnCode2 == -1)
                    {

                        feedback.Text = "هذه الجامعة موجود من قبل الرجاء ادخال اسم اخر";
                    }

                    else
                    {

                        Response.Redirect("~/AddUnver.aspx");
                    }
                }

                //SqlParameter actype = new SqlParameter("@actype", DropUnvertype.Text);

            }
        }
    }
}