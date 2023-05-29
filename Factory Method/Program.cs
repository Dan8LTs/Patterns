using Factory_Method;

var telegram = new TelegramMessenger("Dan8LTs", "password");
telegram.CreateMessage("Good afternoon!", "Dan8LTs", "Maxim");

var instagram = new InstagramMessenger("Dan8LTs", "password");
//var photo = instagram.CreateMessage("path to photo", "Dan8LTs", "Maxim");
Console.ReadLine();