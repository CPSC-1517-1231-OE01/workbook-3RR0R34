namespace Hockey.Data
{
    public class HockeyPlayer
    {
        //data fields
        private string _firstName;
        private string _lastName;
        private string _BirthPlace;
        private DateOnly _DateofBirth;
        private int _heightinInches;
        private int _weightinPounds;

        private Position _position;
        private Shots _shots;
        //properties
        public String FirstName
        {
            get;
            set;
        }
        public String LastName
        {
            get;
            set;
        }
        public String BirthPlace
        {
            get;
            set;
        }
        public DateOnly DateofBirth
        {
            get;
            set;
        }
        public int HeightinInches
        {
            get;
            set;
        }
        public int WeightinPounds
        {
            get;
            set;
        }
        public Position Position
        {
            get;
            set;
        }
        public Shots Shots
        {
            get;
            set;
        }
        //constructors
        public void Hockeyplayer()
        {
        }
        public void PlayerConstruct(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth, int weightInPounds, int heightInInches, Shots shot, Position position)
        {
        }
    }
}