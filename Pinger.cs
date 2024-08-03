
using System.Net.NetworkInformation;
using System.Text;

namespace ping{
    public class Pinger
    {
        public Ping pingSender {get; set;}
        public PingOptions pingOptions {get; set;}
        public string data {get; set;}
        public byte[] buffer {get; set;}
        public int timeout {get; set;}
        public string address {get; set;}

        // Constructor
        public Pinger()
        {
            pingSender = new Ping();
            pingOptions = new PingOptions{
                DontFragment = true
            };

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
