using Parts;

namespace Lists
{
    public class Listss
    {
        public List<CarParts> lst = new List<CarParts>();

        // Method to add a new part to the list
        public void AddPart(string partName, int partId)
        {
            CarParts newPart = new CarParts { Partname = partName, PartId = partId };
            lst.Add(newPart);
        }

        // Method to display all parts
        public void DisplayParts()
        {
            foreach (var part in lst)
            {
                Console.WriteLine($"Part ID: {part.PartId}, Part Name: {part.Partname}");
            }
        }
    }
}