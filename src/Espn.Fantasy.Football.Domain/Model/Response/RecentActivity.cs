using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class RecentActivity
    {
        public IList<RecentActivityItem> Items { get; set; }
    }
}