using System;
using System.Threading;
using LearningProject.ThreadLearning;

namespace LearningProject
{
    /// <summary>
    /// Main entry point for this learning and testing program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Test your code here.
            ThreadStudies.PrintThreadInfo(Thread.CurrentThread);
            ThreadStart childRef = new ThreadStart(ThreadStudies.CallToChildThread);
            Console.WriteLine("In Main: Creating Child thread");

            Thread childThread = new Thread(childRef);
            ThreadStudies.PrintThreadInfo(childThread);
            childThread.Start();
            ThreadStudies.PrintThreadInfo(childThread);
        }
    }
}
