// RRC Game Development - Programming
// Game Studio 1 - Demo 1

// These using commands are importing namespaces, which are collections of classes. 
// UnityEngine for example is all the classes related to Unity
using UnityEngine;

// This is a comment block
/*
 *  You can also use this for a larger comment. The slash-star opens the comment
 *  and the star-slash closes it. Everything in between is ignored by the compiler 
 *  and it meant for the programmers working on the file to read. Put useful messages
 *  in comments to help make your code more readable and understandable. 
 */

/*
 * The class keyword means we are defining a new Class type. 
 * The open curly brace { and closing curly brace } define the scope of the object
 * These MUST match up properly or the compiler will complain about it. 
 * 
 * Don't worry about Public and MonoBehaviour for now, but if you really need to know.. 
 * Public - class is accessible by other classes
 * : MonoBehaviour - This Class will extend the class MonoBehaviour, think of it
 * like the basic functionality of the object, and we will add more onto it with our code. 
 */
public class MyFirstScript : MonoBehaviour
{
    // Variables: 
    // Define your Class variables at the top of your class. 
    // primative variables include int, float, bool and string
    // public will make them accessible to other scripts. Usually we will want to 
    // change this to private later to keep other Classes from messing with our variables
    // directly, but for now, just make them public, which will make them accessible 
    // in the inspector.
    
    // an int is an integer number, or number with no decimal places. 
    // the int is the type, and is a keyword
    // the intVar is the name, and could be anything. It should start with a lowercase letter, 
    // and follow camelcase conventions: camelCaseMeansEachNewWordHasACapitolLetter
    // The = 5 means 5 is being assigned to the variable (as a default value in this case)
    // Don't forget the semicolon ";", it ends the line. The compiler will get confused if you miss this. 
    public int intVar = 5;
    // float is for floating point numbers, or numbers with decimals.
    // Make sure you include the f at the end of the value. 
    public float floatingPointVar = 1.234f; 
    // bool values are either true or false. 
    public bool iAmBool = false;
    // Strings are sequences of characters and use "" to delineate whats in them. 
    // They can include sentences, numbers and certain special characters
    public string myName = "Dylan";
    public string anotherString = "This is a longer string that includes a whole sentence.";

    // This is a Method, also sometimes called a function in Unity. 
    // In the context of Unity, all functions are also methods, so it gets used interchangably.
    // Again, public means it is accessible outside of this class. 
    // void is a keyword that means the Method doesn't return any value, it just runs then ends. 
    // MyMethod is the method name, and is defined by you the programmer. 
    // () defines the parameters the function has. This defines the type of data that can be passed
    // into the method, however in this case, the MyMethod accepts no parameters since () contains no definitions
    public void MyMethod() 
    {  // Once again, { opens the Method body, while } closes it. 
        // Idealogical wars rage about whether the opening { should be at the end of the method definition line, 
        // on on a new line below as seen here. Both are *fine* as long as you are consistent. 
        // This simple debug command is a Method that MyMethod will call. 
        // In this case, we are passing it a String "Hello World", which will be printed to the Console in Unity. 
        // Debug messages are useful for feedback and troubleshooting. 
        Debug.Log("Hello World");
    }

    // Here is a slightly more complex method that includes two int type parameters, and a return type. 
    // The parameter names identify the values (but only within the Method). 
    // The int type keyword between the public and Method name defines the return type as an int
    // Each method can only return one piece of data, although there are ways around this later. 
    // Basically, when this method is called, it is expecting two integer values. 
    // It will then add them up (a + b) before returning the sum back to whatever called the method. 
    public int AddTwoNumbers(int a, int b) {
        return a + b;
    }


    // Start is a special method that is pre-defined in Unity and will be called for you, 
    // by the engine, before the first frame renders (before Update runs basically)
    void Start() {
    
        // Inside the Start method, we are calling our custom method MyMethod()
        // Note we don't need the return type, but do need the () and ;
        MyMethod(); // call void function, runs but returns nothing. 

        // Calling Add Two Numbers. Note the int values passed in (2 and 3) and it returns a value 
        // which is stored in a new local variable of type int called answer. 
        // Local variables are variables which are defined within a method body, and they are 
        // discarded at the end of the method running. 
        int answer = AddTwoNumbers(2, 3);
        // Print out the answer returned from Add Two numbers
        // In this context, since we have a string with "Answer:" the + means "concatinate these strings together"
        // basically, the answer int variable will get converted to a string, then the two strings will 
        // be combined into a new string. This should print "Answer: 5" to the console. 
        Debug.Log("Answer:" + answer);

    }

    // Update is called once per frame by the engine and is a built in method similar to Start
    // This will be your main frame loop and each time Update is called, Unity will render one frame of graphics. 
    void Update()
    {
        // One thing to note is that the method calls are read right to left, so in this case, even though
        // intVar is used as both a parameter, and to store the return value, the parameter is read in first, 
        // then its value is updated after them method has completed. 
        // Also worth noting, when passing primative values (such as int, float, bool, string) into a method, 
        // they are passed by value, meaning the value is copied but the source variable value will not be changed
        // within the method. There are exceptions to this later on.
        // In this case, this line of code will be run once each frame (Update) and will add 1 to the
        // current value of intVar each time it is run. 
        intVar = AddTwoNumbers(intVar, 1);
        Debug.Log("Update Loop Demo Counter: " + intVar);
    } // Closing Brace for the Class MyFirstScript
}
