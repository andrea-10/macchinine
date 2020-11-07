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

namespace macchinine

    //programma che simuli la corsa tra 2 macchine
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();


            //inizio
            bgw1.DoWork += bgw1_DoWork;
            bgw2.DoWork += bgw1_DoWork;


            //quando finisce, vanno nello stessa fine
            bgw1.RunWorkerCompleted += bgw1_RunWorkerCompleted;


            bgw2.RunWorkerCompleted += bgw1_RunWorkerCompleted;




        }


        private void bgw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //torna visibile il bottone avvia
            btn1.Visible = true;
        }

        private void pct3_Click(object sender, EventArgs e)
        {
          
        }

        //procedimento gara
        private void bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();
            
            int numero = 0;
            int numero2 = 0;


          //prende la posizione delle picture box
            int posy = pct1.Location.Y;
            int posy2 = pct2.Location.Y;


            //ciclo for che permette di generare ogni volta dei numeri random, 1000 è un numero scelto a piacere
            for (int i = 0; i < 1000; i++)
            {
                numero += r.Next(0, 30);
                numero2 += r.Next(0, 30);
                pct1.Location = new Point(numero, posy);
                pct2.Location = new Point(numero2, posy2);
                Thread.Sleep(50);



                //arriva al traguardo
                if (numero > 1500)
                {
                    DialogResult drg = MessageBox.Show(" riprovare?", "LA MACCHINA NERA HA VINTO!", MessageBoxButtons.YesNo);




                    if (drg == DialogResult.No)
                    {
                        Application.Exit();
                    }


                    bgw1.CancelAsync();
                    bgw2.CancelAsync();

                }




                //arriva al traguardo
                if (numero2 > 1500)
                {
                    DialogResult drg = MessageBox.Show(" riprovare?", "LA MACCHINA ROSSA HA VINTO!", MessageBoxButtons.YesNo);


                    if (drg == DialogResult.No)
                    {
                        Application.Exit();
                    }

                    bgw1.CancelAsync();
                    bgw2.CancelAsync();

                }
            }

        }

        private void pct1_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        //parte la gara

        private void btn1_Click(object sender, EventArgs e)
        {


            bgw1.RunWorkerAsync();
            bgw2.RunWorkerAsync();


            btn1.Visible = false;


        }
    }
}
