using System;
using System.Text.Json;

namespace LinuxCommandsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Quick constructor test
                LinuxCommand command1 = new("ls", "list files");
                command1.ShowCommandInfo();

                // JSON file path
                string filePath = Path.Combine(AppContext.BaseDirectory, "linux-commands.json");

                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File not found at {filePath}");
                    return;
                }

                // Read JSON
                string jsonString = File.ReadAllText(filePath);

                // Display raw JSON (optional)
                Console.WriteLine();
                Console.WriteLine("Raw JSON:");
                Console.WriteLine(jsonString);
                Console.WriteLine();

                // Convert JSON → List<LinuxCommand>
                List<LinuxCommand>? allCommands =
                    JsonSerializer.Deserialize<List<LinuxCommand>>(jsonString);

                if (allCommands == null || allCommands.Count == 0)
                {
                    Console.WriteLine("No commands found in JSON.");
                }
                else
                {
                    Console.WriteLine("=== Linux Commands ===");
                    Console.WriteLine();

                    foreach (LinuxCommand cmd in allCommands)
                    {
                        cmd.ShowCommandInfo();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
