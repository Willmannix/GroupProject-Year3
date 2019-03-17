using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuisnessLayer;
using BuisnessEntities;

namespace User_interface
{
    public partial class Statistics : Form
    {

        #region Instance Attributes
        IModel Model;
        FormContainer fc;
        #endregion

        public Statistics(FormContainer parent, IModel Model)
        {
            InitializeComponent();
            MdiParent = parent;
            fc = parent;
            this.Model = Model;
            Model.populateWorkOrders();
            Model.populateWorkOrders2();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.BringToFront();
            DateTime now = DateTime.Now;

            string day = now.Day.ToString();
            string month = now.Month.ToString();

            if (Int32.Parse(day) < 10 && Int32.Parse(day) > 0)
            {
                day = "0" + day;

            }

            if (Int32.Parse(month) < 10 && Int32.Parse(month) > 0)
            {
                month = "0" + month;

            }

            string year = now.Year.ToString();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                string[] split = workorder.PDate.Split(' ');
                string[] split1 = split[0].Split('/');
                string day1 = split1[0];
                string month1 = split1[1];
                string year1 = split1[2];

                if (day == day1 && month == month1 && year == year1)
                {
                    if (!dict.ContainsKey(workorder.Description.ToLower()))
                    {
                        dict.Add(workorder.Description.ToLower(), Int32.Parse(workorder.Quantity));
                    }
                    else if (dict.ContainsKey(workorder.Description.ToLower()))
                    {

                        dict[workorder.Description.ToLower()] += Int32.Parse(workorder.Quantity);




                    }


                }

            }

            chart1.Titles.Clear();
            chart1.Titles.Add("Most products made");
            chart1.Series["p1"].IsValueShownAsLabel = true;
            foreach (KeyValuePair<string, int> entry in dict)
            {
                chart1.Series["p1"].Points.AddXY(entry.Key, entry.Value);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.BringToFront();
            DateTime now = DateTime.Now;
            string day = now.Day.ToString();
            string month = now.Month.ToString();
            List<int> list = new List<int>();
            Model.populateWorkOrderComponents2();
            Model.populateWorkOrderComponents();
            Model.populateWorkOrders();
            Model.populateWorkOrders2();

            if (Int32.Parse(day) < 10 && Int32.Parse(day) > 0)
            {
                day = "0" + day;

            }

            if (Int32.Parse(month) < 10 && Int32.Parse(month) > 0)
            {
                month = "0" + month;

            }

            string year = now.Year.ToString();

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                string[] split = workorder.PDate.Split(' ');
                string[] split1 = split[0].Split('/');
                string day1 = split1[0];
                string month1 = split1[1];
                string year1 = split1[2];

                if (day == day1 && month == month1 && year == year1)
                {
                    list.Add(Int32.Parse(workorder.WorkOrderNo));
                }
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (BuisnessEntities.Components components in Model.ComponentList)
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    if (Int32.Parse(components.WorkOrderNo) == list[i])
                    {
                        if (!dict.ContainsKey(components.ComponentName.ToLower()))
                        {
                            dict.Add(components.ComponentName.ToLower(), Int32.Parse(components.Quantity));
                        }
                        else if (dict.ContainsKey(components.ComponentName.ToLower()))
                        {

                            dict[components.ComponentName.ToLower()] += Int32.Parse(components.Quantity);




                        }
                    }
                }

            }

            chart2.Titles.Clear();
            chart2.Titles.Add("Most components used");
            chart2.Series["p2"].IsValueShownAsLabel = true;
            foreach (KeyValuePair<string, int> entry in dict)
            {
                chart2.Series["p2"].Points.AddXY(entry.Key, entry.Value);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chart2.BringToFront();
            
            DateTime now = DateTime.Now;
            string day = now.Day.ToString();
            string month = now.Month.ToString();
            int[] count = new int[2];
            Model.populateWorkOrderComponents2();
            Model.populateWorkOrderComponents();
            Model.populateWorkOrders();
            Model.populateWorkOrders2();

            if (Int32.Parse(day) < 10 && Int32.Parse(day) > 0)
            {
                day = "0" + day;

            }

            if (Int32.Parse(month) < 10 && Int32.Parse(month) > 0)
            {
                month = "0" + month;

            }

            string year = now.Year.ToString();

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            foreach (BuisnessEntities.WorkOrder workorder in Model.WorkOrderList)
            {
                string[] split = workorder.PDate.Split(' ');
                string[] split1 = split[0].Split('/');
                string day1 = split1[0];
                string month1 = split1[1];
                string year1 = split1[2];

                if (day == day1 && month == month1 && year == year1)
                {
                    if (Int32.Parse(workorder.FlaggedforQC) == 0)
                    {
                        if (workorder.Process == "FailedQC")
                        {
                            count[0]++;
                        }
                        if(workorder.Process == "Finished")
                        {
                            count[1]++;
                        }
                    }
                }
            }

            chart2.Titles.Clear();
            chart2.Titles.Add("Quality Control statistics");
            chart2.Series["p2"].IsValueShownAsLabel = true;

            chart2.Series["p2"].Points.AddXY("Failed", count[0]);
            chart2.Series["p2"].Points.AddXY("Passed", count[1]);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
