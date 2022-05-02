namespace MovieDataViewer
{
    public partial class MovieViewer : Form
    {
        public MovieViewer()
        {
            InitializeComponent();
        }
        public int alpha = 255;
        public bool showLogo = true;
        private void colorTransition(object sender)
        {
            /*if (showLogo)
            {
                while (alpha > 255)
                {
                    if(alpha >= 255)
                    {
                        TempLOGO.ForeColor = Color.FromArgb(255, 255, 192, 128);
                    }
                    else
                    {
                        TempLOGO.Visible = true;
                        TempLOGO.Enabled = true;
                        alpha++;
                        TempLOGO.ForeColor = Color.FromArgb(alpha, 255, 192, 128);
                    }
                }
                /*if(alpha <= 254)
                {
                    TempLOGO.Visible = true;
                    TempLOGO.Enabled = true;
                    alpha++;
                    TempLOGO.ForeColor = Color.FromArgb(alpha, 255, 192, 128);
                }
                else
                {
                    TempLOGO.ForeColor = Color.FromArgb(255, 255, 192, 128);
                }*/

            /*}
            else
            {
                TempLOGO.Visible = false;
                TempLOGO.Enabled = false;
                while (alpha < 0)
                {
                    if(alpha <= 0)
                    {
                        TempLOGO.Visible = false;
                        TempLOGO.Enabled = false;
                        TempLOGO.ForeColor = Color.FromArgb(0, 255, 192, 128);
                    }
                    else
                    {
                        alpha--;
                        TempLOGO.ForeColor = Color.FromArgb(alpha, 255, 192, 128);
                    }
                    TempLOGO.Visible = false;
                    TempLOGO.Enabled = false;
                }
                /*if (alpha >= 1)
                {
                    alpha--;
                    TempLOGO.ForeColor = Color.FromArgb(alpha, 255, 192, 128);
                }
                else
                {
                    TempLOGO.Visible = false;
                    TempLOGO.Enabled = false;
                    TempLOGO.ForeColor = Color.FromArgb(0, 255, 192, 128);
                }*/
            //}
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void csvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Might be able to hide the unused components. 

            if (TempLOGO.Visible == false)
            {

                showLogo = true;
                //colorTransition(TempLOGO);
            }
            else
            {
                showLogo = false;
                //colorTransition(TempLOGO);

            }
            /*Form aboutForm = new AboutBox1();
            aboutForm.ShowDialog();*/
            Form form = new AboutBox1();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();

            /*MessageBox.Show("Home");
            if(TempLOGO.Visible == false)
            {
                TempLOGO.Visible = true;
                TempLOGO.Enabled = true;
                TempLOGO.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }
            else
            {
                TempLOGO.Visible = false;
                TempLOGO.Enabled = false;
                TempLOGO.ForeColor = Color.FromArgb(255, 255, 192, 128);
            }*/

        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TempLOGO_Click(object sender, EventArgs e)
        {

        }

    }
}