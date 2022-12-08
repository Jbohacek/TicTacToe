using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToe2.Clasy
{
    internal class HerniPole
    {
        public Policko[,] Pole;

        

        public bool KdoNaRade = true;
        // True - Krizky
        // false - Kolecka

        int Width;
        int Height;

        int KolikPotreba = 4;
        public int PocetTahu = 0;

        public GameWindow HerniPoleParent;

        List<PictureBox> PosledniNaCerveny = new List<PictureBox>();

        public Point PosledniPoloha;
        public bool MuzeVratitOJednoDoZadu = false;

        public HerniPole(int width, int height, bool KdoZacina, int KolikPotrebaNaVyhru,int VelikostPolicka, GameWindow Parent)
        {
            Width = width;
            Height = height;
            KdoNaRade=KdoZacina;
            HerniPoleParent = Parent;

            KolikPotreba = KolikPotrebaNaVyhru;

            Pole = new Policko[width, height];
            for (int i = 0; i != width; i++)
            {
                for (int j = 0; j != height; j++)
                { 
                    Pole[i, j] = new Policko(i, j, this, VelikostPolicka);
                }
            }
        }

        //Udelat list Picturebox aby bylo videt
        public List<PictureBox> VratVsechnyPolicka()
        {
            List<PictureBox> list = new List<PictureBox>();

            foreach (Policko a in Pole)
            {
                list.Add(a.Vzhled);
            }

            return list;
        }

        public void Konec()
        {
            HerniPoleParent.Close();
            StartWindow.instance.TopMost = true;
        }

        public void ZobrazCerveneVyherniBody()
        {
            foreach (PictureBox a in PosledniNaCerveny)
            {
                a.BackColor = Color.Red;
            }
        }

        public void VratOJednoDoZadu(object? sender, EventArgs e)
        {
            Debug.WriteLine("back");
            if (MuzeVratitOJednoDoZadu)
            {
                HerniPoleParent.UndoButton.Visible = false;
                Pole[PosledniPoloha.X, PosledniPoloha.Y].Vzhled.Image = null;
                Pole[PosledniPoloha.X, PosledniPoloha.Y].Vzhled.Cursor = Cursors.Hand;
                Pole[PosledniPoloha.X, PosledniPoloha.Y].hodnota = null;
                PocetTahu--;
                MuzeVratitOJednoDoZadu = false;
                if (KdoNaRade)
                { KdoNaRade = false; }
                else { KdoNaRade = true; }
            }
        }

        public bool? Zkontroluj()
        {
            void VratHodnotu(ref int Hodnota, bool? ZadanaHodnota)
            {
                switch (ZadanaHodnota)
                {
                    case true:
                        if (Hodnota >= 0)
                        {
                            Hodnota++;
                        }
                        else if (Hodnota < 0)
                        {
                            Hodnota = 1;
                        }
                        break;
                    case false:
                        if (Hodnota <= 0)
                        {
                            Hodnota--;
                        }
                        else if (Hodnota > 0)
                        {
                            Hodnota = -1;
                        }
                        break;
                    case null:
                        Hodnota = 0;
                        break;

                }
                
            }
            bool? Kontrola(int Pocet)
            {
                if (Pocet == KolikPotreba)
                {
                    return true;    
                }
                if (Pocet == -KolikPotreba)
                {
                    return false;
                }
                return null;
            }

            void Pridej(int x, int y)
            {
                if (PosledniNaCerveny.Count == KolikPotreba)
                {
                    PosledniNaCerveny.RemoveAt(0);
                }
                PosledniNaCerveny.Add(Pole[x, y].Vzhled);
            }

            void FinalniHodnota(ref int Pocitadlo,int x,int y,ref bool? Verdikt)
            {
                VratHodnotu(ref Pocitadlo, Pole[x, y].hodnota);

                Pridej(x, y);

                Verdikt = Kontrola(Pocitadlo);

                
            }


            bool? FinalniVerdikt = null;

            //Kontrola Radky
            for (int i = 0; i != Height; i++)
            {
                int Pocitadlo = 0;
                
                for (int j = 0; j != Width; j++)
                {
                    //Debug.Write(i + "," + j + "|");
                    FinalniHodnota(ref Pocitadlo, j, i, ref FinalniVerdikt);

                    if (FinalniVerdikt != null)
                    {
                        return FinalniVerdikt;
                    }
                }
                //Debug.WriteLine("");
                
            }
            
            //Kontrola Sloupcu
            for (int i = 0; i != Width; i++)
            {
                int Pocitadlo = 0;
                for (int j = 0; j != Height; j++)
                {
                    //Debug.Write(i + "," + j + "|");

                    FinalniHodnota(ref Pocitadlo, i, j, ref FinalniVerdikt);

                    if (FinalniVerdikt != null)
                    {
                        return FinalniVerdikt;
                    }
                }

            }

            

            //Pokud obdelník na výšku
            int d = 0;
            if (Height > Width)
            {
                int offset = Height - Width;
                int odebiradlo = 0;
                //A
                for (int i = 0; i != Height; i++)
                {
                     d = 0;
                    int Pocitadlo = 0;
                    if (offset < 0)
                    {
                        odebiradlo++;
                    }

                    for (int j = 0; j < Width - odebiradlo; j++)
                    {
                        //Debug.Write((i + d) + " " + (j) + "|");

                        FinalniHodnota(ref Pocitadlo, j, i + d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }

                        d++;
                    }
                    offset--;
                    //Debug.WriteLine("");
                }

                offset = Height - Width;
                odebiradlo = 0;

                //B
                for (int i = 0; i != Width; i++)
                {
                     d = 0;
                    int Pocitadlo = 0;
                    for (int j = 0; j < Width - i; j++)
                    {
                        //Debug.Write(j + " " + (i + d) + "|");

                        FinalniHodnota(ref Pocitadlo, d + i, j, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }

                        d++;
                    }
                    //Debug.WriteLine("");
                }


                //-A
                for (int i = 0; i != Height; i++)
                {
                     d = 0;
                    int Pocitadlo = 0;
                    if (offset < 0)
                    {
                        odebiradlo++;
                    }


                    for (int j = 0; j < Width - odebiradlo; j++)
                    {
                        int o = (Width - 1) - j;
                        //Debug.Write((i+d) + " " + o + "|");

                        FinalniHodnota(ref Pocitadlo, o, i + d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }



                        d++;
                    }
                    //Debug.WriteLine("");
                    offset--;
                }
                //-B
                for (int i = Width - 1; i != -1; i--)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    for (int j = 0; j < Width - (Width - i) + 1; j++)
                    {
                        //Debug.Write("| " + j + " " + (i - d) + " |\t");

                        FinalniHodnota(ref Pocitadlo,i-d, j, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }

                        d++;
                    }
                   // Debug.WriteLine("");

                }

            }

            //Pokud obdelník na šířku
            if (Width > Height)
            {
                int offset = Width - Height;
                int odebiradlo = 0;
                //A
                for (int i = 0; i != Width; i++)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    if (offset < 0)
                    {
                        odebiradlo++;
                    }

                    for (int j = 0; j < Height - odebiradlo; j++)
                    {
                        //Debug.Write((j) + " " + (i+ d) + "|");

                        FinalniHodnota(ref Pocitadlo,i+d,j, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }


                        d++;
                    }
                    offset--;
                    //Debug.WriteLine("");
                }

                //B
                for (int i = 0; i != Width; i++)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    for (int j = 0; j < Height - i; j++)
                    {
                        //Debug.Write(i+d + " " + (j) + "|");

                        FinalniHodnota(ref Pocitadlo, j, i + d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }

                        d++;
                    }
                    //Debug.WriteLine("");
                }
                offset = Width - Height;
                odebiradlo = 0;
                // -A
                for (int i = 0; i != Width; i++)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    if (offset < 0)
                    {
                        odebiradlo++;
                    }


                    for (int j = 0; j < Height - odebiradlo; j++)
                    {
                        int o = (Height - 1) - j;
                        //Debug.Write(o + " " + (i + d) + "|");


                        FinalniHodnota(ref Pocitadlo, d+i, o, ref FinalniVerdikt);


                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }



                        d++;
                    }
                    //Debug.WriteLine("");
                    offset--;
                }
                // -B

                for (int i = Height - 1; i != -1; i--)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    for (int j = 0; j < Height - (Height - i) + 1; j++)
                    {
                        //Debug.Write("| " + (i-d) + " " + j + " |\t");

                        FinalniHodnota(ref Pocitadlo, j, i - d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }

                        d++;
                    }
                    //Debug.WriteLine("");

                }

            }

            //Pokud ctverec
            if (Width == Height)
            {
                //A

                for (int k = 0; k != Width; k++)
                {
                    d = 0;
                    int Pocitadlo = 0;

                    for (int i = k; i != Width; i++)
                    {

                        FinalniHodnota(ref Pocitadlo, i, d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }


                        //Debug.Write(i + " " + d + "|");
                        d++;
                    }
                    //Debug.WriteLine("");

                }


                d = 0;

                //B

                //Debug.WriteLine("---------");
                for (int k = 0; k != Height; k++)
                {
                    d = 0;
                    int Pocitadlo = 0;

                    for (int i = k; i != Width; i++)
                    {
                        //VratHodnotu(ref Pocitadlo, Pole[d, i].hodnota);

                        FinalniHodnota(ref Pocitadlo, d, i, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }
                        //Debug.Write(d + " " + i + "|");
                        d++;
                    }
                    //Debug.WriteLine("");

                }
                //-A

                for (int i = 0; i != Height; i++)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    


                    for (int j = 0; j < Width - i; j++)
                    {
                        int o = (Width - 1) - j;
                        //Debug.Write((i+d) + " " + o + "|");

                        FinalniHodnota(ref Pocitadlo, o, i+d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }



                        d++;
                    }
                    //Debug.WriteLine("");
                    
                }
                // -B
                for (int i = Width - 1; i != -1; i--)
                {
                    d = 0;
                    int Pocitadlo = 0;
                    for (int j = 0; j < Width - (Width - i) + 1; j++)
                    {
                        //Debug.Write("| " + j + " " + (i - d) + " |\t");

                        FinalniHodnota(ref Pocitadlo, j, i - d, ref FinalniVerdikt);

                        if (FinalniVerdikt != null)
                        {
                            return FinalniVerdikt;
                        }

                        d++;
                    }
                    //Debug.WriteLine("");

                }

            }

            //Kontrola LeftToRight
             d = 0;
            






            return FinalniVerdikt;
        }
        


    }
}
