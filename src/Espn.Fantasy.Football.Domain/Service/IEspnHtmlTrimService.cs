using System;

namespace Espn.Fantasy.Football.Domain.Service
{
    /// <summary>
    /// Service for pulling data from ESPN site HTML
    /// </summary>
    public interface IEspnHtmlTrimService
    {
        /// <summary>
        /// Extracts an NFL player's name from their corresponding HTML page's title tag
        /// </summary>
        /// <param name="titleTag">HTML title tag</param>
        /// <returns>NFL player name</returns>
        string TrimNameFromTitleTag(string titleTag);
    }
}