using System.Collections.Generic;
using System.Threading.Tasks;
using Espn.Fantasy.Football.Domain.Provider;

namespace Espn.Fantasy.Football.Domain.Service
{
    public class NflPlayerService : INflPlayerService
    {
        private const string XPATH_FOR_PLAYER_NAME = "//div/h1";
        private readonly Dictionary<int, string> _cache;
        private readonly IHtmlParserProvider _htmlParserProvider;
        private readonly IUrlConfigurationProvider _urlConfigurationProvider;

        public NflPlayerService(IHtmlParserProvider htmlParserProvider, IUrlConfigurationProvider urlConfigurationProvider)
        {
            _cache = new Dictionary<int, string>();
            _htmlParserProvider = htmlParserProvider;
            _urlConfigurationProvider = urlConfigurationProvider;
        }
        
        public async Task<string> GetPlayerNameForId(int playerId)
        {
            if (_cache.ContainsKey(playerId))
            {
                return _cache[playerId];
            }
            string url = _urlConfigurationProvider.GetNflPlayerEndpoint(playerId);
            string playerName = await _htmlParserProvider.getInnerTextForFirstXPathMatch(url, XPATH_FOR_PLAYER_NAME);
            _cache[playerId] = playerName;
            return playerName;
        }
    }
}