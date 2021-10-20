using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsAppPREP1
{
    public partial class frmAreaConvert : Form
    {
        public frmAreaConvert()
        { InitializeComponent(); }
        void Reset()
        {
            textBox1.Text = "0"; textBox2.Text = "0";
            textBox3.Text = "0"; textBox4.Text = "0";
            textBox1.ReadOnly = false; textBox2.ReadOnly = false;
            textBox3.ReadOnly = false; textBox4.ReadOnly = false;
            textBox5.Text = "0"; textBox6.Text = "0";
            textBox7.Text = "0"; textBox8.Text = "0";
            this.Text = "Your full name";
        }
        Solution Prep.Midterm Exam Windows FormMaftei Mihai
        Maftei Mihai
        Page 5 of 4
5
 //declare the object as global variable
         ConvertArea ca1;
        private void frmAreaConvert_Load(object sender, EventArgs e)
        {
            ca1 = new ConvertArea(); //create the object calling the constructor
            Reset(); //call the global method
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset(); //call the global method
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal =
           Convert.ToByte(MessageBox.Show("Exit?", "Title", MessageBoxButtons.OKCancel));
            //MessageBox.Show(btnVal.ToString());
            if (btnVal == 1)
            { this.Close(); }
            else
            {
                Reset(); //call the global method
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                ca1.EnteredValue = Convert.ToDouble(textBox1.Text);
                textBox2.Text = ca1.SqCmSqIn().ToString();
                textBox1.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                ca1.EnteredValue = Convert.ToDouble(textBox3.Text);
                textBox4.Text = ca1.SqMSqYd().ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                ca1.EnteredValue = Convert.ToDouble(textBox5.Text);
                textBox6.Text = ca1.HectarAcres().ToString();
                textBox5.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //declare the object as global variable
        ConvertArea ca1;
        private void frmAreaConvert_Load(object sender, EventArgs e)
        {
            ca1 = new ConvertArea(); //create the object calling the constructor
            Reset(); //call the global method
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset(); //call the global method
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            byte btnVal = 0;
            btnVal =
           Convert.ToByte(MessageBox.Show("Exit?", "Title", MessageBoxButtons.OKCancel));
            //MessageBox.Show(btnVal.ToString());
            if (btnVal == 1)
            { this.Close(); }
            else
            {
                Reset(); //call the global method
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                ca1.EnteredValue = Convert.ToDouble(textBox1.Text);
                textBox2.Text = ca1.SqCmSqIn().ToString();
                textBox1.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            try
            {
                ca1.EnteredValue = Convert.ToDouble(textBox3.Text);
                textBox4.Text = ca1.SqMSqYd().ToString();
                textBox3.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                ca1.EnteredValue = Convert.ToDouble(textBox5.Text);
                textBox6.Text = ca1.HectarAcres().ToString();
                textBox5.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            private void btn4_Click(object sender, EventArgs e)
            {
                try
                {
                    ca1.EnteredValue = Convert.ToDouble(textBox7.Text);
                    textBox8.Text = ca1.SqKmSqMile().ToString();
                    textBox7.ReadOnly = true;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        class ConvertArea
        {
            private double enteredValue;
            public double EnteredValue
            {
                set { enteredValue = value; }
                get { return enteredValue; }
            }
            public ConvertArea() { }
            public ConvertArea(double num1)
            {
                enteredValue = num1;
            }
            public double SqCmSqIn()
            {
                return (EnteredValue * 0.1550);
            }
            public double SqMSqYd()
            {
                return (EnteredValue * 1.1960);
            }
            public double HectarAcres()
            {
                return (EnteredValue * 2.4711);
            }
            public double SqKmSqMile()
            {
                return (EnteredValue * 0.3861);
            }
        }
    }