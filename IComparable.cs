using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    interface IComparable
    {
        bool IsBigger(IComparable obj);
    }













    interface IInteraceA
    {
        void Method1();
        void Method2();
    }

    interface IInterfaceB: IInteraceA
    {
        void Method3();
    }

    interface IInterfaceC
    {
        void Method4();
    }

    class A:IInterfaceC
    {
        public void Method4()
        {
            Console.WriteLine("Method 4");
        }
    }

    class B : A, IInterfaceC, IInterfaceB
    {
        public void Method1() { }
        public void Method2() { }
        public void Method3() { }

        //Why Method4 is not here?
    }

    class Example
    {
        public void F()
        {
            IInterfaceC obj1 = new B();
            //Obj1 "see" only methods defined in IInterfaceC!
            obj1.Method4();
            B b = (B)obj1;
            //b "see" all methods defined in B
            b.Method2();
        }

        public void G()
        {
            IInterfaceC obj1 = new B();
            //Down Casting!
            IInteraceA obj2 = (IInteraceA)obj1;
            //Can be also written like this
            //Down casting to B and non formal up casting to IInterfaceA
            IInteraceA obj3 = (B)obj1;

            obj2.Method2();
            obj3.Method2();
        }
    }



}
