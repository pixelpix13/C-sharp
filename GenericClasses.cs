namespace GenericClasses{
    // Define a generic class with a type parameter T
    public class Box<T>
    {
        // Public field (not recommended)
        public T Value;
        
        // Constructor
        public Box(T value)
        {
            Value = value;
        }
        
        // Method to display the type and value
        public void DisplayInfo()
        {
            Console.WriteLine($"Type: {typeof(T)}, Value: {Value}");
        }
    }

}