using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallPit
{

    public class Ball
    {
        PointF speed;
        Color ballColor;
        PointF centroid;
        public SolidBrush ballBrush;
        public float ballDiameter;
        public PointF ballPos;
        float xsgmnt, ysgmnt;


        private Random rnd = new Random();
        public Ball()
        {
            xsgmnt = Form1.bmp.Width/100;
            ysgmnt = Form1.bmp.Height/100;  

            speed= new PointF(xsgmnt*1,ysgmnt*1);
            ballDiameter= xsgmnt*rnd.Next(10,15);
            ballPos = new PointF(0,0);
            ballColor = Color.FromArgb(rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255));
            ballBrush = new SolidBrush(ballColor);

        }

        public void Update()
        {
            InBounds();
            getCentroid();
            otherCollisions();
            Move();

        }

        private void InBounds()
        {
            if (ballPos.Y + ballDiameter + speed.Y >= Form1.bmp.Height || ballPos.Y + speed.Y <= 0)
            {
                speed.Y *= -1;
            }

            if (ballPos.X + ballDiameter + speed.X >= Form1.bmp.Width || ballPos.X + speed.X <= 0)
            {
                speed.X *= -1;
            }

        }

        private void getCentroid()
        {
            centroid = new PointF(ballPos.X+ballDiameter/2, ballPos.Y + ballDiameter / 2);
        }

        private void otherCollisions()
        {
            int j = 0;
            for (int i = 0; i<Form1.deez1.nuts.Count; i++)
            {
                Ball ball1 = Form1.deez1.nuts[i];
                j++;
                for (int k = j; k< Form1.deez1.nuts.Count;  k++)
                {
                    Ball ball2 = Form1.deez1.nuts[k];
                    float distance = (float)Math.Sqrt(Math.Pow((ball2.centroid.X+ball2.speed.X - ball1.centroid.X+ball1.speed.X), 2) + Math.Pow((ball2.centroid.Y+ball2.speed.Y - ball1.centroid.Y+ball1.speed.Y), 2));
                    if (distance <= ball1.ballDiameter / 2 + ball2.ballDiameter / 2)
                    {
                        ball1.speed.X *= -1;
                        ball1.speed.Y *= -1;

                        ball2.speed.X *= -1;
                        ball2.speed.Y *= -1;
                    }
                }
            }
        }

        private void Move()
        {
            ballPos.X += speed.X;
            ballPos.Y += speed.Y;
        }

    }
}
