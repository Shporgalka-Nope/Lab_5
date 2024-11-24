using System.Net.Sockets;

namespace lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CList<string> strList = new CList<string>(3);
            strList.Push("Atmos");
            strList.Push("Bell");
            strList.Push("Cypher");
            
            foreach(Node<string> node in strList)
            {
                Console.WriteLine(node.data);
            }
        }
    }
}
