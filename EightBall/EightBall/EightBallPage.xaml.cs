using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightBall
{
    public partial class EightBallPage
    {
        Random rand = new Random();
        public EightBallPage()
        {
            InitializeComponent();
        }

        private void OnShake(object sender, EventArgs e)
        {
            string[] options = {" It is certain"
    , " It is decidedly so"
    , " Without a doubt"
    , " Yes definitely"
    , " You may rely on it"
    , " As I see it, yes"
    , " Most likely"
    , " Outlook good"
    , " Yes"
    , " Signs point to yes"

    , " Reply hazy try again"
    , " Ask again later"
    , " Better not tell you now"
    , " Cannot predict now"
    , " Concentrate and ask again"

    , " Don't count on it"
    , " My reply is no"
    , " My sources say no"
    , " Outlook not so good"
    , " Very doubtful "
};

            //get a random number
            int index = rand.Next(options.Length);
            fortune.Text = options[index];


        }
    }
}
