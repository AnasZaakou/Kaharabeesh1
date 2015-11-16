using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaharabeesh
{
     abstract class OOP
    {
        enum MyEnum{Sat, Sun, Mon}
        struct MyStruct
        {
            enum MyStructEnum{Tue, Wed, Thu}
        }
        interface MyInterface 
        {
            int MyInterfaceProp { get; set; }
            void MyInterfaceMethod1();
        }
        int MyProp { get; set; }
        public virtual void Method1() { }
        void Method2() { }
        public abstract void Method3();
        public class SubClass
        {
            //OOP oopp;
            //int x;
            //SubClass()
            //{
            //    oopp = new OOP();
            //    x = (int)OOP.MyEnum.Mon;
            //}
        }
    }
     class OOP2
     {
         const int contNum = 10;
         int number;
         enum MyEnum { Sat, Sun, Mon }
         struct MyStruct
         {
             enum MyStructEnum { Tue, Wed, Thu }
         }
         interface MyInterface
         {
             int MyInterfaceProp { get; set; }
             void MyInterfaceMethod1();
         }
         int MyProp { get; set; }
         void Method1() { }
         void Method2() { }
     }
     static class OOP3
     {
         enum MyEnum { Sat, Sun, Mon }
         struct MyStruct
         {
             enum MyStructEnum { Tue, Wed, Thu }
         }
         interface MyInterface
         {
             int MyInterfaceProp { get; set; }
             void MyInterfaceMethod1();
         }
         static int x;
         static int prop { get; set; }
         static void Method1(){ }
     }
     sealed class Sealed:OOP
     {
         public override sealed void Method1() { }
         public override sealed void Method3() { }
     }
}
