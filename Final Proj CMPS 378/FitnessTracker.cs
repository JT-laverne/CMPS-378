using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<User> Users = new List<User>();

    // Main Function
    static void Main() 
    {
        while (true)
        {
            Console.WriteLine("\n==== Health & Fitness Tracker ====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Delete Account");
            Console.WriteLine("3. Add Activity");
            Console.WriteLine("4. Remove Activity");
            Console.WriteLine("5. View Fitness History");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateAccount(); break;
                case "2": DeleteAccount(); break;
                case "3": AddActivity(); break;
                case "4": RemoveActivity(); break;
                case "5": ViewHistory(); break;
                case "6": return;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    //Select User Account
    static User SelectUser()
    {
        Console.Write("Enter username: ");
        string name = Console.ReadLine();

        User user = Users.FirstOrDefault(u => u.Name == name);
        if (user == null)
            Console.WriteLine("User not found!");

        return user;
    }

    // Create User Account
    static void CreateAccount()
    {
        Console.Write("Enter new username: ");
        string name = Console.ReadLine();

        if (Users.Any(u => u.Name == name))
        {
            Console.WriteLine("User already exists!");
            return;
        }

        Users.Add(new User(name));
        Console.WriteLine("Account created!");
    }

    // Delete User
    static void DeleteAccount()
    {
        User user = SelectUser();
        if (user == null) return;

        Users.Remove(user);
        Console.WriteLine("Account deleted!");
    }

    // Add Activity
    static void AddActivity()
    {
        User user = SelectUser();
        if (user == null) return;

        Console.WriteLine("Choose type: 1=Run, 2=Walk, 3=Eat");
        string typeInput = Console.ReadLine();

        ActivityType type;
        switch (typeInput)
        {
            case "1": type = ActivityType.Run; break;
            case "2": type = ActivityType.Walk; break;
            case "3": type = ActivityType.Eat; break;
            default: Console.WriteLine("Invalid."); return;
        }

        Console.Write("Enter value (km for run/walk, calories for eating): ");
        if (!double.TryParse(Console.ReadLine(), out double value))
        {
            Console.WriteLine("Invalid number.");
            return;
        }

        user.History.Add(new Activity(type, value));
        Console.WriteLine("Activity added!");
    }

    // Remove Activity
    static void RemoveActivity()
    {
        User user = SelectUser();
        if (user == null) return;

        ViewHistory(user);
        Console.Write("Enter activity number to remove: ");

        if (int.TryParse(Console.ReadLine(), out int index))
        {
            index--;
            if (index >= 0 && index < user.History.Count)
            {
                user.History.RemoveAt(index);
                Console.WriteLine("Removed!");
            }
            else Console.WriteLine("Invalid index.");
        }
    }

    // View history & calorie summary
    static void ViewHistory()
    {
        User user = SelectUser();
        if (user == null) return;

        ViewHistory(user);
    }

    static void ViewHistory(User user)
    {
        Console.WriteLine($"\n=== {user.Name}'s Fitness History ===");

        if (user.History.Count == 0)
        {
            Console.WriteLine("No activity yet.");
            return;
        }

        double caloriesBurned = 0;
        double caloriesEaten = 0;

        for (int i = 0; i < user.History.Count; i++)
        {
            Activity a = user.History[i];
            Console.WriteLine($"{i + 1}. {a}");

            if (a.Type == ActivityType.Eat) caloriesEaten += a.Value;
            else caloriesBurned += a.Value * 60; // simple estimate: 60 cal per km for run/walk
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Calories Burned: {caloriesBurned}");
        Console.WriteLine($"Calories Eaten: {caloriesEaten}");
        Console.WriteLine($"Net Calories: {caloriesEaten - caloriesBurned}");
    }
}

//User Account
class User
{
    public string Name;
    public List<Activity> History = new();

    public User(string name)
    {
        Name = name;
    }
}

//Activity class of running/walking/eating
class Activity
{
    public ActivityType Type;
    public double Value;

    public Activity(ActivityType type, double value)
    {
        Type = type;
        Value = value;
    }

    public override string ToString()
    {
        return Type switch
        {
            ActivityType.Run => $"Running: {Value} km",
            ActivityType.Walk => $"Walking: {Value} km",
            ActivityType.Eat => $"Eating: {Value} cal",
            _ => "Unknown"
        };
    }
}

enum ActivityType { Run, Walk, Eat }
