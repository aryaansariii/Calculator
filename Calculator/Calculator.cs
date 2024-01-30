using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double _output = 0.0;
        char _sign = ' ';
        int _maxLength = 8;

        public Calculator()
        {
            InitializeComponent();
        }

        private void replacZeroWithEmpty()
        {
            if (txtNumber.Text == "0")
                txtNumber.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Length == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == _maxLength)
                return;

            replacZeroWithEmpty();
            txtNumber.Text = txtNumber.Text + "9";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength == 1)
            {
                txtNumber.Text = "0";
                return;
            }


            string temp = "";

            for (int i = 0; i < txtNumber.TextLength - 1; i++)
            {
                temp += txtNumber.Text[i];
            }

            txtNumber.Text = Convert.ToString(temp);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            _output = 0.0;
            _sign = ' ';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (_sign == ' ')
                return;

            switch (_sign)
            {
                case '+':
                    _output += Convert.ToDouble(txtNumber.Text);
                    break;
                case '-':
                    _output -= Convert.ToDouble(txtNumber.Text);
                    break;
                case '*':
                    _output *= Convert.ToDouble(txtNumber.Text);
                    break;
                case '/':
                    _output /= Convert.ToDouble(txtNumber.Text);
                    break;
            }

            _sign = ' ';

            txtNumber.Text = Convert.ToString(_output);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (_sign != ' ')
                btnEqual_Click(sender, e);

            _sign = '*';
            _output = Convert.ToDouble(txtNumber.Text);

            txtNumber.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (_sign != ' ')
                btnEqual_Click(sender, e);

            _sign = '/';
            _output = Convert.ToDouble(txtNumber.Text);

            txtNumber.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_sign != ' ')
                btnEqual_Click(sender, e);

            _sign = '-';
            _output = Convert.ToDouble(txtNumber.Text);

            txtNumber.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_sign != ' ')
                btnEqual_Click(sender, e);

            _sign = '+';
            _output = Convert.ToDouble(txtNumber.Text);

            txtNumber.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtNumber.TextLength >= _maxLength - 1)
                return;

            if (txtNumber.Text.Contains('.'))
                return;

            txtNumber.Text = txtNumber.Text + ".";
        }
    }
}
