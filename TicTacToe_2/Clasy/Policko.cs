using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe2.Clasy
{
    internal class Policko
    {
        public Point Poloha;

        public bool? hodnota = null;
        // Null - nic
        // True - Krizky
        // false - Kolecka

        public PictureBox Vzhled = new PictureBox();

        private HerniPole ParentPole;

        

        public Policko(int PolohaX, int PolohaY,HerniPole hraciPolicko,int VelikostPolicka)
        {
            ParentPole = hraciPolicko;

            
            
            StartWindow.LoadingBar.Value++;

            // PictureBox
            Poloha = new Point(PolohaX, PolohaY);
            Vzhled.Location = new Point(PolohaX * VelikostPolicka + 50, PolohaY * VelikostPolicka + 50);
            Vzhled.Size = new Size(VelikostPolicka, VelikostPolicka);
            Vzhled.BackColor = Color.White;
            Vzhled.BorderStyle = BorderStyle.FixedSingle;
            Vzhled.SizeMode = PictureBoxSizeMode.Zoom;
            Vzhled.Cursor = Cursors.Hand;
            Vzhled.Click += Vzhled_Click;
            //PictueBox
        }
        private void Vzhled_Click(object? sender, EventArgs e)
        {
            if (hodnota == null)
            {
                if (ParentPole.KdoNaRade == true)
                {
                    //X
                    Vzhled.Image = Obrazky.Cross;
                    ParentPole.KdoNaRade = false;
                    hodnota = true;
                    
                }
                else
                {
                    //O
                    Vzhled.Image = Obrazky.circle;
                    
                    ParentPole.KdoNaRade = true;
                    hodnota = false;
                }

                Vzhled.Cursor = Cursors.Default;
                ParentPole.PocetTahu++;
                ParentPole.MuzeVratitOJednoDoZadu = true;
                ParentPole.PosledniPoloha = Poloha;
                ParentPole.HerniPoleParent.UndoButton.Visible = true;

                switch (ParentPole.Zkontroluj())
                {
                    case true:
                        ParentPole.ZobrazCerveneVyherniBody();
                        MessageBox.Show("Kriky Vyhraly\nPocet tahů: " + ParentPole.PocetTahu);
                        ParentPole.Konec();
                        break;
                    case false:
                        ParentPole.ZobrazCerveneVyherniBody();
                        MessageBox.Show("Kolecka Vyhraly\nPocet tahů: "  + ParentPole.PocetTahu);
                        ParentPole.Konec();
                        break;
                }
                
                    
                

            }
        }
    }
}
