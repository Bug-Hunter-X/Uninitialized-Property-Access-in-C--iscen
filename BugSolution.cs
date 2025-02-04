public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 10; // Initialize with a default value
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now MyProperty has a defined value
    }
}