using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calander.Common
{
    public class WeekDays
    {
        public static Dictionary<String, String> EnglishToAmharicDayMap = new Dictionary<String, String>    {
            { "Sunday", "እሑድ" },
            { "Monday", "ሰኞ" },
            { "Tuesday", "ማክሰኞ" },
            { "Wednesday", "እሮብ" },
            { "Thursday", "ሀሙስ" },
            { "Friday", "ዐርብ" },
            { "Saturday", "ቅዳሜ" },

        };
        public static Dictionary<String, String> EnglishToAffanOromoDayMap = new Dictionary<String, String>    {
            { "Sunday", "Dilbata" },
            { "Monday", "Wixata" },
            { "Tuesday", "Kibxata" },
            { "Wednesday", "Roobii" },
            { "Thursday", "Kamisa" },
            { "Friday", "Jimaata" },
            { "Saturday", "Sanbata" },

        };
        public static Dictionary<String, String> EnglishToTigrignaDayMap = new Dictionary<String, String>    {
            { "Sunday", "ሰንበት" },
            { "Monday", "	ሶኑይ" },
            { "Tuesday", "ሶሉስ" },
            { "Wednesday", "ሮቡዕ" },
            { "Thursday", "ሓሙስ" },
            { "Friday", "ዓርቢ" },
            { "Saturday", "ቀዳም" },

        };
        public static Dictionary<String, String> EnglishToSomaleDayMap = new Dictionary<String, String>    {
            { "Sunday", "Axad" },
            { "Monday", "Isniin" },
            { "Tuesday", "Talaado" },
            { "Wednesday", "Arbaco" },
            { "Thursday", "Khamiis" },
            { "Friday", "Jimco" },
            { "Saturday", "Sabti" },

        };
        public static Dictionary<String, String> EnglishToSidamaDayMap = new Dictionary<String, String>    {
            { "Sunday", "Dikko" },
            { "Monday", "Deela" },
            { "Tuesday", "Qawaado" },
            { "Wednesday", "Qawaalanka" },
            { "Thursday", "Dikkohigo" },
            { "Friday", "Deelahigo" },
            { "Saturday", "Foolisho" },

        };
    }
}