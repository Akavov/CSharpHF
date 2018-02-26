using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    class Bat
    {
        private BatCallback hitBallCallBack;
        public Bat(BatCallback callbackDelegate)
        {
            this.hitBallCallBack = new BatCallback(callbackDelegate);
        }
        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallBack!=null)
            {
                hitBallCallBack(e);
            }
        }
    }
}
