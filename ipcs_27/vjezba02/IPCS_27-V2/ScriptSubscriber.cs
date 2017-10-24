using System;

namespace IPCS_27_V2
{
    class ScriptSubscriber : WebSubcriber
    {
        public string Show()
        {
            string script = "<script>alert('Welcome user: USER')</script>";
            return script.Replace("USER", userName);
        }
    }
}
