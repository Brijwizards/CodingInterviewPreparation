using System;

namespace OOPSConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        #region OOPSConcept

        public class A
        {
            public virtual void Method1()
            {
                //
            }

            public virtual void TestInheritance() { }

        }

        public abstract class TestAb
        {
            public virtual void Method1()
            {
                //
            }

            public abstract void TestInheritance();
        }

        public interface Test
        {
            void TestInterface();
        }

        public interface Test2
        {
            void TestInterface2();
        }

        /// <summary>
        /// Inheritance
        /// </summary>
        public class B : A, Test, Test2
        {
            public override void Method1() // Generates CS0506.
            {
                // Do something else.
            }

            public void TestInterface()
            {
                throw new NotImplementedException();
            }

            public void TestInterface2()
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Singleton

        public sealed class Singleton
        {
            private static readonly Singleton singletonObject = new Singleton();
            //private static readonly object padlock = new object();
            private Singleton()
            {

            }
            static Singleton()
            {

            }

            public static Singleton GetInstance()
            {
                return singletonObject;
            }
        }
        #endregion
    }
}
