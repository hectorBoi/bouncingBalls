namespace BallPit
{
    public partial class Form1 : Form
    {
        public static Bitmap bmp;
        Graphics g;
        Ball myBall;
        public static Deez deez1;
        public float ysgmnt;
        public float xsgmnt;
        public Form1()
        {
            InitializeComponent();
            deez1 = new Deez();
            Init();
            myBall = new Ball();
            deez1.nuts.Add(myBall);
            
            



        }

        private void Init()
        {
            bmp = new Bitmap(BallPitPCTBX.Width, BallPitPCTBX.Height);
            ysgmnt= bmp.Height/1000;
            xsgmnt= bmp.Width/1000;
            g = Graphics.FromImage(bmp);
            BallPitPCTBX.Image = bmp;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            timer1.Enabled= true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Render(deez1);
        }

        public void Render(Deez deez)
        {
            g.Clear(Color.Black);
            for (int f = 0; f < deez.nuts.Count; f++)
            {
                Ball tBall = deez.nuts[f];
                tBall.Update();
                g.FillEllipse(tBall.ballBrush, tBall.ballPos.X, tBall.ballPos.Y, tBall.ballDiameter, tBall.ballDiameter);
            }
            BallPitPCTBX.Invalidate();

        }

        private void newBallButton_Click(object sender, EventArgs e)
        {
            myBall = new Ball();
            deez1.nuts.Add(myBall);
        }
    }
}