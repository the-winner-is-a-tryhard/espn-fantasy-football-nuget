namespace Espn.Fantasy.Football.Domain.Service
{
    public class EspnHtmlTrimService : IEspnHtmlTrimService
    {
        private const string TITLE_TAG_TRAILING_TEXT = " Stats, News, Bio | ESPN";
        
        public string TrimNameFromTitleTag(string titleTag)
        {
            return titleTag.Replace(TITLE_TAG_TRAILING_TEXT, "");
        }
    }
}