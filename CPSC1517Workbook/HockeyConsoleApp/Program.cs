using Hockey.Data;

Console.WriteLine("Welcome to this test app");

//default
HockeyPlayer player1 = new HockeyPlayer();
player1.FirstName = "Stewart";
player1.LastName = "Skinner";

//object-Initializer
HockeyPlayer player2 = new HockeyPlayer()
{
    FirstName = "IDK",
    LastName = "Funny",
};

//greedy
HockeyPlayer player3 = new HockeyPlayer("Woop", "Row", "Guard Sound, On", new DateOnly(1920, 3, 4), 196, 73, Shots.Right, Position.Defense);
// output things about the players
Console.WriteLine($"Player name:{player1.FirstName + player1.LastName} and they are born {player1.DateofBirth}");
Console.WriteLine($"Player name:{player2.FirstName + player2.LastName} and they are born {player2.DateofBirth}");
Console.WriteLine($"Player name:{player3.FirstName + player3.LastName} and they are born {player3.DateofBirth}");