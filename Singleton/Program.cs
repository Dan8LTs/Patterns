using Singleton;

// Standard implementation with conflicting class instances.
var text1 = new FileHandler();
var text2 = new FileHandler();

text1.WriteText("Apple juice");
text2.WriteText("Mango");

text1.Save();
text2.Save();

// We can't create a new instance of singleton class.
var singleton1 = FileHandlerSingleton.Instance;
var singleton2 = FileHandlerSingleton.Instance;

singleton1.WriteText("Apple juice");
singleton2.WriteText("Mango");

singleton1.Save();
singleton2.Save();
