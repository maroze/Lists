using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lists
{
    public class MyList<UserType>
    {
        public class Item
        {
            public UserType Value;
            public Item Next;
        }
        Item head;

        public void Add(UserType value)
        {
            Item newItem = new Item() { Value = value };
            if (head == null)
            {
                head = newItem;
                return;
            }
            Item currentItem = head;
            while (currentItem.Next != null)
                currentItem = currentItem.Next;
            currentItem.Next = newItem;
        }

        public UserType RemoveAt(int index)
        {
            Item currentItem = head;
            for (int i = 0; i < index; i++)
                currentItem = currentItem.Next;
            return currentItem.Value;
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int[] m = new int[] { x, y };
            //Console.WriteLine(x);
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(x);

            MyList<string> str = new MyList<string>();
            str.Add("Казнить");
            str.Add(",");
            str.Add("нельзя");
            str.Add(",");
            str.Add("помиловать");
            Console.WriteLine(str.RemoveAt(1));
            MyList<int> num = new MyList<int>();
            num.Add(1);
            num.Add(2);
            num.Add(4);
            num.Add(3);
            Console.ReadKey();
        }
    }
}

    

