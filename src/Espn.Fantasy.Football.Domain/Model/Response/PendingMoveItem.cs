namespace Espn.Fantasy.Football.Domain.Model.Response
{
    public class PendingMoveItem
    {
        public int FromSlotCategoryId { get; set; }
        public int MoveTypeId { get; set; }
        public int ToTeamId { get; set; }
        public bool Keeper { get; set; }
        public int FromTeamId { get; set; }
        public int Rating { get; set; }
        public int ToSlotCategoryId { get; set; }
        public int DraftOverallSelection { get; set; }
        public int PlayerId { get; set; }
    }
}