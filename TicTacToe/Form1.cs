using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool tah = true;
        int pocetTahu = 0;
        static string player1, player2;
        static string singlePlayer;
     

        public Form1()
        {
            InitializeComponent();
        }

        public static void SinglePLayer(string s1) 
        {
            singlePlayer = s1;
        }

        public static void PlayerNames(string n1, string n2)
        {
            player1 = n1;
            player2 = n2;
        }
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (tah)
                b.Text = "X";
            else
                b.Text = "O";

            tah = !tah;
            b.Enabled = false;
            pocetTahu++;
            winner_check();

            if ((!tah) && (L3.Text.ToUpper() == "MID"))
            {
                pcMoveMID();
            }

            //if ((tah) && (L1.Text.ToUpper() == "MID"))
            //{
            //    pcMoveMID();
            //}

            if ((!tah) && (L3.Text.ToUpper() == "EASY"))
            {
                pcMoveEasy();
            }

            if ((!tah) && (L3.Text.ToUpper() == "HARD"))
            {
                pcMoveHard_O();
            }

        }

        private void pcMoveHard_O()
        {
            Button move = null;


            move = firstMove_O();
            if (move == null)
            {
                move = winCheck_BlockCheck("O");
                if (move == null)
                {
                    move = winCheck_BlockCheck("X");
                    if (move == null)
                    {
                        move = hledaniRohu();
                        if (move == null)
                            move = openSpace();
                    }
                }
            }

            move.PerformClick();
        }

        private void pcMoveEasy()
        {
            Button move = null;
            move = hledaniRohu();
            if (move == null)
            {
                move = openSpace();
            }
            move.PerformClick();
        }

        private void pcMoveMID()
        {
            Button move = null;

            move = winCheck_BlockCheck("O");
            if (move == null)
            {
                move = winCheck_BlockCheck("X");
                if (move == null)
                {
                    move = hledaniRohu();
                    if (move == null)
                        move = openSpace();
                }
            }

            move.PerformClick();
        }

        private Button firstMove_O()
        {
            if (B2.Text == "")
                return B2;
            else
                return null;
        }

        //private Button secondMove_O()
        //{
           
        //}

        private Button winCheck_BlockCheck(string mark)
        {
            
            //Horizontálně
            if ((A1.Text == mark) && (A2.Text == mark) && (A3.Text == ""))
                return A3;
            else if ((A2.Text == mark) && (A3.Text == mark) && (A1.Text == ""))
                return A1;
            else if ((A1.Text == mark) && (A3.Text == mark) && (A2.Text == ""))
                return A2;

            else if ((B1.Text == mark) && (B2.Text == mark) && (B3.Text == ""))
                return B3;
            else if ((B2.Text == mark) && (B3.Text == mark) && (B1.Text == ""))
                return B1;
            else if ((B1.Text == mark) && (B3.Text == mark) && (B2.Text == ""))
                return B2;

            else if ((C1.Text == mark) && (C2.Text == mark) && (C3.Text == ""))
                return C3;
            else if ((C2.Text == mark) && (C3.Text == mark) && (C1.Text == ""))
                return C1;
            else if ((C1.Text == mark) && (C3.Text == mark) && (C2.Text == ""))
                return C2;

            //Vertikálně
            else if ((A1.Text == mark) && (B1.Text == mark) && (C1.Text == ""))
                return C1;
            else if ((B1.Text == mark) && (C1.Text == mark) && (A1.Text == ""))
                return A1;
            else if ((A1.Text == mark) && (C1.Text == mark) && (B1.Text == ""))
                return B1;

            else if ((A2.Text == mark) && (B2.Text == mark) && (C2.Text == ""))
                return C2;
            else if ((B2.Text == mark) && (C2.Text == mark) && (A2.Text == ""))
                return A2;
            if ((A2.Text == mark) && (C2.Text == mark) && (B2.Text == ""))
                return B2;

            else if ((A3.Text == mark) && (B3.Text == mark) && (C3.Text == ""))
                return C3;
            else if ((B3.Text == mark) && (C3.Text == mark) && (A3.Text == ""))
                return A3;
            else if ((A3.Text == mark) && (C3.Text == mark) && (B3.Text == ""))
                return B3;

            //Diagonálně
            else if ((A1.Text == mark) && (B2.Text == mark) && (C3.Text == ""))
                return C3;
            else if ((B2.Text == mark) && (C3.Text == mark) && (A1.Text == ""))
                return A1;
            else if ((A1.Text == mark) && (C3.Text == mark) && (B2.Text == ""))
                return B2;

            else if ((A3.Text == mark) && (B2.Text == mark) && (C1.Text == ""))
                return C1;
            else if ((B2.Text == mark) && (C1.Text == mark) && (A3.Text == ""))
                return A3;
            else if ((A3.Text == mark) && (C1.Text == mark) && (B2.Text == ""))
                return B2;

            return null;
        }

        private Button hledaniRohu()
        {
           
            if (A1.Text == "O")
            {
                if (A3.Text == "")
                    return A3;
                else if (C3.Text == "")
                    return C3;
                else if (C1.Text == "")
                    return C1;
            }

            else if(A3.Text == "O")
            {
                if (A1.Text == "")
                    return A1;
                else if (C3.Text == "")
                    return C3;
                else if(C1.Text == "")
                    return C1;
            }

            else if (C3.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                else if (A3.Text == "")
                    return A3;
                else if (C1.Text == "")
                    return C1;
            }

            else if (C1.Text == "O")
            {
                if (A1.Text == "")
                    return A3;
                else if (A3.Text == "")
                    return A3;
                else if (C3.Text == "")
                    return C3;
            }

            else if (A1.Text == "")
                return A1;
            else if (A3.Text == "")
                return A3;
            else if (C1.Text == "")
                return C1;
            else if (C3.Text == "")
                return C3;

            return null;
        }

        private Button openSpace()
        {

            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                        return b;
                }
            }
            return null;
        }

        private void winner_check()
        {
            bool winner = false;

            // Horizontální
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                winner = true;

            // Vertikální
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                winner = true;

            // Diagonální
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                winner = true;


            if (winner)
            {

                //Button_disable();

                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;
                string win = "";
                if (tah)
                {
                   
                    win = player2;
                    O_Vyhra.Text = (Int32.Parse(O_Vyhra.Text) + 1).ToString();
                }
                else
                {

                    
                    win = player1;
                    X_Vyhra.Text = (Int32.Parse(X_Vyhra.Text) + 1).ToString();
                }
                MessageBox.Show(win + " Vyhrál!", "Vítěz");
                protiHráčiToolStripMenuItem.PerformClick();
            }
            else
            {

                if (pocetTahu == 9)
                {
                    Remiza.Text = (Int32.Parse(Remiza.Text) + 1).ToString();
                    MessageBox.Show("Je to remíza");
                    protiHráčiToolStripMenuItem.PerformClick();
                }
            }
        }

        //private void Button_disable()
        //{
        //    try
        //    {
        //        foreach (Control c in Controls)
        //        {
        //            Button b = (Button)c;
        //            c.Enabled = false;
        //        }
        //    }
        //    catch { }
        //}

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opakovatHru()
        {
            tah = true;
            pocetTahu = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void protiHráčiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            opakovatHru();
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Enabled)
            {
                if (tah)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }
        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled == true)
                b.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void X_vyhra_Click(object sender, EventArgs e)
        {

        }

        private void resetnoutVýsledkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_Vyhra.Text = "0";
            Remiza.Text = "0";
            O_Vyhra.Text = "0";

            tah = true;
            pocetTahu = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NovaHra();
        }

        private void středníToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void neporazitelnáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hrátProtiNěkomuJinémuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_Vyhra.Text = "0";
            Remiza.Text = "0";
            O_Vyhra.Text = "0";

            tah = true;
            pocetTahu = 0;


            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
            NovaHra();
            
        }

        private void uložitVýsledkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("vysledky.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.Write(L1.Text);
            sw.Write(" ");
            sw.Write(L2.Text);
            sw.Write(" ");
            sw.Write(L3.Text);
            sw.WriteLine();
            sw.Write(X_Vyhra.Text);
            sw.Write(" ");
            sw.Write(Remiza.Text);
            sw.Write(" ");
            sw.Write(O_Vyhra.Text);
            sw.Close();
            fs.Close();
            MessageBox.Show("Výsledky se úspěšně uložili. :)", "Uložení");
        }

        private void L3_TextChanged(object sender, EventArgs e)
        {
            //if (L3.Text.ToUpper() == "EASY")
            //    PC = true;
            //else
            //    PC = false;
        }

        private void NovaHra()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();

            L1.Text = f2.T1.Text;
            L3.Text = f2.T2.Text;



        }
       
    }

}
