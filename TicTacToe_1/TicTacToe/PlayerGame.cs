using System.Diagnostics;


namespace TicTacToe
{
    public partial class PlayerGame : Form
    {
        public Policko[,] polickos = new Policko[3,3];

        public static bool KdoNaRade = true;

        // false - hraè
        // True - PC / 2.Hraè
        public PlayerGame()
        {
            StartoGamo();
        }
        public void StartoGamo()
        {
            this.Controls.Clear();
            InitializeComponent();
            KdoNaRade = true;
            WhoGona.Text = KdoNaRade != false ? "Križky" : "Koleèka";
            for (int i = 0; i != 3; i++)
            {
                for (int j = 0; j != 3; j++)
                {
                    polickos[i, j] = new Policko(i, j);
                    this.Controls.Add(polickos[i, j].Vzhled);
                    polickos[i, j].Vzhled.Click += DetekceZdaKonec;
                }
            }
        }
        public void Vyherce(int? Kolik)
        {
            switch (Kolik)
            {
                case 30:
                    MessageBox.Show("Køížky vyhrály");
                    StartoGamo();break;
                case 33:
                    MessageBox.Show("Koleèka vyhrála");
                    StartoGamo();break;
            }
        }
        public void DetekceZdaKonec(object? sender, EventArgs e)
        {
            WhoGona.Text = KdoNaRade != false ? "Križky" : "Koleèka";
            for (int i = 0; i != 3; i++)
            {
                int? radekHodnota = 0;
                for (int j = 0; j != 3; j++)
                {
                    radekHodnota += polickos[j, i].hodnota;
                }
                Vyherce(radekHodnota);

                int? SloupecHodnota = 0;
                for (int j = 0; j != 3; j++)
                {
                    SloupecHodnota += polickos[i, j].hodnota;
                }
                Vyherce(SloupecHodnota);

                // Vypocet krizem
                Vyherce(polickos[0, 0].hodnota + polickos[1, 1].hodnota + polickos[2, 2].hodnota);
                Vyherce(polickos[0, 2].hodnota + polickos[1, 1].hodnota + polickos[2, 0].hodnota);
            }
            int DetekceZdaKonec = 0;
            foreach (Policko x in polickos)
            {
                DetekceZdaKonec += Convert.ToInt32(x.hodnota);
            }
            if (DetekceZdaKonec >= 90)
            {
                MessageBox.Show("Remiza");
                StartoGamo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu.instance?.Show();
            this.Close();
        }
    }
    public class Policko
    {
        public Point Poloha;
        public int? hodnota = null;
        public PictureBox Vzhled = new PictureBox();

        public Policko(int PolohaX, int PolohaY)
        {
            Poloha = new Point(PolohaX, PolohaY);
            Vzhled.Location = new Point(PolohaX*150 + 50, PolohaY*150 + 50);
            Vzhled.Size = new Size(150,150);
            Vzhled.BackColor = Color.White;
            Vzhled.BorderStyle = BorderStyle.FixedSingle;
            Vzhled.SizeMode = PictureBoxSizeMode.Zoom;
            Vzhled.Click += Vzhled_Click;
        }
        private void Vzhled_Click(object? sender, EventArgs e)
        {
            if (hodnota == null)
            {
                if (PlayerGame.KdoNaRade == true)
                {
                    //X
                    Vzhled.Image = Obrazky.Cross;
                    PlayerGame.KdoNaRade = false;
                    hodnota = 10;
                }
                else
                {
                    //O
                    Vzhled.Image = Obrazky.circle;
                    PlayerGame.KdoNaRade = true;
                    hodnota = 11;
                }
            }
        }
    }
}