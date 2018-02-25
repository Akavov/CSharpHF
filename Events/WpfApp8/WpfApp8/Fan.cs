using System;
using System.Collections.ObjectModel;

namespace WpfApp8
{
    class Fan
    {
        private int pitchNumber = 0;

        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        public ObservableCollection<string> FanSays = new ObservableCollection<string>();

        void ball_BallInPlay(object sender, EventArgs e)
        {
            pitchNumber++;
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if (ballEventArgs.Distance>400 && ballEventArgs.Trajectory>80)
                {
                    FanSays.Add("Pitch #" + pitchNumber +
                        ": Home run! I`m going for the ball!");
                }
                else
                {
                    FanSays.Add("Pitch #" + pitchNumber + ":Woo-hoo!Yeah!");
                }
            }
        }
    }
}