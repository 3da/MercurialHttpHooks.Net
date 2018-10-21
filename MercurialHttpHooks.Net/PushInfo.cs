using System.Collections.Generic;

namespace MercurialHttpHooks.Net
{
    public class PushInfo
    {
        public string UserName { get; set; }

        public IList<CommitInfo> Commits { get; set; }
    }
}
