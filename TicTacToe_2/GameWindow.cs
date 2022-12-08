using TicTacToe2.Clasy;

namespace TicTacToe2
{
    public partial class GameWindow : Form
    {
        public PictureBox UndoButton;
        public GameWindow(int Width,int Height, bool KdoZacina, int KolikNaVyhru,int VelikostPolicka,bool Zmaximalizovat)
        {
            InitializeComponent();
            //6 8
            UndoButton = BackButton;

            HerniPole Pokus = new HerniPole(Width, Height, KdoZacina,KolikNaVyhru,VelikostPolicka,this);
            foreach (PictureBox a in Pokus.VratVsechnyPolicka())
            {
                this.Controls.Add(a);
            }

            BackButton.Click += Pokus.VratOJednoDoZadu;

            this.Width = Width * VelikostPolicka + 150;
            this.Height = Height * VelikostPolicka + 150;

            if (Zmaximalizovat)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}