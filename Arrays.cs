using System.Text;
namespace Arraysss
{
    public class Arrayss
    {
        public void Arr(){
            int[] array = [4, 2, 1, 0];
            double v = array.Average();
            Array.Reverse(array);
            Console.WriteLine(v);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            var name = "Purav";
            var sb = new StringBuilder(name);
            var testStringBuilder = sb.Append("Patel");
            Console.WriteLine(testStringBuilder);
        }
    }
}