using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YKI.Service.Communication
{
    internal class CommunicationService
    {
        public void Init()
        {



            throw new NotImplementedException();
        }

        public async Task RclInit()
        {

            /*await using var context = new RclContext(args);
            using var node = context.CreateNode("gcs_node");
            using var pub = node.CreatePublisher<Std.String>("/chatter");*/

            throw new NotImplementedException();

        }


        public void SendToService<T>(string topicName, T content)
        {
            throw new NotImplementedException();
        }

        public void SendToTopic<T>(string topicName, T content)
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
