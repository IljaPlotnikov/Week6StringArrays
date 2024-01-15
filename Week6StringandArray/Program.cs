string userName = "Darth Vader";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Lenght - 1]}. ");


//replace
//a - 4

string updateUserName = userName.Replace('a', '4').Replace('e', '3');

Console.WriteLine(updateUserName);