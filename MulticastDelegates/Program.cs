namespace MulticastDelegates
{
    internal class Program
    {
        public delegate void Notify(string message);

        public static void SendEmail(string message)
        {
            Console.WriteLine("Sent to Email: " + message);
        }
        public static void SendSMS(string message)
        {
            Console.WriteLine("Sent to SMS: " + message);
        }

        public static void SendWhatsApp(string message)
        {
            Console.WriteLine("Sent to WhatsApp: " + message);
        }
        static void Main(string[] args)
        {
            Notify notify = null;

            notify += SendEmail;
            notify += SendSMS;
            notify += SendWhatsApp;
            notify("Server is down!");

            notify -= SendSMS;
            notify("Server is up.");
        }
    }
}
