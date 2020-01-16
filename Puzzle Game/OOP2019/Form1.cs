using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OOP2019
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int wrogowie = 1;
        public void ENEMY()
        {
            wróg.dmg = 0;
            wróg.def = 0;
            switch (rnd.Next(0, 2))
            {
                case 0:
                    wróg.dmg = rnd.Next(0, 3);
                    enemystats.Text = $"Zaatakuje za{Environment.NewLine}{wróg.obrażenia}*{wróg.dmg}{Environment.NewLine}HP: {wróg.hp}/{wróg.zdrowie}";
                    break;
                case 1:
                    wróg.def = rnd.Next(0, 3);
                    enemystats.Text = $"Obroni {Environment.NewLine}{wróg.obrona}*{wróg.def}{Environment.NewLine}HP: {wróg.hp}/{wróg.zdrowie}";
                    break;
            }
        }
        public void DMG()
        {
            if (wróg.def * wróg.obrona - postać.dmg * postać.obrażenia < 0)
            {
                wróg.hp = wróg.hp + (wróg.def * wróg.obrona - postać.dmg * postać.obrażenia);
                if (wróg.hp <= 0)
                {
                    wróg.obrażenia = 0;
                    wrogowie++;
                    switch(wrogowie)
                    {
                        case 2:
                            enemypic.Image = enemy2;
                            break;
                        case 3:
                            enemypic.Image = enemy3;
                            break;
                        case 4:
                            enemypic.Image = enemy4;
                            break;
                        case 5:
                            enemypic.Image = enemy5;
                            break;
                        default:
                            enemypic.Image = enemy0;
                            enemystats.Visible = false;
                            break;
                    }
                }

            }
            if (postać.def * postać.obrona - wróg.dmg * wróg.obrażenia < 0 && wróg.hp > 0)
            {
                postać.hp = postać.hp + (postać.def * postać.obrona - wróg.dmg * wróg.obrażenia);
                if (postać.hp <= 0)
                {
                    MessageBox.Show("Porażka");
                    Close();
                }
            }

            ingamestats.Text = Statystyki();
            postać.Reset_Rundy();
            if (wróg.obrażenia == 0)
            {
                wróg = new Postaci(wrogowie, wrogowie, wrogowie * 5);
            }
            ENEMY();
            ingamestats.Text = Statystyki();
        }
        public void Punkty(int j, int i)
        {
            if (bm1 == Plansza[j, i].Image)
            {
                postać.Kalkulator(1, 0, 0, 0);
            }
            if (bm2 == Plansza[j, i].Image)
            {
                postać.Kalkulator(0, 0, 0, 1);
            }
            if (bm3 == Plansza[j, i].Image)
            {
                postać.Kalkulator(0, 1, 0, 0);
            }
            if (bm4 == Plansza[j, i].Image)
            {
                postać.Kalkulator(0, 0, 1, 0);
            }
        }
        public PictureBox[,] Usuwanie(PictureBox[,] tablica, int[,] rodzaj)
        {
            for (int j = 0; j < 6; j++)
            {
                if (rodzaj[0, j] != 0)
                {
                    Punkty(j, 0);
                    tablica[j, 0].Image = tablica[j, 1].Image = tablica[j, 2].Image = tablica[j, 3].Image = tablica[j, 4].Image = tablica[j, 5].Image = null;
                }
                if (rodzaj[1, j] != 0)
                {
                    Punkty(0, j);
                    tablica[0, j].Image = tablica[1, j].Image = tablica[2, j].Image = tablica[3, j].Image = tablica[4, j].Image = tablica[5, j].Image = null;
                }
            }

            return tablica;
        }
        public PictureBox[,] Sprawdzanie(PictureBox[,] tablica)
        {
            int[,] rodzaj = new int[2, 6] { { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 } };
            for (int x = 0; x < 6; x++)
            {
                if (tablica[x, 0].Image == tablica[x, 1].Image &&
                    tablica[x, 0].Image == tablica[x, 2].Image &&
                    tablica[x, 0].Image == tablica[x, 3].Image &&
                    tablica[x, 0].Image == tablica[x, 4].Image &&
                    tablica[x, 0].Image == tablica[x, 5].Image)
                {
                    rodzaj[0, x]++;
                }
                if (tablica[0, x].Image == tablica[1, x].Image &&
                    tablica[0, x].Image == tablica[2, x].Image &&
                    tablica[0, x].Image == tablica[3, x].Image &&
                    tablica[0, x].Image == tablica[4, x].Image &&
                    tablica[0, x].Image == tablica[5, x].Image)
                {
                    rodzaj[1, x]++;
                }
            }
            tablica = Usuwanie(tablica, rodzaj);
            tablica = Losowanie(tablica);
            return tablica;
        }
        public Form1()
        {
            InitializeComponent();
            postacinfo.Parent = pbMenu;
            postaćpreview.Parent = pbMenu;
            ingamestats.Parent = pbMenu;
            enemystats.Parent = pbMenu;
            enemypic.Parent = tło1;
            kod.Text = $"KOD{Environment.NewLine}Krzysztof Żmuda";
            grafika.Text = $"GRAFIKI{Environment.NewLine}Kinga Truszczyńska";
            title.Text = $"Toothache{Environment.NewLine}Studio";
            kod.Parent = pbMenu;
            grafika.Parent = pbMenu;
            title.Parent = pbMenu;

        }
        //PRZYCISKI W MENU GŁÓWMYM
        private void start_Click(object sender, EventArgs e)
        {
            ZamykamMenu();
            OtwMenuPostaci();
        }

        private void tutorial_Click(object sender, EventArgs e)
        {
            ZamykamMenu();
            postaćpreview.Visible = true;
            postaćpreview.Image = enemy0;
            kod.Visible = true;
            grafika.Visible = true;
            title.Visible = true;
            twórcy_powrót.Visible = true;
        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            Close();
        }
        //POKAZUJE I USUWA MENU GŁÓWNE
        private void ZamykamMenu()
        {
            twórcy.Visible = false;
            start.Visible = false;
            wyjscie.Visible = false;
        }
        private void OtwieramMenu()
        {

            twórcy.Visible = true;
            start.Visible = true;
            wyjscie.Visible = true;
        }
        //MENU POSTACI
        private void OtwMenuPostaci()
        {
            postać = new Postaci();
            postacinfo.Text = PostaćInfo();
            łucznik.Visible = true;
            łucznik.Enabled = true;
            wojownik.Visible = true;
            wojownik.Enabled = true;
            mag.Visible = true;
            mag.Enabled = true;
            wybór_postaci.Visible = true;
            wybór_postaci.Enabled = false;
            postacinfo.Visible = true;
            postaćpreview.Visible = true;
            postaćpreview.Image = null;

        }
        private void ZamMenuPostaci()
        {
            łucznik.Visible = false;
            wojownik.Visible = false;
            mag.Visible = false;
            wybór_postaci.Visible = false;
            postacinfo.Visible = false;
            postaćpreview.Visible = false;
            ingamestats.Text = Statystyki();
            ingamestats.Visible = true;
            ENEMY();
            enemypic.Visible = true;
            enemystats.Visible = true;
        }
        //GRAFIKI
        Bitmap bm1 = new Bitmap(Properties.Resources.Miecz);
        Bitmap bm2 = new Bitmap(Properties.Resources.But);
        Bitmap bm3 = new Bitmap(Properties.Resources.Tarcza);
        Bitmap bm4 = new Bitmap(Properties.Resources.Serce);
        Bitmap enemy0 = new Bitmap(Properties.Resources.Ząb);
        Bitmap enemy1 = new Bitmap(Properties.Resources.Liściu);
        Bitmap enemy2 = new Bitmap(Properties.Resources.Kropelka);
        Bitmap enemy3 = new Bitmap(Properties.Resources.Tornado);
        Bitmap enemy4 = new Bitmap(Properties.Resources.Płomyk);
        Bitmap enemy5 = new Bitmap(Properties.Resources.Kamień);
        //PLANSZA I JEJ LOSOWANIE
        public PictureBox[,] Losowanie(PictureBox[,] tabela)
        {
            foreach (PictureBox i in tabela)
                if (i.Image == null)
                {
                    switch (rnd.Next(1, 5))
                    {
                        case 1:
                            i.Image = bm1;
                            break;
                        case 2:
                            i.Image = bm2;
                            break;
                        case 3:
                            i.Image = bm3;
                            break;
                        default:
                            i.Image = bm4;
                            break;
                    }
                }
            return tabela;
        }
        PictureBox[,] Plansza;
        private void RozpoczynamGrę()
        {
            enemypic.Image = enemy1;
            koniectury.Visible = true;
            tło1.Visible = true;
            tło2.Visible = true;
            Plansza =  new PictureBox[6, 6]    {{ tabela00, tabela10, tabela20, tabela30, tabela40, tabela50 },
                                                            { tabela01, tabela11, tabela21, tabela31, tabela41, tabela51 },
                                                            { tabela02, tabela12, tabela22, tabela32, tabela42, tabela52 },
                                                            { tabela03, tabela13, tabela23, tabela33, tabela43, tabela53 },
                                                            { tabela04, tabela14, tabela24, tabela34, tabela44, tabela54 },
                                                            { tabela05, tabela15, tabela25, tabela35, tabela45, tabela55 } };
            Plansza = Losowanie(Plansza);
            tabelaGuzików.Visible = true;
            
        }
        //Postaci
        Postaci postać;
        Postaci wróg = new Postaci(1, 1, 5);
        public Postaci Stwórz(int XD)
        {
            switch(XD)
            {
                case 1:
                    {
                        return new Wojownik();
                    }
                case 2:
                    {
                        return new Łucznik();
                    }
                default:
                    {
                        return new Mag();
                    }
            }
        }
        public string PostaćInfo()
        {
            return $"Klasa: {postać.nazwa}{Environment.NewLine}Obrażenia: {postać.obrażenia}{Environment.NewLine}Obrona: {postać.obrona}{Environment.NewLine}Zwinność: {postać.move}/{postać.zwinność}{Environment.NewLine}Zdrowie: {postać.hp}/{postać.zdrowie}{Environment.NewLine}";
        }
        public string Statystyki()
        {
            return $"DMG: {postać.obrażenia}*{postać.dmg}{Environment.NewLine}DEF: {postać.obrona}*{postać.def}{Environment.NewLine}MOVES: {postać.move}/{postać.zwinność}{Environment.NewLine}HP: {postać.hp}/{postać.zdrowie}";
        }
        public string Przeciwnik()
        {
            return $"DMG: {wróg.obrażenia}*{wróg.dmg}{Environment.NewLine}DEF: {wróg.obrona}*{wróg.def}{Environment.NewLine}HP: {wróg.hp}/{wróg.zdrowie}";
        }
        //Wybór
        private void łucznik_Click(object sender, EventArgs e)
        {
            postać = Stwórz(2);
            postać.Kalkulator();
            postacinfo.Text = PostaćInfo();
            wybór_postaci.Enabled = true;
            łucznik.Enabled = false;
            wojownik.Enabled = true;
            mag.Enabled = true;
            //Do zmiany
            postaćpreview.Image = Properties.Resources.Łucznik;

        }
        private void wojownik_Click(object sender, EventArgs e)
        {
            postać = Stwórz(1);
            postać.Kalkulator();
            postacinfo.Text = PostaćInfo();
            wybór_postaci.Enabled = true;
            łucznik.Enabled = true;
            wojownik.Enabled = false;
            mag.Enabled = true;
            postaćpreview.Image = Properties.Resources.Wojownik;
        }
        private void mag_Click(object sender, EventArgs e)
        {
            postać = Stwórz(3);
            postać.Kalkulator();
            postacinfo.Text = PostaćInfo();
            wybór_postaci.Enabled = true;
            łucznik.Enabled = true;
            wojownik.Enabled = true;
            mag.Enabled = false;
            postaćpreview.Image = Properties.Resources.Mag;
        }
        private void wybór_postaci_Click(object sender, EventArgs e)
        {
            ZamMenuPostaci();
            //PRZEŚCIE DO GRY
            RozpoczynamGrę();
        }
        //GUZiKI W TABELI
        int Licznik = 0;
        int i;
        int j;
        private void tabela00_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela00.Image;
                i = 0;
                j = 0;
                Licznik++;
                tabela00.Enabled = false;
                tabela00.BackColor = Color.Red;
                ingamestats.Text = Statystyki();
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela00.Image;
                tabela00.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela10_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela10.Image;
                i = 1;
                j = 0;
                Licznik++;
                tabela10.Enabled = false;
                tabela10.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela10.Image;
                tabela10.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela20_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela20.Image;
                i = 2;
                j = 0;
                Licznik++;
                tabela20.Enabled = false;
                tabela20.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela20.Image;
                tabela20.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela30_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela30.Image;
                i = 3;
                j = 0;
                Licznik++;
                tabela30.Enabled = false;
                tabela30.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela30.Image;
                tabela30.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela40_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela40.Image;
                i = 4;
                j = 0;
                Licznik++;
                tabela40.Enabled = false;
                tabela40.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela40.Image;
                tabela40.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela50_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela50.Image;
                i = 5;
                j = 0;
                Licznik++;
                tabela50.Enabled = false;
                tabela50.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela50.Image;
                tabela50.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela01_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela01.Image;
                i = 0;
                j = 1;
                Licznik++;
                tabela01.Enabled = false;
                tabela01.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela01.Image;
                tabela01.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela11_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela11.Image;
                i = 1;
                j = 1;
                Licznik++;
                tabela11.Enabled = false;
                tabela11.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela11.Image;
                tabela11.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela21_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela21.Image;
                i = 2;
                j = 1;
                Licznik++;
                tabela21.Enabled = false;
                tabela21.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela21.Image;
                tabela21.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela31_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela31.Image;
                i = 3;
                j = 1;
                Licznik++;
                tabela31.Enabled = false;
                tabela31.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela31.Image;
                tabela31.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela41_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela41.Image;
                i = 4;
                j = 1;
                Licznik++;
                tabela41.Enabled = false;
                tabela41.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela41.Image;
                tabela41.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela51_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela51.Image;
                i = 5;
                j = 1;
                Licznik++;
                tabela51.Enabled = false;
                tabela51.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela51.Image;
                tabela51.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela02_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela02.Image;
                i = 0;
                j = 2;
                Licznik++;
                tabela02.Enabled = false;
                tabela02.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela02.Image;
                tabela02.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela12_Click(object sender, EventArgs e)
        {
            if(Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela12.Image;
                i = 1;
                j = 2;
                Licznik++;
                tabela12.Enabled = false;
                tabela12.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela12.Image;
                tabela12.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela22_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela22.Image;
                i = 2;
                j = 2;
                Licznik++;
                tabela22.Enabled = false;
                tabela22.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela22.Image;
                tabela22.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela32_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela32.Image;
                i = 3;
                j = 2;
                Licznik++;
                tabela32.Enabled = false;
                tabela32.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela32.Image;
                tabela32.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela42_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela42.Image;
                i = 4;
                j = 2;
                Licznik++;
                tabela42.Enabled = false;
                tabela42.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela42.Image;
                tabela42.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela52_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela52.Image;
                i = 5;
                j = 2;
                Licznik++;
                tabela52.Enabled = false;
                tabela52.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela52.Image;
                tabela52.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela03_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela03.Image;
                i = 0;
                j = 3;
                Licznik++;
                tabela03.Enabled = false;
                tabela03.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela03.Image;
                tabela03.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela13_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela13.Image;
                i = 1;
                j = 3;
                Licznik++;
                tabela13.Enabled = false;
                tabela13.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela13.Image;
                tabela13.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela23_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela23.Image;
                i = 2;
                j = 3;
                Licznik++;
                tabela23.Enabled = false;
                tabela23.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela23.Image;
                tabela23.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela33_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela33.Image;
                i = 3;
                j = 3;
                Licznik++;
                tabela33.Enabled = false;
                tabela33.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela33.Image;
                tabela33.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela43_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela43.Image;
                i = 4;
                j = 3;
                Licznik++;
                tabela43.Enabled = false;
                tabela43.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela43.Image;
                tabela43.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela53_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela53.Image;
                i = 5;
                j = 3;
                Licznik++;
                tabela53.Enabled = false;
                tabela53.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela53.Image;
                tabela53.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela04_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela04.Image;
                i = 0;
                j = 4;
                Licznik++;
                tabela04.Enabled = false;
                tabela04.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela04.Image;
                tabela04.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela14_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela14.Image;
                i = 1;
                j = 4;
                Licznik++;
                tabela14.Enabled = false;
                tabela14.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela14.Image;
                tabela14.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                postać.move--;
                ingamestats.Text = Statystyki();
                
            }
        }
        private void tabela24_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela24.Image;
                i = 2;
                j = 4;
                Licznik++;
                tabela24.Enabled = false;
                tabela24.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela24.Image;
                tabela24.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela34_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela34.Image;
                i = 3;
                j = 4;
                Licznik++;
                tabela34.Enabled = false;
                tabela34.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela34.Image;
                tabela34.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela44_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela44.Image;
                i = 4;
                j = 4;
                Licznik++;
                tabela44.Enabled = false;
                tabela44.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela44.Image;
                tabela44.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela54_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela54.Image;
                i = 5;
                j = 4;
                Licznik++;
                tabela54.Enabled = false;
                tabela54.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela54.Image;
                tabela54.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela05_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela05.Image;
                i = 0;
                j = 5;
                Licznik++;
                tabela05.Enabled = false;
                tabela05.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela05.Image;
                tabela05.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela15_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela15.Image;
                i = 1;
                j = 5;
                Licznik++;
                tabela15.Enabled = false;
                tabela15.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela15.Image;
                tabela15.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela25_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela25.Image;
                i = 2;
                j = 5;
                Licznik++;
                tabela25.Enabled = false;
                tabela25.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela25.Image;
                tabela25.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela35_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela35.Image;
                i = 3;
                j = 5;
                Licznik++;
                tabela35.Enabled = false;
                tabela35.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela35.Image;
                tabela35.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                postać.move--;
                ingamestats.Text = Statystyki();
                
            }
        }
        private void tabela45_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela45.Image;
                i = 4;
                j = 5;
                Licznik++;
                tabela45.Enabled = false;
                tabela45.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela45.Image;
                tabela45.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        private void tabela55_Click(object sender, EventArgs e)
        {
            if (Licznik == 0 && postać.move != 0)
            {
                pomocnyPB.Image = tabela55.Image;
                i = 5;
                j = 5;
                Licznik++;
                tabela55.Enabled = false;
                tabela55.BackColor = Color.Red;
            }
            else if (Licznik == 1)
            {
                Plansza[j, i].Image = tabela55.Image;
                tabela55.Image = pomocnyPB.Image;
                Plansza[j, i].Enabled = true;
                Plansza[j, i].BackColor = Color.Transparent;
                Licznik--;
                Plansza = Sprawdzanie(Plansza);
                
                postać.move--;
                ingamestats.Text = Statystyki();
            }
        }
        //UDOGODNIENIA?? XD
        private void koniectury_Click(object sender, EventArgs e)
        {
            Licznik = 0;
            Plansza[j, i].Enabled = true;
            Plansza[j, i].BackColor = Color.Transparent;
            Plansza = Sprawdzanie(Plansza);
            ingamestats.Text = Statystyki();
            postać.move = 0;
            DMG();
            if (wrogowie > 5)
            {
                MessageBox.Show("Pokonano wszystkich obecnych przeciwników");
                Close();
            }
        }

        private void twórcy_powrót_Click(object sender, EventArgs e)
        {
            postaćpreview.Image = null;
            postaćpreview.Visible = false;
            twórcy_powrót.Visible = false;
            kod.Visible = false;
            grafika.Visible = false;
            title.Visible = false;
            twórcy_powrót.Visible = false;
            OtwieramMenu();
        }
        //Magia oblicznia

    }
}
