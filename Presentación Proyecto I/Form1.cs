using Paint_app;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentación_Proyecto_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_textEditor_Click(object sender, EventArgs e)
        {
            AdvancedTextEditorCSharp.AdvancedTextEditor ftx = new AdvancedTextEditorCSharp.AdvancedTextEditor();
            ftx.ShowDialog();

            this.Hide();
        }

        private void btn_paintApp_Click(object sender, EventArgs e)
        {
            Paint_app.PaintApp fp = new Paint_app.PaintApp();
            fp.ShowDialog();

            this.Hide();
        }

        private void btn_calculator_Click(object sender, EventArgs e)
        {
            CalculatorApp.Form1 fc = new CalculatorApp.Form1();
            fc.ShowDialog();

            this.Hide();
        }
    }
}
