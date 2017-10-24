using System;

namespace IPCS_27_V2
{
    class HtmlSubscriber : WebSubcriber
    {
        public string Show()
        {
            string script = "<div id='user'>Welcome user USER</div>";
            return script.Replace("USER", userName);
        }
    }
}
