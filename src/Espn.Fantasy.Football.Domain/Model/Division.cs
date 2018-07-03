namespace Espn.Fantasy.Football.Domain.Model
{
    public class Division
    {
        public int DivisionId { get; set; }
        /// <summary>
        /// Workaround for inconsistent naming in ESPN's response object; use Division.DivisionName instead
        /// </summary>
        public string Name
        {
            set { DivisionName = value; }
        }
        public string DivisionName { get; set; }
        public int Size { get; set; }
    }
}
