namespace StreamerBotSkin.Models
{
    public class SBOBSConnection
    {
        public uint ID {get; set; }
        public string Name {get; set; }
        public string Host {get; set; }
        public uint Port {get; set; }
        public string? Password {get; set; }
        public string Version {get; set; }
        public bool AutoConnect {get; set; }    
        public bool Reconnect {get; set; }
        public uint Retry {get; set; }
        public string Status {get; set; }
    }
}