using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public enum CommandSources
  {
    Twitch,
    YouTube,
    Trovo
  }

  public class SBCommand
  {
    public string? ID { get; set; }
    public string? Name { get; set; }
    public bool Enabled { get; set; }
    public string? Command { get; set; }
    public List<CommandSources>? Sources { get; set; }
    public List<string>? PermittedUsers { get; set; }
    public List<string>? PermittedGroups { get; set; }
    public bool Include { get; set; }
    public uint Mode { get; set; }
    public bool RegexExplicitCapture { get; set; }
    public uint Location { get; set; }
    public bool IgnoreBotAccount { get; set; }
    public bool IgnoreInternal { get; set; }
    public bool PersistCounter { get; set; }
    public bool PersistUserCounter { get; set; }
    public bool CaseSensitive { get; set; }
    public uint GlobalCooldown { get; set; }
    public uint UserCooldown { get; set; }
    public string? Group { get; set; }
    public uint GrantType { get; set; }
    public string Options
    {
      get
      {
        var opt = new List<string>();

        if (this.PersistCounter) opt.Add("PC");
        if (this.PersistUserCounter) opt.Add("PUC");
        if (this.CaseSensitive) opt.Add("CS");

        return opt.Count == 0 ? "None" : String.Join(", ", opt);
      }
    }

    public static List<SBCommand> GetAll()
    {
      Random random = new Random();

      var commands = new List<SBCommand>();

      for (int i = 0; i < 20; i++)
      {
        commands.Add(new SBCommand
        {
          ID = Guid.NewGuid().ToString(),
          Name = $"Command_{i}",
          Enabled = random.Next(0, 2) == 1,
          Command = $"!command_{i}",
          Sources = new List<CommandSources>
                {
                    GetRandomSource(random),
                    GetRandomSource(random)
                },
          PermittedUsers = GenerateRandomUsers(random),
          PermittedGroups = GenerateRandomGroups(random),
          Include = random.Next(0, 2) == 1,
          Mode = (uint)random.Next(1, 5),
          RegexExplicitCapture = random.Next(0, 2) == 1,
          Location = (uint)random.Next(1, 100),
          IgnoreBotAccount = random.Next(0, 2) == 1,
          IgnoreInternal = random.Next(0, 2) == 1,
          PersistCounter = random.Next(0, 2) == 1,
          PersistUserCounter = random.Next(0, 2) == 1,
          CaseSensitive = random.Next(0, 2) == 1,
          GlobalCooldown = (uint)random.Next(10, 600),
          UserCooldown = (uint)random.Next(10, 600),
          Group = $"Group_{i}",
          GrantType = (uint)random.Next(1, 3)
        });
      }

      return commands;
    }

    private static CommandSources GetRandomSource(Random random)
    {
      var values = Enum.GetValues(typeof(CommandSources));
      return (CommandSources)(values.GetValue(random.Next(values.Length)) ?? 0);
    }

    private static List<string> GenerateRandomUsers(Random random)
    {
      var users = new List<string>();
      int count = random.Next(1, 5);
      for (int i = 0; i < count; i++)
      {
        users.Add($"User_{random.Next(1000, 9999)}");
      }
      return users;
    }

    private static List<string> GenerateRandomGroups(Random random)
    {
      var groups = new List<string>();
      int count = random.Next(1, 3);
      for (int i = 0; i < count; i++)
      {
        groups.Add($"Group_{random.Next(100, 999)}");
      }
      return groups;
    }
  }
}
