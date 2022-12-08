using System.Diagnostics;


namespace TicTacToe
{
    public partial class BotGame : Form
    {
        public PolickoSBotem[,] polickos = new PolickoSBotem[3,3];
        public static BotGame? instance;
        public static bool KdoNaRade = true;

        //Mo�nost zda hra� m��e vyhrat
        bool HracMuzeVyhrat = false;

        // false - hra�
        // True - PC / 2.Hra�
        public BotGame()
        {
            instance = this;
            StartoGamo();
        }
        void Hraj(int Y, int X)
        {
            if (polickos[Y, X].hodnota == null)
            {
                polickos[Y, X].hodnota = 11;
                polickos[Y, X].Vzhled.Image = Obrazky.circle;
            }
        }
        void Hraj(int Y, int X, out bool Uspech)
        {

            if (polickos[Y, X].hodnota == null)
            {
                polickos[Y, X].hodnota = 11;
                polickos[Y, X].Vzhled.Image = Obrazky.circle;

                Uspech = true;
                
            }
            else { Uspech = false; }
            
        }

        bool BotNaStredu = false;
        public void BoteHraj()
        {
            // Herni Kolo bota
            /* 
             * Uv�domuju si, �e se mi tu 2x opakuje stejn� for loop, kter� by �el zaimplementovat l�pe, pro lep��
             * chod programu, p�esto ho tam nech�v�m z d�vodu �itelnosti k�du.
             * 
             *
            */
            DetekceZdaKonec();


            bool HralBot = false;
            if (!KdoNaRade)
            {


                // Vlo�en� na st�ed
                if (polickos[1, 1].hodnota == null)
                {
                    polickos[1, 1].hodnota = 11;
                    polickos[1, 1].Vzhled.Image = Obrazky.circle;
                    BotNaStredu = true;
                    HralBot = true;
                }
                //VyherniUtok

                // Vyhern� Utok - Radky
                if (HralBot == false)
                {
                    for (int i = 0; i != 3; i++)
                    {
                        int radekHodnota1 = 0;
                        for (int j = 0; j != 3; j++)
                        {
                            if (polickos[j, i] != null)
                            {
                                radekHodnota1 += Convert.ToInt32(polickos[j, i].hodnota);
                            }

                        }
                        if (radekHodnota1 == 22)
                        {
                            Hraj(0, i);
                            Hraj(1, i);
                            Hraj(2, i);
                            HralBot = true;
                        }
                    }
                }
                // Vyhern� Utok - Sloupce
                if (HralBot == false)
                {
                    for (int i = 0; i != 3; i++)
                    {
                        int SloupecHodnota1 = 0;
                        for (int j = 0; j != 3; j++)
                        {
                            if (polickos[i, j] != null)
                            {
                                SloupecHodnota1 += Convert.ToInt32(polickos[i, j].hodnota);
                            }

                        }
                        if (SloupecHodnota1 == 22)
                        {
                            Hraj(i, 0);
                            Hraj(i, 1);
                            Hraj(i, 2);
                            HralBot = true;
                        }
                    }
                }
                // Vyhern� Utok - Krizem
                // Leva to Prava
                if (Convert.ToInt32(polickos[0, 0].hodnota) + Convert.ToInt32(polickos[1, 1].hodnota) + Convert.ToInt32(polickos[2, 2].hodnota) == 22 && HralBot == false)
                {
                    bool Povedlose = false;
                    Hraj(0, 0, out Povedlose);
                    if (Povedlose == false)
                    {
                        Hraj(2, 2, out Povedlose);
                    }
                    HralBot = true;
                }
                // Prava to leva
                if (Convert.ToInt32(polickos[2, 0].hodnota) + Convert.ToInt32(polickos[1, 1].hodnota) + Convert.ToInt32(polickos[0, 2].hodnota) == 22 && HralBot == false)
                {
                    bool Povedlose = false;
                    Hraj(2, 0, out Povedlose);
                    if (Povedlose == false)
                    {
                        Hraj(0, 2, out Povedlose);
                    }
                    HralBot = true;
                }



                // Obrann� �tok - Radky
                if (HralBot == false)
                {
                    for (int i = 0; i != 3; i++)
                    {
                        int radekHodnota1 = 0;
                        for (int j = 0; j != 3; j++)
                        {
                            if (polickos[j, i] != null)
                            {
                                radekHodnota1 += Convert.ToInt32(polickos[j, i].hodnota);
                            }

                        }
                        if (radekHodnota1 == 20)
                        {
                            Hraj(0, i);
                            Hraj(1, i);
                            Hraj(2, i);
                            HralBot = true;
                        }
                    }
                }
                // Obrann� �tok - Sloupce
                if (HralBot == false)
                {
                    for (int i = 0; i != 3; i++)
                    {
                        int SloupecHodnota1 = 0;
                        for (int j = 0; j != 3; j++)
                        {
                            if (polickos[i, j] != null)
                            {
                                SloupecHodnota1 += Convert.ToInt32(polickos[i, j].hodnota);
                            }

                        }
                        if (SloupecHodnota1 == 20)
                        {
                            Hraj(i, 0);
                            Hraj(i, 1);
                            Hraj(i, 2);
                            HralBot = true;
                        }
                    }
                }
                // Obrann� �tok - Kr�
                if (Convert.ToInt32(polickos[0, 0].hodnota) + Convert.ToInt32(polickos[1, 1].hodnota) + Convert.ToInt32(polickos[2, 2].hodnota) == 20 && HralBot == false)
                {
                    bool Povedlose = false;
                    Hraj(0, 0, out Povedlose);
                    if (Povedlose == false)
                    {
                        Hraj(2, 2, out Povedlose);
                    }
                    HralBot = true;
                }
                if (Convert.ToInt32(polickos[2, 0].hodnota) + Convert.ToInt32(polickos[1, 1].hodnota) + Convert.ToInt32(polickos[0, 2].hodnota) == 20 && HralBot == false)
                {
                    bool Povedlose = false;
                    Hraj(2, 0, out Povedlose);
                    if (Povedlose == false)
                    {
                        Hraj(0, 2, out Povedlose);
                    }
                    HralBot = true;
                }
                // Pokud Bot obsad� St�ed
                if (HralBot == false)
                {
                    if (BotNaStredu == true)
                    {


                        // Detekce zda dal hr�� �adek

                        int RadekHodnotaNahore = Convert.ToInt32(polickos[0, 0].hodnota) + Convert.ToInt32(polickos[1, 0].hodnota) + Convert.ToInt32(polickos[2, 0].hodnota);
                        int RadekHodnotaDole = Convert.ToInt32(polickos[0, 2].hodnota) + Convert.ToInt32(polickos[1, 2].hodnota) + Convert.ToInt32(polickos[2, 2].hodnota);

                        // Detekce zda dal hr�� Sloupec
                        int SloupecLevo = Convert.ToInt32(polickos[0, 0].hodnota) + Convert.ToInt32(polickos[0, 1].hodnota) + Convert.ToInt32(polickos[0, 2].hodnota);
                        int SloupecPravo = Convert.ToInt32(polickos[2, 0].hodnota) + Convert.ToInt32(polickos[2, 1].hodnota) + Convert.ToInt32(polickos[2, 2].hodnota);

                        // Macikova taktika

                        if (!HracMuzeVyhrat)
                        {
                            if (RadekHodnotaNahore == 10)
                            {
                                bool Povedlose = false;
                                Hraj(1, 0, out Povedlose);
                                if (Povedlose == false)
                                {
                                    Hraj(0, 0, out Povedlose);
                                }
                                if (Povedlose == false)
                                {
                                    Hraj(2, 0, out Povedlose);
                                }
                                HralBot = true;
                            }
                        }





                        if (RadekHodnotaNahore == 10 && HralBot == false)
                        {
                            bool Povedlose = false;
                            Hraj(0, 0, out Povedlose);
                            if (Povedlose == false)
                            {
                                Hraj(1, 0, out Povedlose);
                            }
                            if (Povedlose == false)
                            {
                                Hraj(2, 0, out Povedlose);
                            }
                            HralBot = true;
                        }
                        if (RadekHodnotaDole == 10 && HralBot == false)
                        {
                            bool Povedlose = false;
                            Hraj(0, 2, out Povedlose);
                            if (Povedlose == false)
                            {
                                Hraj(1, 2, out Povedlose);
                            }
                            if (Povedlose == false)
                            {
                                Hraj(2, 2, out Povedlose);
                            }
                            HralBot = true;
                        }




                        if (SloupecLevo == 10 && HralBot == false)
                        {
                            bool Povedlose = false;
                            Hraj(0, 0, out Povedlose);
                            if (Povedlose == false)
                            {
                                Hraj(0, 1, out Povedlose);
                            }
                            if (Povedlose == false)
                            {
                                Hraj(0, 2, out Povedlose);
                            }
                            HralBot = true;
                        }
                        if (SloupecPravo == 10 && HralBot == false)
                        {
                            bool Povedlose = false;
                            Hraj(2, 0, out Povedlose);
                            if (Povedlose == false)
                            {
                                Hraj(2, 1, out Povedlose);
                            }
                            if (Povedlose == false)
                            {
                                Hraj(2, 2, out Povedlose);
                            }
                            HralBot = true;
                        }

                        //Macikova taktika

                    }
                    else
                    {
                        // Pokud bot neobsadil st�ed (offici�ln� nejlep�� mo�n� taktika pokud se neobsad� st�ed)
                        if (HralBot == false)
                        {
                            bool povedlose = false;
                            Hraj(0, 0, out povedlose);
                            if (povedlose == true)
                            {
                                HralBot = true;
                            }
                        }
                        if (HralBot == false)
                        {
                            bool povedlose = false;
                            Hraj(0, 2, out povedlose);
                            if (povedlose == true)
                            {
                                HralBot = true;
                            }

                        }
                    }



                    // Pokud hr�� ud�l� chybu po kter� nejde vyhrat ani pro jednu stranu, m�l by se zpustit tento kus
                    for (int i = 0; i != 3; i++)
                    {
                        for (int j = 0; j != 3; j++)
                        {
                            if (polickos[j, i].hodnota == null)
                            {
                                if (HralBot == false)
                                {
                                    Hraj(j, i);
                                    HralBot = true;
                                }

                            }
                        }
                    }

                }






                DetekceZdaKonec();
                BotGame.KdoNaRade = true;
            }
        }
        public void StartoGamo()
        {
            this.Controls.Clear();
            InitializeComponent();
            BotNaStredu = false;
            KdoNaRade = true;
            WhoGona.Text = KdoNaRade != false ? "Kri�ky" : "Kole�ka";
            for (int i = 0; i != 3; i++)
            {
                for (int j = 0; j != 3; j++)
                {
                    polickos[i, j] = new PolickoSBotem(i, j);
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
                    MessageBox.Show("K��ky vyhr�ly");
                    StartoGamo();break;
                case 33:
                    MessageBox.Show("Kole�ka vyhr�la");
                    StartoGamo();break;
            }
        }
        public void DetekceZdaKonec()
        {
            WhoGona.Text = KdoNaRade != false ? "Kri�ky" : "Kole�ka";
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
            foreach (PolickoSBotem x in polickos)
            {
                DetekceZdaKonec += Convert.ToInt32(x.hodnota);
            }
            if (DetekceZdaKonec >= 90)
            {
                MessageBox.Show("Remiza");
                StartoGamo(); 
            }
        }
        public void DetekceZdaKonec(object? sender, EventArgs e)
        {
            WhoGona.Text = KdoNaRade != false ? "Kri�ky" : "Kole�ka";
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
            foreach (PolickoSBotem x in polickos)
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
    public class PolickoSBotem
    {
        public Point Poloha;
        public int? hodnota = null;
        public PictureBox Vzhled = new PictureBox();

        public PolickoSBotem(int PolohaX, int PolohaY)
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
                if (BotGame.KdoNaRade == true)
                {
                    //X
                    Vzhled.Image = Obrazky.Cross;
                    BotGame.KdoNaRade = false;
                    hodnota = 10;
                    BotGame.instance?.BoteHraj();
                }
                else
                {
                    //O
                    Vzhled.Image = Obrazky.circle;
                    BotGame.KdoNaRade = true;
                    hodnota = 11;
                }
            }
        }
    }
}