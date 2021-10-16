using System;
using System.Collections.Generic;
using System.Linq;

public class midterm1
{
    public static void Main()
    {
        inventory inv = new inventory();
        Console.WriteLine("Enter items in inventory: ");
        inv.create();
        List<item> tem = inv.l;
        Console.WriteLine("\n1.	Check whether an item is in the store");
        Console.WriteLine("\n2.	Sell an item");
        Console.WriteLine("\n3.	Print the report");
        int opt = Convert.ToInt32(Console.ReadLine());
        switch (opt)
        {
            case 1:
                {
                    Console.WriteLine("Enter Item ID: ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    inv.lookup(t);
                    break;
                }
            case 2:
                {
                    int g = 0;
                    double p = 0;
                    Console.WriteLine("Enter Item ID you want to buy: ");
                    int tt = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter quantity you want to buy: ");
                    int t = Convert.ToInt32(Console.ReadLine());
                    inv.updateQuantity(tt, t, g, p);
                    if (g == 0)
                    {
                        inv.total_number_of_items = inv.total_number_of_items - t;
                        inv.total_inventory = inv.total_inventory - p;
                    }

                    break;
                }
            case 3:
                {
                    inv.report();
                    break;
                }
        }


    }
}


    public class item
    {
        private int itemID;
        private string item_name;
        private int Quantity;
        private double item_price;
        private double store_price;
        public int idItem
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
            }
        }

        public string iName
        {
            get
            {
                return item_name;
            }
            set
            {
                item_name = value;
            }
        }

        public int stock
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }

        public double manuPrice
        {
            get
            {
                return item_price;
            }
            set
            {
                item_price = value;
            }
        }

        public double sellingPrice
        {
            get
            {
                return store_price;
            }
            set
            {
                store_price = value;
            }
        }

        public override string ToString()
        {
            return "\nItem ID: " + idItem + "\nItem name: " + iName + "\nQuantity: " + stock + "\nItem price: " +
                manuPrice.ToString("C") + "\nStore price: " + sellingPrice.ToString("C");
        }

        public item(int ITEMID, string nam, int quant, double iprice, double sprice)
        {
            itemID = ITEMID;
            item_name = nam;
            Quantity = quant;
            item_price = iprice;
            store_price = sprice;
        }
    }


    public class inventory
    {
        List<item> Ilist = new List<item>();
        private static int numb_of_diff_items = 0;
        private double total_inv;
        private int total_numItem;
        public void create()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("\nPlease enter item ID: ");
                int idItem = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease enter item Name: ");
                string iName = Console.ReadLine();

                Console.WriteLine("\nPlease enter how many items there are: ");
                int stock = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease enter manufacure price: ");
                double manuPrice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\nPlease enter store price: ");
                double sellingPrice = Convert.ToDouble(Console.ReadLine());

                item new_item = new item(idItem, iName, stock, manuPrice, sellingPrice);
                Ilist.Add(new_item);
                numb_of_diff_items++;
                Console.WriteLine("\n");

            }
        }

        public void lookup(int t)
        {
            int tt = 0;
            for (int i = 0; i < numb_of_diff_items; i++)
            {
                if (t == Ilist.ElementAt(i).idItem)
                {
                    tt = 1;
                }
            }
            if (tt == 1)
                Console.WriteLine("\nThis item is in store");
            else
                Console.WriteLine("\nThis item is not in store");
        }

    public void updateQuantity(int id, int num, int g, double p)
        {
        g = 0;
            for (int i = 0; i < numb_of_diff_items; i++) 
        {
            if (id == Ilist.ElementAt(i).idItem)
            {
                if (Ilist.ElementAt(i).stock - num <= 0)
                {
                    Console.WriteLine("We do not have enough of this item.");
                    g = 1;
                }
                else
                {
                    Ilist.ElementAt(i).stock -= num;
                    p = Ilist.ElementAt(i).sellingPrice; 
                }

            }
        }
        }

        public void report()
        {
            Console.WriteLine("\nitemID      itemName      plnstore     manufPrice      sellingPrice");
            for (int i = 0; i < numb_of_diff_items; i++)
            {
                Console.WriteLine("\n{0}      {1}      {2}    {3}      {4}", Ilist.ElementAt(i).idItem, Ilist.ElementAt(i).iName, Ilist.ElementAt(i).stock, Ilist.ElementAt(i).manuPrice.ToString("C"), Ilist.ElementAt(i).sellingPrice.ToString("C"));
            }
        }

        public double total_inventory
        {
            get
            {
                return total_inv;
            }
            set
            {
                for (int i = 0; i < numb_of_diff_items; i++)
                {
                    total_inv = total_inv + Ilist.ElementAt(i).sellingPrice;
                }
            }
        }

        public int total_number_of_items
        {
            get
            {
                return total_numItem;
            }
            set
            {
                for (int i = 0; i < numb_of_diff_items; i++)
                {
                    total_numItem = total_numItem + Ilist.ElementAt(i).stock;
                }
            }
        }

        public List<item> l
        {
            get
            {
                return Ilist;
            }
        }
    }
