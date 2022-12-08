using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2
{
    public partial class StartWindow : Form
    {
        static public ProgressBar LoadingBar = new ProgressBar();
        static public StartWindow instance = new StartWindow();

        public StartWindow()
        {
            InitializeComponent();
            LoadingBar = progressBar1;
            instance = this;
            this.Height = 400;
            this.TopMost = true;
        }

        private void SpustHru(object sender, EventArgs e)
        {
            LoadingBar.Value = 0;
            bool KdoZacina = false;
            if (CrossButton.Checked)
            {
                KdoZacina = true;
            }

            if ((WidthNum.Value * HeightNum.Value) < 9000)
            {
                this.TopMost = true;
                button1.Enabled = false;
                LoadingBar.Maximum = Convert.ToInt32(WidthNum.Value * HeightNum.Value);
                LoadingBar.Visible = true;
                this.Height = 490;

                GameWindow Novy = new GameWindow(

                    Convert.ToInt32(WidthNum.Value), 
                    Convert.ToInt32(HeightNum.Value), 
                    KdoZacina, Convert.ToInt32(HowMuchToWinNum.Value), 
                    Convert.ToInt32(ScaleNum.Value),
                    checkBox1.Checked
                    
                    );


                UkazatelZdaSeNacitaForms.Visible = true;
                Application.DoEvents();
                Novy.Show();
                LoadingBar.Visible = false;
                UkazatelZdaSeNacitaForms.Visible = false;
                this.WindowState = FormWindowState.Minimized;
                this.TopMost = false;
                this.Height = 400;
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Moc políček: " + WidthNum.Value * HeightNum.Value + "\nMaximum: 9000 ");
            }
            
            

        
            
            
        }

        private void ChangeCelkemValue(object sender, EventArgs e)
        {
            LabelCelkem.Text = "Celkem: " + (HeightNum.Value* WidthNum.Value).ToString();
            if (HeightNum.Value * WidthNum.Value > 2000)
            {
                LabelCelkem.Text += "\nNad 2000 není zaručená kvalita";
            }
            
        }
    }
}
