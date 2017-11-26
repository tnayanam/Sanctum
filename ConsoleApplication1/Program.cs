﻿/*
 * Inehritance is "Is Relationship"
 * Composition is a "Has a Relationship"
 * 
 */
/*
 * Upcasting: Casting a derived class to base class
 * DownCasting: Casting a SUper class to the derovedf class


 */

using System;
using System.Collections.Generic;

public class SuperClass
{
    public int Height { get; set; }
    public void Draw()
    {

    }
}

public class DerivedClass : SuperClass
{
    public int Width { get; set; }
    public void Do() { }
}


public class PublicTest
{
    public int Id { get; set; }
    private int age { get; set; }
    protected int birthDate { get; set; }

    protected int GetbirthDate() { return 4; }

    public int GetAge()
    {
        this.age = 2; // accessing private memebr;
        return 5;
    }
}

public class protectTest : PublicTest
{
    public void Name()
    {
        this.birthDate = 4;
        this.GetbirthDate(); // protected accessible;
    }
}



public class Animal
{
    public string Name { get; set; }
    public void NumberOfLegs()
    {
        System.Console.WriteLine("It has these many number of legs.");
    }
}
/*
 * Composition is a Has a Relationship.
 */
public class Man
{
    private Animal _animal;

    public Man(Animal animal)
    {
        _animal = animal;
    }

    public void wife()
    {
        _animal.Name = "asds";
        System.Console.WriteLine("My wife");
    }
}

public class Fish
{
    private Animal _animal;

    public Fish(Animal animal)
    {
        _animal = animal;
    }

    public void NoOfFins()
    {
        _animal.NumberOfLegs();
        System.Console.WriteLine("Number of fins");
    }
}

/*
 * Always Base class constructor is called first.  
*/

public class Vehicle
{
    //public Vehicle()
    //{
    //    System.Console.WriteLine("This is base class constructor");
    //}

    private readonly string _registration;

    public Vehicle(string registration)
    {
        _registration = registration;
    }
}

public class Car : Vehicle
{
    public Car(string registrationNumber) : base(registrationNumber) // initialized the base class constructor
    {
        System.Console.WriteLine("This is child class constructor");
    }
}

// Man Has a Animal // Man is composed of animal
// Fish Has a  animal


public class Stack
{
    private readonly List<object> _obj;  // OBJECT IS THE PARENT OF ALL CLASSES IN DOT NET. SO this means it is a super class
                                         //. which means Upcastingf so it can store anything and everything.
                                         // readonlyt means it can opnl;y be initlized inconstriuctor or directly but not anywhere else.

    public Stack()
    {
        _obj = new List<object>();
    }

    public void Push(object input)
    {
        if (input == null)
            throw new Exception("Null input passed");
        _obj.Add(input);
    }

    public object Pop()
    {
        if (_obj.Count == 0)
            throw new Exception("Stack is Empty");
        var temp = _obj[_obj.Count - 1];
        _obj.RemoveAt(_obj.Count - 1);
        return temp;
    }

    public void Clear()
    {
        _obj.Clear();
    }
}

class Program
{
    static void Main(string[] args)
    {
        var s1 = new Stack();
        s1.Push(1);
        s1.Push(2);
        s1.Push(3);
        Console.WriteLine(s1.Pop());
        Console.WriteLine(s1.Pop());
        Console.WriteLine(s1.Pop());


        var car = new Car("WSD");
        var man = new Man(new Animal());

        man.wife();
        // Now in this situation if we want to add another method in animal class it will be difficult so if we want
        // to add another method such has NoOfHair, we can create another class altogether 

        //man.a

        //man.Name = "Tanuj";// inherited
        //man.wife(); // its own fucntion
        //man.NumberOfLegs();

        //var fish = new Fish();
        //fish.NoOfFins(); // its own function                                                                                                                                                                          nbm
        //fish.Name = "Tippy"; // inherited one
        // So, this is Inheritance.

        // Problem with Inheritance:
        // If we modify and add another property in Animal class lets say "Number of Hair". Now may
        //be there are 100 anials who needs this method, so we are tempted to keep it in Animal class
        // but there are many animals who dont need it, so for them its a waste to keep it in parent class which is ANimal
        // SO we end up creating another class just for 50 type pof animals whioch needs that no of hair method.
        // an now this is how inheritance iwll look like Animal=>ANimalWIthHair=> Anod now al the child classes/
        // SO we have a heirarchy now. and thats what we want to avoid
        /*
         * Different types of Access Modifier: Public, Private, Protected, Internal, Protected Internal
         
         */

        PublicTest p1 = new PublicTest();
        p1.Id = 2; // Public
                   // p1.Age = 3; // Not Accessible

        // Upcasting
        var derivedClass = new DerivedClass();
        SuperClass sp = derivedClass;
        //sp. now only super calss methods are availbale.

        // downcasting
        var superClass = new SuperClass();
        DerivedClass dc = (DerivedClass)superClass;
        // dc all the methods availbale

        // Boxing and Unboxing
        var num = 2; // this is a value type hence stored in stack
        object obj = 2; // this is a reference type so a memory is allocated for 2 and that memory reference is stored to obj
        // Unboxing
        object obwj = 4;
        int num1 = (int)obwj;





    }
}
