using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadekoBot.Modules.Searches.Commands.Models
{
    public class ASXData
    {
        public string code { get; set; }
        public string last_price { get; set; }
        public string open_price { get; set; }
        public string day_high_price { get; set; }
        public string day_low_price { get; set; }
        public string change_price { get; set; }
        public string change_in_percent { get; set; }
        public string previous_close_price { get; set; }
        public string previous_day_percentage_change { get; set; }
        public string year_high_price { get; set; }
        public string year_low_price { get; set; }
        public string volume { get; set; }
        public string average_daily_volume { get; set; }
        public string number_of_shares { get; set; }
        public string year_change_in_percentage { get; set; }
    }
}