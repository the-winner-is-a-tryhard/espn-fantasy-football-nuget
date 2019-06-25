namespace Espn.Fantasy.Football.Domain.Service
{
    public class EspnHtmlTrimService : IEspnHtmlTrimService
    {
        private const string TitleTagTrailingText = " Stats, News, Bio | ESPN";
        
        public string TrimNameFromTitleTag(string titleTag)
        {
            return titleTag.Replace(TitleTagTrailingText, "");
        }
    }
}