using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wordle.Solvers;

namespace Wordle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void trialerrorBtn_Click(object sender, EventArgs e)
        {
            TrialandError trialandErrorSolver = new TrialandError(this);
            trialandErrorSolver.Solve();
        }

        private void trialerrorrestartBtn_Click(object sender, EventArgs e)
        {
            TrialandErrorRestart trialandErrorRestartSolver = new TrialandErrorRestart(this);
            trialandErrorRestartSolver.Solve();
        }

        private void backtrackBtn_Click(object sender, EventArgs e)
        {
            Backtrack backtrackSolver = new Backtrack(this, 100);
            backtrackSolver.Solve();
        }

        private void depthfirstBtn_Click(object sender, EventArgs e)
        {
            DepthFirst depthFirstSolver = new DepthFirst(this);
            depthFirstSolver.Solve();
        }

        private void breadthfirstBtn_Click(object sender, EventArgs e)
        {
            BreadthFirst breadthFirstSolver = new BreadthFirst(this);
            breadthFirstSolver.Solve();
        }

        private void astarBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            resultLabel.Text = string.Empty;
            endresultTxtbox.Text = string.Empty;
            textBox1.Text = string.Empty;

            TrialandError trialandErrorSolver = new TrialandError(this);
            TrialandErrorRestart trialandErrorRestartSolver = new TrialandErrorRestart(this);
            Backtrack backtrackSolver = new Backtrack(this, 100);
            DepthFirst depthFirstSolver = new DepthFirst(this);
            BreadthFirst breadthFirstSolver = new BreadthFirst(this);

            trialandErrorSolver.Reset();
            trialandErrorRestartSolver.Reset();
            backtrackSolver.Reset();
            depthFirstSolver.Reset();
            breadthFirstSolver.Reset();

            Console.WriteLine("Application state has been reset.");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void endresultTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void solvingRichTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public void ChangeRtText(string text)
        {
            richTextBox1.Text = text;
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
        public void ChangeResultLblText(string text)
        {
            resultLabel.Text = text;
        }
    }
}
