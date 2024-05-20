namespace move_game
{
    public partial class main : Form
    {
        int health = 100;
        int playerspeed = 5;

        bool goleft, goright;
        public main()
        {
            InitializeComponent();
        }

        //�̵� ������ ���� �� �� ������ �����̰� �ؾ���
        private void timer1_Tick(object sender, EventArgs e) //game main timer
        {
            if (goleft)
            {
                player.Left -= playerspeed;
            }
            if (goright)
            {
                player.Left += playerspeed;
            }
        }

        private void player_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        //home���� �Ӽ� ó��
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            //��ֹ� ������ ����
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "obstacle")
                    {   //player�� ��ġ�� ������ �� �ִ�.
                        if (player.Bounds.IntersectsWith(control.Bounds))
                        {

                        }
                    }
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }

            
        }
    }
}
