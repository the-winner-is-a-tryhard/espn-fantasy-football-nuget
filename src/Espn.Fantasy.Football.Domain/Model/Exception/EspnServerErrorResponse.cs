using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Exception
{
    public class EspnServerErrorResponse
    {
        public IList<EspnServerErrorMessage> Error { get; set; }
    }
}