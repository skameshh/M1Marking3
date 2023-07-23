using OCSMarkingDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSMarking3
{
    public partial class Form1 : Form
    {
        private static String NEW_LINE = Environment.NewLine;// "\n";

        private static String App_version = "v0.1.8";
        public Form1()
        {
            InitializeComponent();            
            cboSizes.SelectedIndex = 0;
           lblMainTitle.Text = "In-Machine Marking Program for Multus [" + App_version + "] [API:"+ Marking.Version+"]";
        }

        // private static string prefix_GC_prod_ord = "M ";
        // private static string prefix_prod_ord = "P:";
        // private static string prefix_part_num = "M:";
        // private static string prefix_batch_num = "B:";


        private bool doGen(bool onlyPreview)
        {
            //bool flag2;
            string bu = string.Empty;
            double dia = 0.0;
            double locationx = 0.0;

            //

            if (txtPartDia.Text.Length < 1)
            {
                MessageBox.Show("Please enter Part Diameter ");
                txtPartDia.Focus();
                return false;
            }
            else
            {
                double val = 0.0;
                bool bb = Double.TryParse(txtPartDia.Text, out val);
                if (bb)
                {
                    dia = Double.Parse(txtPartDia.Text);
                }
                else
                {
                    MessageBox.Show("Part Diameter : Please only enter double value ");
                    return false;
                }
                
            }

            if (txtMarkingLocationX.Text.Length < 1)
            {
                MessageBox.Show("Please enter Marking Location X ");
                txtMarkingLocationX.Focus();
                return false;
            }
            else
            {
                double val = 0.0;
                bool bb = Double.TryParse(txtMarkingLocationX.Text, out val);
                if (bb)
                {
                    locationx = Double.Parse(txtMarkingLocationX.Text);
                }
                else
                {
                    MessageBox.Show("Marking Location X : Please only enter double value ");
                    return false;
                }
            }

            if (txtMaterialNum.Text.Length < 1)
            {
                MessageBox.Show("Please enter material number ");
                txtMaterialNum.Focus();
                return false;
            }            

            if (txtDrawOldMaterialNum.Text.Length < 1)
            {
                MessageBox.Show("Please enter Old material number ");
                txtDrawOldMaterialNum.Focus();
                return false;
            }

            if (txtBatchNum.Text.Length < 1)
            {
                MessageBox.Show("Please enter batch number ");
                txtBatchNum.Focus();
                return false;
            }

            if (txtThreadDetails.Text.Length < 1)
            {
                MessageBox.Show("Please enter thread details ");
                txtThreadDetails.Focus();
                return false;
            }

            bu = Marking.BU_GC;
                      

            //public static String GetMarkingInfo(String machine_id,  string char_size, string bu, string material_number, 
            //string old_material_number, string drawing_rev, string batch_number, string customs, string thread1, string thread2)

            //0.250
            //0.125

            string size = string.Empty;
            if (cboSizes.Text.Equals("0.250"))
            {
                size = Marking.Marking_size_0_25inch;
            }
            else if (cboSizes.Text.Equals("0.125"))
            {
                size = Marking.Marking_size_0_125inch;
            }
            else if (cboSizes.Text.Equals("0.19"))
            {
                size = Marking.Marking_size_0_19inch;
            }
            else if (cboSizes.Text.Equals("0.090"))
            {
                size = Marking.Marking_size_0_090inch;
            }

            string machine = string.Empty;           

            if (!onlyPreview) {

             // public static String GetMarkingInfo( string char_size, string bu, double marking_locationX, double partDia, string material_num,
             //string old_material_number, string serial_num,  string customs, string thread1, string thread2)

            String res = Marking.GetMarkingInfo( size, bu, locationx,
            dia, txtMaterialNum.Text, txtDrawOldMaterialNum.Text, txtBatchNum.Text, txtCustomsOrigin.Text, txtThreadDetails.Text, "");

            txtResult.Text = res;
            Console.WriteLine("Res = " + res);
            }

            txtPreview.Text = Marking.GetMarkingPreview ( size, bu, locationx, dia, txtMaterialNum.Text, 
                txtDrawOldMaterialNum.Text , txtBatchNum.Text, txtThreadDetails.Text, "");
            
            return false;
        }

        private void clearOutput()
        {
            this.txtPreview.Text = "";
            this.txtResult.Text = "";
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            this.clearOutput();
            this.doGen(false);
        }

        private void reset()
        {
            txtBatchNum.Text = "";
            txtMaterialNum.Text = "";
            txtDrawOldMaterialNum.Text = "";
            txtPartDia.Text = "";
            
            txtResult.Text = "";
            txtPreview.Text = "";
        }

        private void doMachine()
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MMM-dd");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void rdoICI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            doMachine();
            //reset();
        }

        private void rdoGCLH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnGenPreview_Click(object sender, EventArgs e)
        {
            this.clearOutput();
            this.doGen(true);

        }
    }
}