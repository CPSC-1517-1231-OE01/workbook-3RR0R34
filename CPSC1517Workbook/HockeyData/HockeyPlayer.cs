using System.Reflection.Metadata;

namespace Hockey.Data
{
    public class HockeyPlayer
    {
        //data fields
        private string _firstName;
        private string _lastName;
        private string _birthPlace;
        private DateOnly _DateofBirth;
        private int _heightinInches;
        private int _weightinPounds;

        //we don't need the following
        //private Position _position;
        //private Shots _shots;
        //properties
        public String FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth Place cannot be null or empty");
                }
                _firstName = value;

            }
        }
        public String LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth Place cannot be null or empty");
                }
                _lastName = value;

            }
        }
        public String BirthPlace
        {
            get 
            {
                return _birthPlace;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Birth Place cannot be null or empty");
                }
                    _birthPlace = value;
                
            }
        }
        public DateOnly DateofBirth
        {
            get
            {
                return _DateofBirth;
            }
            set
            {
                // validity check for dates in the future
                //check documentation for dateonly
                if (_DateofBirth >= value)
                {
                    throw new ArgumentException("How are you born in the future?");
                }
                _DateofBirth = value;
            }
        }
        public int HeightinInches
        {
            get 
            {
                return _heightinInches;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be positive.");
                }
                _heightinInches = value;
            }
        }
        public int WeightinPounds
        {
            get
            {
                return _weightinPounds;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight must be positive.");
                }
                _weightinPounds = value;
            }
        }

        //auto implemented property
        public Position Position
        {
            get;set;
        }
        public Shots Shots
        {
            get;set;
        }
        //constructors
        public HockeyPlayer()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _birthPlace = string.Empty;
            _DateofBirth = new DateOnly();
            _heightinInches = 0;
            _weightinPounds = 0;
            Shots = Shots.Left;
            Position = Position.Center;
        }
        public HockeyPlayer(string firstName, string lastName, string birthPlace, DateOnly dateOfBirth, int weightInPounds, int heightInInches, Shots shot, Position position)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
            DateofBirth = dateOfBirth;
            WeightinPounds = weightInPounds;
            HeightinInches = heightInInches;
            Position = position;
            Shots = shot;
        }
    }
}