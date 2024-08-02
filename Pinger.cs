
using System.Net.NetworkInformation;
using System.Text;

namespace ping{
    public class Pinger
    {
        private Ping pingSender;
        private PingOptions pingOptions;
        private string data;
        private byte[] buffer;
        private int timeout;
        private string address;

        // Constructor
        public Pinger()
        {
            pingSender = new Ping();
            pingOptions = new PingOptions();
            pingOptions.DontFragment = true;

            data = "hello world";
            buffer = Encoding.ASCII.GetBytes(data);
            timeout = 120;
            address = "4.2.2.2";
        }

        // Method to perform the ping operation
        public void PerformPing()
        {
            PingReply reply = pingSender.Send(address, timeout, buffer, pingOptions);

            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Response: {0}", reply.Status);
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Buffer Length: {0}", reply.Buffer.Length);
            }
            else
            {
                Console.WriteLine("Ping failed with status: {0}", reply.Status);
            }
        }
    }
}
