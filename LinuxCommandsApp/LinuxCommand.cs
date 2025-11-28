using System;

// File-scoped namespace
namespace LinuxCommandsApp;

public class LinuxCommand
{
    // Properties
    public string Command { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";
    public int CommandId { get; set; }

    // Needed for JSON deserialization
    public LinuxCommand()
    {
    }

    // Optional constructor for testing
    public LinuxCommand(string command, string description)
    {
        Command = command;
        Description = description;
    }

    // Method to display command info
    public void ShowCommandInfo()
    {
        if (!string.IsNullOrWhiteSpace(Category))
        {
            Console.WriteLine($"{Command} [{Category}]: {Description}");
        }
        else
        {
            Console.WriteLine($"{Command}: {Description}");
        }
    }
}
