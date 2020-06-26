// REF: https://www.youtube.com/watch?v=8o0O-vBS8W0
using System;
namespace LeetCode.EventDelegate
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailServer: Sending an email " + e.Video.Title);
        }
    }
}
