//v1. Вывод информации по заданым занчениям в переменной
/* 
int OrderNum;
byte HouseNum;
float PriceOrder; 
string ClientOrder;
string ProductOrder;
string StreetOrder;

//Order #1
OrderNum = 1;
ClientOrder = "Alice";
ProductOrder = "smartphone";
PriceOrder = 305.99f;
StreetOrder = "Moon Street";
HouseNum = 10;

Console.WriteLine("Order No " + OrderNum + "." +
                "\nClient: " + ClientOrder + "." +
                "\nProduct: " + ProductOrder + "," + " price " + PriceOrder + " EUR." +
                "\nAddress: " + StreetOrder + ", " + HouseNum + ".");

//Order #2
OrderNum = 2;
ClientOrder = "Tom";
ProductOrder = "laptop";
PriceOrder = 570.95f;
StreetOrder = "Terra Street";
HouseNum = 17;

Console.WriteLine("\nOrder No " + OrderNum + "." +
                "\nClient: " + ClientOrder + "." +
                "\nProduct: " + ProductOrder + "," + " price " + PriceOrder + " EUR." +
                "\nAddress: " + StreetOrder + ", " + HouseNum + ".");

//Order #3
OrderNum = 3;
ClientOrder = "Jack";
ProductOrder = "keyboard";
PriceOrder = 5.50f;
StreetOrder = "Green Walley";
HouseNum = 32;

Console.WriteLine("\nOrder No " + OrderNum + "." +
                "\nClient: " + ClientOrder + "." +
                "\nProduct: " + ProductOrder + "," + " price " + PriceOrder + " EUR." +
                "\nAddress: " + StreetOrder + ", " + HouseNum + ".");
*/

//v2. Вывод значений которые внёс пользователь.
using System;
using System.Collections.Generic;
using System.IO;

int OrderNum = 0;
bool NextOrder = true;

//Коллекция(словарь) цены товара
Dictionary<string, string> ProductDictionary = new Dictionary<string, string>()
    {
        ["smartphone"] = "305.99",
        ["laptop"] = "570.95",
        ["keyboard"] = "5.50"
};

//Список используемых массивов
List<string> ArrClient = new List<string>();
List<string> ArrStreet = new List<string>();
List<string> ArrProduct = new List<string>();
List<string> ArrPriceOrder = new List<string>();
List<byte> ArrHouse = new List<byte>();
List<int> ArrOrderNum = new List<int>();


while (NextOrder)
    {
        byte HouseNum;
        float PriceOrder;
        string ClientOrder ;
        string ProductOrder;
        string StreetOrder;
        string TmpStringValue = null;
        //WhileCheck_flag
        bool CheckHouseNum = false;
        bool CheckPriceOrder = false;
        
        //Order
        OrderNum++;
        ArrOrderNum.Add(OrderNum);

        //Client
        Console.WriteLine("Write your name: ");
        ClientOrder = Console.ReadLine();
        ClientOrder = ToUpperFirstChar(ClientOrder);
        if (ClientOrder != null)
        {
            ArrClient.Add(ClientOrder);
        }

        //Street
        Console.WriteLine("Write your street: ");
        StreetOrder = Console.ReadLine();
        StreetOrder = ToUpperFirstChar(StreetOrder);
        if (StreetOrder != null)
        {
            ArrStreet.Add(StreetOrder);
        }

        //House
        while (!CheckHouseNum)
        {
            try
            {
                Console.WriteLine("Write your number house: ");
                HouseNum = Convert.ToByte(Console.ReadLine());
                if (HouseNum != null)
                {
                    ArrHouse.Add(HouseNum);
                    CheckHouseNum = true;
                }
            }
            catch
            {
                Console.WriteLine("Error 5000. Need to write number!");
            }
        }

        //Product
        while (!CheckPriceOrder)
        {
            Console.WriteLine("Write your product(if you want see product list write 'products'): ");
            ProductOrder = Console.ReadLine().ToLower();

            if (ProductOrder == "products")
            {
                ProductsList();
            }
            else
            {
                //PriceProduct
                foreach (KeyValuePair<string, string> Libr in ProductDictionary)
                {
                    if (ProductOrder == Libr.Key)
                    {
                        TmpStringValue = Libr.Value;
                    }
                }

                if (string.IsNullOrEmpty(TmpStringValue))
                {
                    Console.WriteLine("Error 5000. This product not exist. Write correct name! ");
                }
                else
                {
                    ProductOrder = ToUpperFirstChar(ProductOrder);
                    ArrProduct.Add(ProductOrder);
                    ArrPriceOrder.Add(TmpStringValue);
                    CheckPriceOrder = true;
                }
            }
        }

        //Ask try again
        Console.WriteLine("Will there be more orders?(yes/no): ");
        TmpStringValue = Console.ReadLine();
        if (TmpStringValue.ToLower() == "no")
        {
            NextOrder = false;
            ConsoleWrite();
        }

    };

//Метод получения списка товаров в коллекции
void ProductsList()
{
    List<string> ProductLibName = new List<string>();
    List<string> ProductLibPrice = new List<string>();
    int j = 0;
    foreach (KeyValuePair<string, string> LibrList in ProductDictionary)
    {
        ProductLibName.Add(LibrList.Key);
        ProductLibPrice.Add(LibrList.Value);
    }

    for (int i = 0; i < ProductLibName.Count; i++)
    {
        j++;
        Console.WriteLine(j + "." + "Name: " + ProductLibName[i] + ". Price: " + ProductLibPrice[i]);
    };
}

//Метод преобразования с нижнего регистра в верхний регистр(первый символ)
string ToUpperFirstChar(string value)
{
    value = char.ToUpper(value[0]) + value.Substring(1);
    return value;
}

//Метод вывода информации с массивов
void ConsoleWrite()
{
    for(int i = 0; i < ArrOrderNum.Count; i++)
        {
            Console.WriteLine("\nOrder No " + ArrOrderNum[i] + "." +
                              "\nClient: " + ArrClient[i] + "." +
                              "\nProduct: " + ArrProduct[i] + "," + " price " + ArrPriceOrder[i] + " EUR." +
                              "\nAddress: " + ArrStreet[i] + ", " + ArrHouse[i] + ".");
        };
    Console.ReadLine();
};
