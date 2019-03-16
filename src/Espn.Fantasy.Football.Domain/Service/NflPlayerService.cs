using System.Collections.Generic;
using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Provider;

namespace Espn.Fantasy.Football.Domain.Service
{
    public class NflPlayerService : INflPlayerService
    {
        private const string XPATH_FOR_PLAYER_NAME = "//head/title";
        private readonly Dictionary<int, string> _cache;
        private readonly IHtmlParserProvider _htmlParserProvider;
        private readonly IEspnHtmlTrimService _espnHtmlTrimService;
        private readonly IUrlConfigurationProvider _urlConfigurationProvider;

        public NflPlayerService(IHtmlParserProvider htmlParserProvider, IEspnHtmlTrimService espnHtmlTrimService, IUrlConfigurationProvider urlConfigurationProvider)
        {
            _cache = new Dictionary<int, string>();
            _htmlParserProvider = htmlParserProvider;
            _espnHtmlTrimService = espnHtmlTrimService;
            _urlConfigurationProvider = urlConfigurationProvider;
        }
        
        public async Task<string> GetPlayerNameForId(int playerId)
        {
            if (_cache.ContainsKey(playerId))
            {
                return _cache[playerId];
            }
            string url = _urlConfigurationProvider.GetNflPlayerEndpoint(playerId);
            string titleTag = await _htmlParserProvider.getInnerTextForFirstXPathMatch(url, XPATH_FOR_PLAYER_NAME);
            string playerName = _espnHtmlTrimService.TrimNameFromTitleTag(titleTag);
            _cache[playerId] = playerName;
            return playerName;
        }
    }
}