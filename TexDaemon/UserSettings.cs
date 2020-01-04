using System.Collections.Generic;
using Newtonsoft.Json;

namespace TexDaemon
{
    [JsonObject]
    public class UserSettings
    {
        public string FilesListRegEx { get; set; }
        public string FilesListRegExSub { get; set; }
        public bool MakeBackups { get; set; }
        public List<Processor> Processors { get; set; }
        public List<string> FilesList { get; set; }

        public class Processor
        {
            public string Condition { get; set; }
            public string RegEx { get; set; }
            public string RegExSub { get; set; }
        }
    }
}
