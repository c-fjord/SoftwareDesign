namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int p1point;
        private int p2point;

        private string p1res = "";
        private string p2res = "";
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            p1point = 0;
            this.player2Name = player2Name;
        }

        private string ScoreBelow4(int point)
        {
            var score = "";
            switch(point)
            {
                case 0:
                    score = "Love";
                break;
                    
                case 1:
                    score = "Fifteen";
                break;

                case 2:
                    score = "Thirty";
                break;

                case 3:
                    score = "Forty";
                break;
            }
            return score;
        }

        private bool isPlayerWinner(int p1, int p2)
        {
             if (p1>= 4 && p2>= 0 && (p1- p2) >= 2) return true;
             else { return false; }
        }

        private bool isPlayerAdvantage(int p1, int p2)
        {
            if (p1 > p2 && p2 >= 3) return true;
            else { return false;}
        }

        private bool isScoreAll()
        {
            if (p1point == p2point && p1point < 3) return true;
            else { return false; }
        }

        private bool isScoreDeuce()
        {
            if (p1point == p2point && p1point > 2) return true;
            else { return false; }
        }

        private bool isBelow4()
        {
            if (p1point <= 3 && p2point <= 3 && p1point != p2point) return true;
            else { return false; }
        }

        public string GetScore()
        {            
            if (isPlayerWinner(p1point, p2point))
            {
                return "Win for player1";
            }           
            else if (isPlayerWinner(p2point, p1point))
            {
                return "Win for player2";
            }
            else if (isScoreAll())
            {
                var s = ScoreBelow4(p1point);
                return s += "-All";
            }
            else if (isScoreDeuce())
            {
                return "Deuce";
            }
            else if (isBelow4())
            {
                return ScoreBelow4(p1point) + "-" + ScoreBelow4(p2point);
            }
            else if (isPlayerAdvantage(p1point, p2point))
            {
                return "Advantage player1";
            }
            else if (isPlayerAdvantage(p2point, p1point))
            {
                return "Advantage player2";
            }
            else
            {
                throw new System.Exception("Invalid score");
            }
        }

        private void P1Score()
        {
            p1point++;
        }

        private void P2Score()
        {
            p2point++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

    }
}

