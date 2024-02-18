using ChallengeApp;
User user1 = new User("Krysia", "874rujyhdci");
User user2 = new User("Andrzej", "874rujyhdci");
User user3 = new User("Zosia", "874rujyhdci");
User user4 = new User("Justyna", "874rujyhdci");


user1.AddScore(5);
user1.AddScore(12);
user1.AddScore(7);
user1.AddScore(4);

user2.AddScore(7);
user2.AddScore(9);
user2.AddScore(14);
user2.AddScore(9);

user3.AddScore(9);
user3.AddScore(2);
user3.AddScore(1);
user3.AddScore(13);

user4.AddScore(7);
user4.AddScore(18);
user4.AddScore(4);
user4.AddScore(7);

List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User userWithMaxResult = null;

foreach (var user in users)
{
    if (user1.Result > maxResult)
    {
        userWithMaxResult = user1;
        maxResult = user1.Result;
    }
    else if (user2.Result > maxResult)
    {
        userWithMaxResult = user2;
        maxResult = user2.Result;
    }
    else if (user3.Result > maxResult)
    {
        userWithMaxResult = user3;
        maxResult = user3.Result;
    }
    else if (user4.Result > maxResult)
    {
        userWithMaxResult = user4;
        maxResult = user4.Result;
    }
    }

Console.WriteLine($"największa ilość punktów: {maxResult} {userWithMaxResult.Login}");