namespace CopaFilmes.Application.Domain
{
    public class Match
    {
        public Movie HomeTeam { get; set; }
        public Movie AwayTeam { get; set; }

        public Movie Winner { get; set; }

        public void PlayMatch()
        {
            if (HomeTeam.Nota > AwayTeam.Nota)
                Winner = HomeTeam;
            else if(HomeTeam.Nota < AwayTeam.Nota)
                Winner = AwayTeam;
            else
                TieBreak();
        }

        private void TieBreak()
        {
            Winner = string.CompareOrdinal(HomeTeam.Titulo, AwayTeam.Titulo) < 0 ? HomeTeam : AwayTeam;
        }
    }
}
