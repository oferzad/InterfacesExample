using System;

namespace InterfacesExample
{
    

    class Program
    {
        //Bubble sort for integers        
        static void Sort(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int ezer = arr[i];
                        arr[i] = arr[j];
                        arr[j] = ezer;
                    }
                }
            }
        }

        //Bubble sort for IComparable
        static void Sort(IComparable[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i].IsBigger(arr[j]))
                    {
                        IComparable ezer = arr[i];
                        arr[i] = arr[j];
                        arr[j] = ezer;
                    }
                }
            }
        }




        static void Main(string[] args)
        {
           

            IComparable[] vArr = new IComparable[3];
            vArr[0] = new Car(100, 2000, 100, 5);
            vArr[1] = new Truck(80, 5000, 75, 100);
            vArr[2] = new Truck(80, 5000, 70, 100);

            IComparable[] pArr = new IComparable[3];
            pArr[0] = new Investigator("Investigator", "222", 10, "Raanana");
            pArr[1] = new PoliceMan("Policman", "333", 25);
            pArr[2] = new Sherrif("Sherrif", "444", 17, "Officer");

            Sort(vArr);
            Sort(pArr);

            Console.WriteLine("Motor Vehicle Sorted Array");
            for (int i = 0; i < vArr.Length; i++)
            {
                MotorVehicle m = (MotorVehicle)vArr[i];
                Console.WriteLine(m.GetGasLevel());
            }

            Console.WriteLine("Policmen Sorted Array");
            for (int i = 0; i < pArr.Length; i++)
            {
                PoliceMan p = (PoliceMan)pArr[i];
                Console.WriteLine(p.GetSeniority());
            }

        }
    }
}
