namespace GuessNumber
{
    public partial class Form1 : Form
    {
        int number=0;
        int tryCount = 0;
        public Form1()
        {
            InitializeComponent();
            MenuStrip menuStrip1 = new MenuStrip()
            {
                ForeColor = Color.Black,
                BackColor = Color.White,
                Size = new Size(200, 200)
            };
            this.Controls.Add(menuStrip1);


            ToolStripMenuItem item1 = new ToolStripMenuItem("Новая игра");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Правила игры");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Выход");
          
            //item1.DropDownItems.AddRange(new ToolStripMenuItem[] { item4, item5 });
            item1.Click += Item1_Click;
            item2.Click += Item2_Click;
            item3.Click += Item3_Click;
            
            menuStrip1.Items.AddRange(new ToolStripMenuItem[] { item1, item2, item3 });
            numberTextBox.Enabled = false;
        }
        private void Item1_Click(object sender, EventArgs e)
        {
            WinLabel.Visible = false;
            Random r = new Random();
            number = r.Next(1, 100);
            tryCount = 0;
            TryCountLabel.Text = tryCount.ToString();
            numberTextBox.Enabled = true;

            numberTextBox.Text = "";
        }
        private void Item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("компьютер загадывает число,\nигрок делает предположение,\nкомпьютер дает подсказку,\nпока число не будет угадано","Info",buttons:MessageBoxButtons.OK,icon:MessageBoxIcon.Information);

        }
        private void Item3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numberTextBox.Text) == number)
            {
                WinLabel.Visible = true;
            }
            else
            {
                tryCount++;
                TryCountLabel.Text = tryCount.ToString();
            }
            MessageBox.Show(number.ToString());
        }
    }
}
   