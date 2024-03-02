using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OF_DL.Entities.Highlights;

namespace OF_DL.Entities
{
    public class HighLightsStoriesPosts
    {
        public string Url { get; set; }
        public Stories.Stories.Medium? StoryMedium { get; set; }
        public HighlightMedia.Medium? HighlightMedium { get; set; }
    }
}
