using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamerBotSkin.Models
{
  public class SBActionGroup
  {
    public string ID { get; set; }
    public float Weight { get; set; }
    public string Name { get; set; }
    public bool Random { get; set; }
    public int Index { get; set; }
  }
}
