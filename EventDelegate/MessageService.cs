// REF: https://www.youtube.com/watch?v=8o0O-vBS8W0
using System;
namespace LeetCode.EventDelegate
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message Service: Sending an sms " + e.Video.Title);
        }
    }
}
