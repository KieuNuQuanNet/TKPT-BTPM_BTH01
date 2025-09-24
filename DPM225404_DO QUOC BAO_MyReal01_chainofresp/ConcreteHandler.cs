using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225404_DO_QUOC_BAO_MyReal01_chainofresp
{
    public class Level1Support : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.Level == 1)
            {
                Console.WriteLine("Level1Support handled request #{0}: {1}",
                    request.Id, request.Description);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
    public class Level2Support : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.Level == 2)
            {
                Console.WriteLine("Level2Support handled request #{0}: {1}",
                    request.Id, request.Description);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
    public class ManagerSupport : SupportHandler
    {
        public override void HandleRequest(SupportRequest request)
        {
            if (request.Level == 3)
            {
                Console.WriteLine("ManagerSupport handled request #{0}: {1}",
                    request.Id, request.Description);
            }
            else
            {
                Console.WriteLine("Request #{0} requires a special task force! Description: {1}",
                    request.Id, request.Description);
            }
        }
    }
}
