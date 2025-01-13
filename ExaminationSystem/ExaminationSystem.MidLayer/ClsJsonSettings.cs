using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    internal static class ClsJsonSettings
    {
        static public JsonSerializerSettings Settings { get; } = new()
        {
            TypeNameHandling = TypeNameHandling.Objects,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
        };
    }
}
