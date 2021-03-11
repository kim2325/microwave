using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project01
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private List<double> numbers;
        private List<Operator> ops;
        private string equation;
        public Calculator()
        {
            InitializeComponent();
            this.numbers = new List<double>();
            this.ops = new List<Operator>();
            this.equation = "";
        }
        private void UpdateTextBox(string str, TextBox tb)
        {
            tb.Text = str;
        }
        private double ConvertToDouble(string str)
        {
            return Double.Parse(str);
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            this.equation += "0";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            this.equation += "1";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            this.equation += "2";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            this.equation += "3";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            this.equation += "4";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            this.equation += "5";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            this.equation += "6";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            this.equation += "7";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            this.equation += "8";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            this.equation += "9";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('+'));
            this.equation = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('-'));
            this.equation = "";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('*'));
            this.equation = "";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('/'));
            this.equation = "";
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            this.equation += ".";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.equation = "";
            UpdateTextBox(this.equation, this.tb_equation);
            this.numbers.Clear();
            this.ops.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('='));
            this.equation = this.solve();
            this.UpdateTextBox(this.equation, this.tb_equation);
        }
        private string solve()
        {
            double before = numbers[0];
            for (int i = 1; i < this.numbers.Count; i++)
            {
                before = ops[i - 1].apply(before, numbers[i]);
            }
            return before.ToString();
        }


        //protected void StoreDisplay(string fromDisplay)
        //{
        //    Session["displayedValue"] = fromDisplay.ToString();
        //}

        //protected void Btn0_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn0.Text.ToString();
        //    StoreDisplay(Btn0.Text.ToString());
        //}

        //protected void Btn1_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn1.Text.ToString();
        //    StoreDisplay(Btn1.Text.ToString());
        //}

        //protected void Btn2_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn2.Text.ToString();
        //    StoreDisplay(Btn2.Text.ToString());
        //}

        //protected void Btn3_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn3.Text.ToString();
        //    StoreDisplay(Btn3.Text.ToString());
        //}

        //protected void Btn4_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn4.Text.ToString();
        //    StoreDisplay(Btn4.Text.ToString());
        //}

        //protected void Btn5_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn5.Text.ToString();
        //    StoreDisplay(Btn5.Text.ToString());
        //}

        //protected void Btn6_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn6.Text.ToString();
        //    StoreDisplay(Btn6.Text.ToString());
        //}

        //protected void Btn7_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn7.Text.ToString();
        //    StoreDisplay(Btn7.Text.ToString());
        //}

        //protected void Btn8_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn8.Text.ToString();
        //    StoreDisplay(Btn8.Text.ToString());
        //}

        //protected void Btn9_Click(object sender, EventArgs e)
        //{
        //    display.Text = Btn9.Text.ToString();
        //    StoreDisplay(Btn9.Text.ToString());
        //}

        protected void clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            
        }
    }
}