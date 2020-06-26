using System;
using System.Collections.Generic;
using LeetCode.Models;
using System.Collections.Specialized;
using LeetCode.OOP;
using LeetCode.EventDelegate;

namespace LeetCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };

            // publisher
            var videoEncoder = new VideoEncoder();

            // subcribers
            var mailService = new MailService();
            var messageService = new MessageService();

            // Subcribe the event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded; 


            videoEncoder.Encode(video);

            Console.ReadLine();
        }

    }

}

