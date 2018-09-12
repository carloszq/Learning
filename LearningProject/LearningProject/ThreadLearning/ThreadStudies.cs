using System;
using System.Threading;

namespace LearningProject.ThreadLearning
{
    /// <summary>
    /// Excercises for learning more about Threads in C#.
    /// </summary>
    public class ThreadStudies
    {
        /// <summary>
        /// Displays in console basic information for the given thread.
        /// </summary>
        public static void PrintThreadInfo(Thread th)
        {
            Console.WriteLine($"Thread Name: {th.Name}. ID: {th.ManagedThreadId}. State: {th.ThreadState}");
        }

        /// <summary>
        /// Displays in console a text informing a thread is starting.
        /// </summary>
        public static void CallToChildThread()
        {
            Console.WriteLine("Child Thread Starts");
        }
    }
}
