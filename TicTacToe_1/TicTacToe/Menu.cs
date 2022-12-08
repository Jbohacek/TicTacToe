using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Menu : Form
    {
        public static Menu? instance;
        public Menu()
        {
            InitializeComponent();
            instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerGame aa = new PlayerGame();
            aa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BotGame aa = new BotGame();
            aa.Show();
        }
    }
}
