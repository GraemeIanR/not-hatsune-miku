using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace not_hatsune_miku
{
    public partial class Form1 : Form
    {
        //define all the variables
        bool dPressed = false;
        bool fPressed = false;
        bool jPressed = false;
        bool kPressed = false;

        bool escPressed = false;


        int tick = 0;
        int score = 0;
        int life = 100;
        int combo = 0;


        //create the note list
        List<Rectangle> notes = new List<Rectangle>();

        //visible hitzones
        Rectangle d = new Rectangle(0, 620, 50, 30);
        Rectangle f = new Rectangle(100, 620, 50, 30);
        Rectangle j = new Rectangle(200, 620, 50, 30);
        Rectangle k = new Rectangle(300, 620, 50, 30);


        //define actual hitzones
        Rectangle DPe = new Rectangle(0, 610, 50, 40);
        Rectangle DGr = new Rectangle(0, 580, 50, 30);
        Rectangle DGo = new Rectangle(0, 550, 50, 30);


        Rectangle FPe = new Rectangle(100, 610, 50, 40);
        Rectangle FGr = new Rectangle(100, 580, 50, 30);
        Rectangle FGo = new Rectangle(100, 550, 50, 30);


        Rectangle JPe = new Rectangle(200, 610, 50, 40);
        Rectangle JGr = new Rectangle(200, 580, 50, 30);
        Rectangle JGo = new Rectangle(200, 550, 50, 30);


        Rectangle KPe = new Rectangle(300, 610, 50, 40);
        Rectangle KGr = new Rectangle(300, 580, 50, 30);
        Rectangle KGo = new Rectangle(300, 550, 50, 30);


        Random random = new Random();


        //define brushes used
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        //define debugging brushes
        SolidBrush peHitzone = new SolidBrush(Color.Red);
        SolidBrush grHitzone = new SolidBrush(Color.Gray);
        SolidBrush goHitzone = new SolidBrush(Color.Green);

        //define note lanes
        int laneD = 0;
        int laneF = 100;
        int laneJ = 200;
        int laneK = 300;

        public Form1()
        {
            InitializeComponent();
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //creating notes in random postions
            if (tick % 20 == 0)
            {
                int laneChoice = random.Next(1, 5);
                
                if (laneChoice == 1)
                {
                    Rectangle newNote = new Rectangle(laneD, 0, 50, 30);
                    notes.Add(newNote);
                }
                else if (laneChoice == 2)
                {
                    Rectangle newNote = new Rectangle(laneF, 0, 50, 30);
                    notes.Add(newNote);
                }
                else if (laneChoice == 3)
                {
                    Rectangle newNote = new Rectangle(laneJ, 0, 50, 30);
                    notes.Add(newNote);
                }
                else if (laneChoice == 4)
                {
                    Rectangle newNote = new Rectangle(laneK, 0, 50, 30);
                    notes.Add(newNote);
                }
            }

            //check for collision with the "D" hitzones
            for (int i = 0; i < notes.Count; i++)
            {
                if (dPressed && DPe.IntersectsWith(notes[i]))
                //if it collides with any hitzones, add score, change combo, update accuracy label, and remove note
                {
                    notes.RemoveAt(i);
                    dPressed = false;
                    score += 100;
                    combo++;
                    skillLabel.Text = "Perfect";
                }
                else if (dPressed && DGr.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    dPressed = false;
                    score += 50;
                    combo++;
                    skillLabel.Text = "Great";
                }
                else if (dPressed && DGo.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    dPressed = false;
                    score += 30;
                    combo = 0;
                    skillLabel.Text = "Good";
                }
                else if (dPressed && d.IntersectsWith(notes[i]) == false)
                {
                    //remove life if missed
                    life -= 5;
                    combo = 0;
                    dPressed = false;
                    skillLabel.Text = "Miss";
                }
            }

            for (int i = 0; i < notes.Count; i++)
            {
                if (fPressed && FPe.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    fPressed = false;
                    score += 100;
                    combo++;
                    skillLabel.Text = "Perfect";
                }
                else if (fPressed && FGr.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    fPressed = false;
                    score += 50;
                    combo++;
                    skillLabel.Text = "Great";
                }
                else if (fPressed && FGo.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    fPressed = false;
                    score += 30;
                    combo = 0;
                    skillLabel.Text = "Good";
                }
                else if (fPressed && f.IntersectsWith(notes[i]) == false)
                {
                    life -= 5;
                    combo = 0;
                    fPressed = false;
                    skillLabel.Text = "Miss";
                }
            }

            for (int i = 0; i < notes.Count; i++)
            {
                if (jPressed && JPe.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    jPressed = false;
                    score += 100;
                    combo++;
                    skillLabel.Text = "Perfect";
                }
                else if (jPressed && JGr.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    jPressed = false;
                    score += 50;
                    combo++;
                    skillLabel.Text = "Great";
                }
                else if (jPressed && JGo.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    jPressed = false;
                    score += 30;
                    combo = 0;
                    skillLabel.Text = "Good";
                }
                else if (jPressed && j.IntersectsWith(notes[i]) == false)
                {
                    life -= 5;
                    combo = 0;
                    jPressed = false;
                    skillLabel.Text = "Miss";
                }
            }

            for (int i = 0; i < notes.Count; i++)
            {
                if (kPressed && KPe.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    kPressed = false;
                    score += 100;
                    combo++;
                    skillLabel.Text = "Perfect";
                }
                else if (kPressed && KGr.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    kPressed = false;
                    score += 50;
                    combo++;
                    skillLabel.Text = "Great";
                }
                else if (kPressed && KGo.IntersectsWith(notes[i]))
                {
                    notes.RemoveAt(i);
                    kPressed = false;
                    score += 30;
                    combo = 0;
                    skillLabel.Text = "Good";
                }
                else if (kPressed && k.IntersectsWith(notes[i]) == false)
                {
                    life -= 5;
                    combo = 0;
                    kPressed = false;
                    skillLabel.Text = "Miss";
                }
            }

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Y > this.Height)
                {
                    notes.RemoveAt(i);
                    life -= 5;
                    combo = 0;
                    skillLabel.Text = "Miss";
                }
            }

            for (int i = 0; i < notes.Count; i++)
            {
                int y = notes[i].Y + 5;
                notes[i] = new Rectangle(notes[i].X, y, 50, 30);
            }

            tick++;

            if (escPressed == true)
            {
                Close();
            }

            if (life == 0)
            {
                gameTimer.Stop();
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draw all relevant variables
            tickLabel.Text = $"Tick: {tick}";
            lifeLabel.Text = $"Life {life}";
            scoreLabel.Text = $"Score {score}";
            comboLabel.Text = $"{combo}";


            //draw hitzones
            e.Graphics.FillRectangle(blackBrush, d);
            e.Graphics.FillRectangle(blackBrush, f);
            e.Graphics.FillRectangle(blackBrush, j);
            e.Graphics.FillRectangle(blackBrush, k);


            //draw actual hitzones for debugging
            //e.Graphics.FillRectangle(peHitzone, DPe);
            //e.Graphics.FillRectangle(grHitzone, DGr);
            //e.Graphics.FillRectangle(goHitzone, DGo);


            //draw notes
            for (int i = 0; i < notes.Count; i++)
            {
                e.Graphics.FillRectangle(blueBrush, notes[i]);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check for when buttons are pressed
            switch (e.KeyChar)
            {
                case 'd':
                    dPressed = true;
                    break;
                case 'f':
                    fPressed = true;
                    break;
                case 'j':
                    jPressed = true;
                    break;
                case 'k':
                    kPressed = true;
                    break;
                case 'e':
                    escPressed = true;
                    break;
            }
        }
    }
}
