namespace KretaProject.Models
{
    
    public class Player
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public int Wins { get; set; }
        public int Matches { get; set; }
        public double Winrate => Matches == 0? 0:(double)(Wins) / Matches;

        public Player(string name, string email, DateTime createDate, int wins, int matches)
        {
            Name = name;
            Email = email;
            CreationDate = createDate;
            Wins = wins;
            Matches = matches;
        }

        public Player()
        {
            Name = string.Empty;
            Email = string.Empty;
            CreationDate = new DateTime();
            Wins = 0;
            Matches = 0;
        }
        public override string ToString()
        {
            return $"Username:{Name}; Email:{Email}; Account Created:{CreationDate}; Matches:{Matches}; Winrate:{Winrate}";
        }
        public string PlayerCheck()
        {
            string issues = "";
            if (Name.Length == 0) issues += "Missing username!\n";

            if (Email.Length == 0) issues += "Missing email!\n";
            else if (!Email.Contains("@") && !Email.Contains(".")) issues += "Invalid email address!\n";

            if (Wins > Matches) issues += "Player can't have more wins than matches!\n";

            return issues ;
        }
    }
}
