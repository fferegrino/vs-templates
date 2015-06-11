using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $rootnamespace$
{
    public interface I$itemname$
    {

    }

    public class $itemname$ : I$itemname$
    {
        private readonly ISession _session; 
        private readonly IDateTime _dateTime;
        private readonly IWebUserSession _userSession;

        public $itemname$(ISession session, IDateTime dateTime, IWebUserSession userSession)
        {
            _session = session;
            _userSession = userSession;
            _dateTime = dateTime;
        }

    }
}
