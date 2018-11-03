using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuickEmailer;

namespace QuickEmailer
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            LoadCheckBox();





        }


        protected void LoadCheckBox()
        {
            List<string> list = Logic.agencyList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Agency Name", typeof(string));

            for (int i = 0; i < list.Count; i++)
            {
                string agencyName = list[i].ToString();
                if (!(agencyName == "EDH" || agencyName == "GovTechAdmin"))
                {
                    dt.Rows.Add(agencyName);
                }
            }

            CheckBoxList_agencies.DataSource = dt;
            CheckBoxList_agencies.DataTextField = "Agency Name";
            CheckBoxList_agencies.DataValueField = "Agency Name";
            CheckBoxList_agencies.DataBind();
        }

        protected void button_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxList_agencies.Items)
            {
                li.Selected = true;
            }
        }

        protected void button_DeselectAll_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxList_agencies.Items)
            {
                li.Selected = false;
            }
        }

        protected void button_submitEmail_Click(object sender, EventArgs e)
        {
            //loop through agencyList, those ticked, get the emails from db.

            List<string> selectedAgencies = new List<string>();

            for (int i = 0; i < CheckBoxList_agencies.Items.Count; i++)
            {
                if (CheckBoxList_agencies.Items[i].Selected)
                {
                    selectedAgencies.Add(CheckBoxList_agencies.Items[i].Text);
                }
            }


            //foreach (ListItem agency in CheckBoxList_agencies.Items)
            //{
            //    if (agency.Selected)
            //    {
            //        selectedAgencies.Add(agency.Value);
            //    }
            //}

            //List<string> selectedAgencies = CheckBoxList_agencies.Items.Cast<ListItem>()
            //    .Where(li => li.Selected)
            //    .Select(li => li.Value)
            //    .ToList();

            foreach (var v in selectedAgencies)
            {
                Console.WriteLine(v);
            }

          



            // concatenate title
            // get email body

            // for each agency, send the email






        }
    }
}








//var dir = @"C:/Users/Joel/source/repos/QuickEmailer/QuickEmailer/Agencies/";


//            try
//            {
//                var filesNames = Directory.EnumerateFiles(dir);

//                foreach (var fileName in filesNames)
//                {
//                    string agencyDotTxt = fileName.Split('/').Last();

//string agency = agencyDotTxt.Substring(0, agencyDotTxt.Length - 4);

//CheckBoxList_agencies.Items.Add(agency);
//                }


//            }
//            catch (Exception ex)
//            {

//            }