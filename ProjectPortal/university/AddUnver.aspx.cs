using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace ProjectPortal.university
{
    public partial class AddUnver : System.Web.UI.Page
    {
        public DataSet ds = new DataSet();
        SqlDataAdapter da;
        void load_data()
        {



            ds.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=ANDROID2W4356\MSSQLSERVER2017;Initial Catalog=ProjectsPortal;Integrated Security=True");


            da = new SqlDataAdapter("select * from Standards", con);
            da.Fill(ds, "Standards");
            DropRequirStandar.DataSource = ds.Tables["Standards"];
            DropRequirStandar.DataTextField = "StandarName";
            DropRequirStandar.DataValueField = "StandarId";
            DropRequirStandar.DataBind();
            //da = new SqlDataAdapter("select * from gearboxType", con);
            //da.Fill(ds, "gearboxType");
            //dropGearBox.DataSource = ds.Tables["gearboxType"];
            //dropGearBox.DataTextField = "lime_name";
            //dropGearBox.DataValueField = "lime_id";
            //dropGearBox.DataBind();
            //da = new SqlDataAdapter("select * from carcolore", con);
            //da.Fill(ds, "carcolore");
            //DropColor.DataSource = ds.Tables["carcolore"];
            //DropColor.DataTextField = "colore_name";
            //DropColor.DataValueField = "colore_id";
            //DropColor.DataBind();
            //da = new SqlDataAdapter("select * from fuelsType", con);
            //da.Fill(ds, "fuelsType");
            //DropFuelsType.DataSource = ds.Tables["fuelsType"];
            //DropFuelsType.DataTextField = "Fuel_type_name";
            //DropFuelsType.DataValueField = "Fuel_type_id";
            //DropFuelsType.DataBind();
            //da = new SqlDataAdapter("select * from supplyingtype", con);
            //da.Fill(ds, "supplyingtype");
            //DropSupply.DataSource = ds.Tables["supplyingtype"];
            //DropSupply.DataTextField = "Incoming type_name";
            //DropSupply.DataValueField = "Incoming type_id";
            //DropSupply.DataBind();
            //da = new SqlDataAdapter("select * from Cardoor", con);
            //da.Fill(ds, "Cardoor");
            //DropDoors.DataSource = ds.Tables["Cardoor"];
            //DropDoors.DataTextField = "Emblems-name";
            //DropDoors.DataValueField = "Emblems_id";
            //DropDoors.DataBind();
            //da = new SqlDataAdapter("select * from cylinderNo", con);
            //da.Fill(ds, "cylinderNo");
            //DropCylender.DataSource = ds.Tables["cylinderNo"];
            //DropCylender.DataTextField = "baston_name";
            //DropCylender.DataValueField = "baston_id";
            //DropCylender.DataBind();


        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_data();
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=ANDROID2W4356\MSSQLSERVER2017;Initial Catalog=ProjectsPortal;Integrated Security=True");

        protected void btnbrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into  SuggestedProjects  ([ProjName],[ProjIdea],[ProjDetails],[RequirStandar],[RequirCompletPer]) values(@p1,@P2,@p3,@p4,@p5)", con);
                    cmd.Parameters.AddWithValue("@p1", txtProjName.Text);
                    cmd.Parameters.AddWithValue("@p2", txtProjIdea.Text);
                    cmd.Parameters.AddWithValue("@p3", txtProjDetails.Text);
                    cmd.Parameters.AddWithValue("@p4", DropRequirStandar.Text);
                    cmd.Parameters.AddWithValue("@p5", txtRequirCompletPer.Text);
                    //cmd.Parameters.AddWithValue("@p6", txtSuggestSide.Text);
                  
                    cmd.ExecuteNonQuery();
                    string u;
                    cmd = new SqlCommand("select max(car_id) from car ", con);
                    u = cmd.ExecuteScalar().ToString();


                    cmd.ExecuteNonQuery();
                    con.Close();
                    load_data();

                }
                Label1.Text = "تم الحفظ";

                //Response.Write("OK");
            }
            catch (Exception ex)
            {
                //Response.Write(ex.Message);
            }
        }
    }
}