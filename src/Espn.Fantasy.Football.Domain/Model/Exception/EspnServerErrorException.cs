using System.Collections.Generic;

namespace Espn.Fantasy.Football.Domain.Model.Exception
{
    public class EspnServerErrorException : System.Exception
    {
        public IList<EspnServerErrorMessage> EspnServerErrorMessage { get; set; }
    }
}