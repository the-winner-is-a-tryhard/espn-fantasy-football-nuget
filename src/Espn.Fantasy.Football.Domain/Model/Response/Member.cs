using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Member
	{
		public string DisplayName { get; set; }
		public string FirstName { get; set; }
		public string Id { get; set; }
		public bool IsLeagueCreator { get; set; }
		public bool IsLeagueManager { get; set; }
		public string LastName { get; set; }
		public IList<object> NotificationSettings { get; set; }
	}
}
