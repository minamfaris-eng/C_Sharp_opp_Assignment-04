//Q1: What is the difference between static binding and dynamic binding? When does each one happen?
//Static Binding (Early Binding):
//Occurs at compile time
//The compiler determines which method to call based on the reference type
//Used for: non -virtual methods, static methods, overloaded methods
//Faster execution since resolution happens before runtime
//Dynamic Binding (Late Binding):
//Occurs at runtime
//The CLR determines which method to call based on the actual object type
//Used for: virtual methods, overridden methods
//Enables polymorphism - allows derived class methods to be called through base class references



//Q2: What is the difference between method overloading and method overriding?
//Method Overloading:
//Same method name, different parameters (signature)
//Occurs within the same class or across inheritance
//Resolved at compile time (static binding)
//Different return types alone don't constitute overloading
//Method Overriding:
//Same method name and same signature
//Occurs between base and derived classes
//Requires virtual/abstract method in base class
//Resolved at runtime(dynamic binding)
//Enables polymorphic behavior



//Q3: What keywords are used for Method Overriding? What does each one mean ?
//virtual: Marks a method in the base class that can be overridden by derived classes
//override: Used in derived class to provide new implementation of a virtual/abstract method
//abstract: Declares a method with no implementation in base class; derived classes must override it
//sealed: Prevents further overriding when used with override (e.g., sealed override)
//new: Hides the base class method(not true overriding); creates a separate method
//Example: 
//class Base
//{
//    public virtual void Display() { }      // Can be overridden
//    public abstract void Calculate();       // Must be overridden
//}

//class Derived : Base
//{
//    public override void Display() { }      // Overrides virtual method
//    public override void Calculate() { }    // Implements abstract method
//}