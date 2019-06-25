namespace Espn.Fantasy.Football.Domain.Model.Response
{
	public class Settings
	{
		public AcquisitionSettings AcquisitionSettings { get; set; }
		public DraftSettings DraftSettings { get; set; }
		public FinanceSettings FinanceSettings { get; set; }
		public bool IsCustomizable { get; set; }
		public bool IsPublic { get; set; }
		public string Name { get; set; }
		public string RestrictionType { get; set; }
		public RosterSettings RosterSettings { get; set; }
		public ScheduleSettings ScheduleSettings { get; set; }
		public Status Status { get; set; }
	}
}