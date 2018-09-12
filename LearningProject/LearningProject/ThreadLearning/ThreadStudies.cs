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
        /// Displays in console basic information for the current thread.
        /// </summary>
        public static void PrintCurrentThreadInfo()
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine($"Thread Name: {th.Name}. ID: {th.ManagedThreadId}. State: {th.ThreadState}");
        }
    }
}
