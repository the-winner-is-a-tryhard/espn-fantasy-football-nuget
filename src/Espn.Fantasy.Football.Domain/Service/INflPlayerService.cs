using System.Threading.Tasks;

namespace Espn.Fantasy.Football.Domain.Service
{
    public interface INflPlayerService
    {
        Task<string> GetPlayerNameForId(int playerId);
    }
}