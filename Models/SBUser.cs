using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public class SBUser
  {
    public string? ID { get; set; }
    public Platform? Type { get; set; }
    public string? Username { get; set; }
    public string? Display { get; set; }
    public RoleType? Role { get; set; }
    public DateTime? LastActive { get; set; }
    public bool? TimeoutExempt { get; set; }
    public string? Subscribed { get; set; }
    public int? BitsDonated { get; set; }
    public int? ChannelPointsSpent { get; set; }
    public int? PyramidsMade { get; set; }
    public List<string>? Groups { get; set; }
    public bool? IsPresent { get; set; }

    public static List<SBUser> GetAll()
    {
      List<SBUser> users = new List<SBUser>();
      Random random = new Random();

      for (int i = 1; i <= 10; i++)
      {
        var groups = new List<string> { "GroupA", "GroupB", "GroupC", "GroupD", "GroupE" }; // Sample groups

        SBUser user = new SBUser
        {
          ID = Guid.NewGuid().ToString(),
          Type = (Platform)random.Next(0, 3),
          Username = $"User{i}",
          Display = $"DisplayName{i}",
          Role = (RoleType)random.Next(0, 5),
          LastActive = DateTime.Now.AddMinutes(-random.Next(1, 1000)),
          TimeoutExempt = random.Next(0, 2) == 1,
          Subscribed = random.Next(0, 2) == 1 ? "Yes" : "No",
          BitsDonated = random.Next(0, 5000),
          ChannelPointsSpent = random.Next(0, 10000),
          PyramidsMade = random.Next(0, 10),
          Groups = groups.Take(random.Next(1, groups.Count)).ToList<string>(),
          IsPresent = random.Next(0, 5) == 0
        };

        users.Add(user);
      }

      return users;
    }
  }
}
