using YKI.Service.Logging;
using YKI.ROS.Interfaces.ROS;
using Rcl;

namespace YKI.Service.ROS
{
    public class RosNodeService : IRosNodeService
    {
        public RclContext RclContext { get; set; }
        public IRclNode RclNode { get; set; }


        #region Publishers
        public IRclPublisher<Node.Std.String> DenemePublisher { get; set; }
        #endregion


        #region Subscribers
        public IRclSubscription<Node.Std.String> DenemeSubscription { get; set; }

        public IRclSubscription<Node.Std.UInt32> OtherUAVLocation_Sub { get; set; }

        #endregion

        public RclContext CreateContext()
        {
            RclContext context = new RclContext();
            RclContext = context;
            return context;
        }

        public IRclNode CreateNode(string nodeName)
        {
            IRclNode node = RclContext.CreateNode(nodeName);
            RclNode = node;
            return node;
        }

        public void Init()
        {

            CreateContext();
            CreateNode("GCS");

            #region Create Publishers
            DenemePublisher = RclNode.CreatePublisher<Node.Std.String>("gcs/deneme");
            #endregion


            #region Create Subscribers
            DenemeSubscription = RclNode.CreateSubscription<Node.Std.String>("gcs/deneme");

            #endregion


            #region Hook Subscribers
            HookDenemeSubscription();
            #endregion


            // DEBUG

            // PublishDeneme();

            /*
             * 
             * Subscription Thread
             * 
             */





            //string yerine std gelmeli
            // TODO CreatePublisher<string>("/gcs/deneme");


            /*
             * Context yarat
             * Node yarat
             * Publisher / Subscriberlarını yarat
             * Service Server ve clientlarını yarat
             */
        }

        private void HookDenemeSubscription()
        {

            Thread denemeSubscriptionHook = new Thread(async () =>
            {

                await foreach (var message in DenemeSubscription.ReadAllAsync())
                {
                    LoggingService.Info($"Received message: {message.Data}");
                }

            });

            denemeSubscriptionHook.Start();

        }

        public void PublishDeneme()
        {
            Node.Std.String denemeMessage = new Node.Std.String();

            int i = 0;

            while (i < 100)
            {
                denemeMessage.Data = i.ToString();
                DenemePublisher.Publish(denemeMessage);
                Thread.Sleep(500);
                i++;
            }


        }

        //public String Subscribe_OtherUAVLocation()
        //{
        //    Node.Std.String OtherUAVLocation = new Node.Std.String();

        //    return OtherUAVLocation.Data;

        //}


        //EXAMPLE FOR ANALYSIS

        //public async Task StartPublishing(CancellationToken cancellationToken)
        //{
        //    await using var ctx = RclContext;
        //    using var node = ctx.CreateNode("hello_publisher");
        //    using var publisher = node.CreatePublisher<String>(_topicName);

        //    node.Logger.LogInformation("Publisher is running. Press ENTER to stop publishing.");

        //    var message = new String { Data = "hello" };

        //    while (!cancellationToken.IsCancellationRequested)
        //    {
        //        publisher.Publish(message);
        //        node.Logger.LogInformation($"Published: {message.Data}");
        //        await Task.Delay(1000, cancellationToken); // Publish every second
        //    }
        //}
    }
}
