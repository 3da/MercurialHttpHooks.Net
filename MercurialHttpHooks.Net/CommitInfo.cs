using System;
using System.Collections.Generic;

namespace MercurialHttpHooks.Net
{
    public class CommitInfo
    {
        public string Message { get; set; }
        public int Rev { get; set; }
        public IList<string> Tags { get; set; }
        public string Hex { get; set; }
        public string User { get; set; }
        public double[] MercurialDate { get; set; }
        public string Branch { get; set; }

        public IList<CommitInfo> Parents { get; set; }

        public IList<string> Files { get; set; }

        public DateTime? DateTimeUtc
        {
            get
            {
                if (MercurialDate == null)
                    return null;
                // Unix timestamp is seconds past epoch
                var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                return dtDateTime.AddSeconds(MercurialDate[0]);
            }
        }
    }
}
