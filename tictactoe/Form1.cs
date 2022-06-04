namespace tictactoe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true= X turn; false= Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Ibay", "Tic Tac Toe About");
        }

        private void exitGmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
             
            turn = !turn;
            b.Enabled = false;

            checkforwinner();
        }

        private void checkforwinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks

            if ((A1.Text == A2.Text) & (A2.Text == A3.Text) & (!A1.Enabled))
            there_is_a_winner = true;          
           else if ((B1.Text == B2.Text) & (B2.Text == B3.Text) & (!B1.Enabled))
                there_is_a_winner = true;           
           else if ((C1.Text == C2.Text) & (C2.Text == C3.Text) & (!C1.Enabled))
                there_is_a_winner = true;

            

            if (there_is_a_winner)
            {
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";
                MessageBox.Show(winner + "Wins!", "Yay!");

                }//end if

        }//end checkforwinner

    }

}