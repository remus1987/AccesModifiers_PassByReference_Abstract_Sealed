using System;

namespace AdditionalCSharpConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParentClass pc = new ParentClass(); This is an error because parent class is marked as
            //Abstract
            //pc.AnAbstractMethod();
            //pc.AnAbstractMethod2();
            ChildClass copc = new ChildClass();
            copc.AnAbstractMethod();
            copc.AnAbstractMethod2();
            //Testing access specifiers
            AccessModifiers acm = new AccessModifiers();
            acm.choice = "WHAT";//Internal
            //acm.nickName = "it is public we know";
            acm.Movie = "protected internal";
            PassReference pss = new PassReference();
            pss.PrintScore();
            //Partial1 p1 = new Partial1();
        }
    }

    #region Abstract_class_and_methods
    public abstract class ParentClass
    {
        public abstract void AnAbstractMethod();
        public virtual void AnAbstractMethod1()
        {
            Console.WriteLine("Hi");
        }
        public virtual void AnAbstractMethod2()
        {
            Console.WriteLine("Hi");
        }
    }
    #endregion

    #region Sealed_class
    public sealed class ChildClass : ParentClass

    {
        public override void AnAbstractMethod()
        {

        }
        public override void AnAbstractMethod1()
        {
            Console.WriteLine("Bye");
        }
        public override void AnAbstractMethod2()
        {
            Console.WriteLine("GoodBye");
        }
    }
    //ChildOfParent is sealed
    #endregion

    #region Access_Modifiers
    public class AccessModifiers
    {
        // private only accessible with the scope{}
        public string name = "Remus";
        // public accessible only from namespace
        private string nickName = "HaHa";
        //protected for child classes only
        protected int age = 5;
        //internal for namespace member
        internal string choice = "Blue";
        //protected internal for namespace members and also non space members who are child class
        protected internal string Movie = "Minions";

        public class ChildOfAccessModifiers : AccessModifiers
        {
            public void Method1()
            {
                Console.WriteLine("Access mofifiers");
            }
        }
    }
    #endregion

    #region Pass_by_Reference
    //Reference and Value types
    //primitives int bool float double passed by value
    //References are objects and changes are made permanent
    public class PassReference
    {
        int[] scoreBeforeModification = { 5, 8, 9, 10, 24, 19 };
        public void MethodToShowPassByReference(int[] score)
        {

            score[4] = 29; //To do: Pass by reference
            Console.WriteLine(score[4]);
        }
        public void PrintScore()
        {
            MethodToShowPassByReference(scoreBeforeModification);
            Console.WriteLine(scoreBeforeModification);
        }
        //using the partial keyword
        public partial class Partial1
        {
            public void Method1()
            {

            }
            public void Method2()
            {

            }
        }
        public partial class Partial1
        {
            public void Method()
            {

            }
            public void Method3()
            {

            }
        }
    }
        #endregion
}
