using EM.Calc.Core;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EM.Calc.WinCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Core.Calc Calc { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "bin\\";
            //Calc = new Core.Calc(path);
            string[] Operarions = Calc.Operations
                .Select(o => o.Name)
                .ToArray();
            cbOperation.Items.AddRange(Operarions);
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (cbOperation.Text != "")
            {
                if (tbInput.Text != "")
                {
                    tbInput.Text = DelSpace(tbInput.Text);
                    var values = tbInput.Text.Split(' ').Select(Convert.ToDouble).ToArray();
                    var operation = cbOperation.Text;
                    var result = Calc.Execute(operation, values);
                    lblResult.Text = $"Результат: {result}";
                }
                else
                {
                    lblResult.Text = "Результат: введите операнды";
                }
            }
            else
            {
                lblResult.Text = "Результат: не выбрана операция";
            }

        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 32 && number != '-' && number != ',')
            {
                e.Handled = true;
            }

        }
        private string DelSpace(string str)
        {
            var regex = new Regex(@"\s{2,}");
            str = regex.Replace(str, " ");
            return str;
        }

        private void cbOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            var operation = Calc.Operations
                .OfType<IExtOperation>()
                .FirstOrDefault(o => o.Name == cbOperation.Text);

            if (operation != null)
            {
                toolTip1.SetToolTip(cbOperation, operation.Description);
            }
            else
            {
                toolTip1.SetToolTip(cbOperation, "Это старая операция");
            }
        }
    }
}
