// REF: https://www.youtube.com/watch?v=8o0O-vBS8W0
using System;
using System.Threading;

namespace LeetCode.EventDelegate
{
    
    public class VideoEncoder
    {
        // Step 1/3 - Define a delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // Step 2/3 - Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded; 

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded == null)
                return;

            VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
