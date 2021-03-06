namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                m_score1 += 1;
            else
                m_score2 += 1;
        }

        private string EvenScores()
        {
            string score = "";
            switch (m_score1)
            {
                case 0:
                    score = "Love-All";
                    break;
                case 1:
                    score = "Fifteen-All";
                    break;
                case 2:
                    score = "Thirty-All";
                    break;
                default:
                    score = "Deuce";
                    break;
            }
            return score;
        }

        private string Above4Points()
        {   
            string score = "";
            var minusResult = m_score1 - m_score2;
            if (minusResult == 1) score = "Advantage player1";
            else if (minusResult == -1) score = "Advantage player2";
            else if (minusResult >= 2) score = "Win for player1";
            else score = "Win for player2";
            return score;
        }

        private bool isAbove4Points()
        {
            if (m_score1 >= 4 || m_score2 >= 4) return true;
            else { return false; }
        }
  
        private string Under4Points()
        {
            string score = "";
            var tempScore = m_score1;
            for (var i = 1; i < 3; i++)
            {
                if (i > 1) score += "-";
                
                switch (tempScore)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
                tempScore = m_score2;
            }
            return score;
        }

        public string GetScore()
        {
            if (m_score1 == m_score2)
            {
                return EvenScores();
            }
            else if (isAbove4Points())
            {
               return Above4Points();
            }
            else
            {
               return Under4Points();
            }
        }
    }
}

