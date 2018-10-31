using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Calc = new Core.Calc();
            string[] Operarions = Calc.Operations
                .Select(o => o.Name)
                .ToArray();
            cbOperation.Items.AddRange(Operarions);
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            var values = tbInput.Text.Split(' ').Select(Convert.ToDouble).ToArray();
            var operation = cbOperation.Text;
            var result = Calc.Execute(operation, values);
            lblResult.Text = $"Результат: {result}"; 
        }
    }
}
