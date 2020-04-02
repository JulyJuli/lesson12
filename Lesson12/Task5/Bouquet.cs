using System;
using System.Collections.Generic;

namespace Task5
{
    public class Bouquet
    {
        List<Flower> myBouquet;
        public Bouquet()
        {
            myBouquet = new List<Flower>();
        }
        public void ToPickUpBouquet(List<Flower> flowers)
        {
            foreach (var flower in flowers)
            {
                myBouquet.Add(flower);
            }
        }
        public void GetCostOfBouqet()
        {
            decimal bouquetCost = 0;
            for (int i = 0; i < myBouquet.Count; i++)
            {
                bouquetCost += myBouquet[i].FlowerCost;
            }
            PrintCost(bouquetCost);
        }

        protected void PrintCost(decimal bouquetCost)
        {
            Console.WriteLine($"Price of a bouquet is {bouquetCost}");
        }
    }
}

        //    public List<Flower> SortByName()
        //    {
        //        for (int i = 0; i < myBouquet.Count; i++)
        //        {
        //            for (int j = i + 1; j < myBouquet.Count; j++)
        //            {
        //                if (myBouquet[i].FlowerName.CompareTo(myBouquet[j].FlowerName) == 1)
        //                {
        //                    SwapElements(i, j, myBouquet);
        //                }
        //            }
        //        }
        //        return myBouquet;
        //    }

        //    private void SwapElements(int i, int j, List<Flower> myB)
        //    {
        //        Flower tmp = myB[i];
        //        myB[i] = myB[j];
        //        myB[j] = tmp;
        //    }

        //    public void PrintCost1()
        //    {
        //        SortByName();
        //        bool Hasnot = false;
        //        List<Flower> copyBouquet = new List<Flower>();
        //        copyBouquet = myBouquet;
        //        int counter = 0;
        //        for (int i = 0; i < myBouquet.Count; i++)
        //        {
        //            for (int j = i + 1; j < myBouquet.Count; j++)
        //            {
        //                if (myBouquet[i].FlowerName.Equals(myBouquet[j].FlowerName))
        //                {
        //                    if (copyBouquet.Count == 0)
        //                    {
        //                        copyBouquet.Add(myBouquet[i]);
        //                        Console.WriteLine($"Добавили {myBouquet[i].FlowerName}");
        //                        copyBouquet[i].Count = 0;
        //                        copyBouquet[i].Count++;
        //                        Console.WriteLine($"Удаляем {myBouquet[j].FlowerName} из букета");
        //                        myBouquet.RemoveAt(j);
        //                        j--;
        //                    }
        //                    else
        //                    {
        //                        for (int r = 0; r < copyBouquet.Count; r++)
        //                        {
        //                            if (copyBouquet[r] == myBouquet[i])
        //                            {
        //                                copyBouquet[r].Count++;
        //                                Console.WriteLine($"Удаляем {myBouquet[j].FlowerName} из букета");
        //                                myBouquet.RemoveAt(j);
        //                                Hasnot = true;
        //                            }
        //                        }
        //                        if (Hasnot)
        //                        {
        //                            copyBouquet.Add(myBouquet[i]);
        //                            Console.WriteLine($"Добавили {myBouquet[i].FlowerName}");
        //                            copyBouquet[copyBouquet.Count - 1].Count = 0;
        //                            copyBouquet[copyBouquet.Count - 1].Count++;
        //                            Console.WriteLine($"Удаляем {myBouquet[j].FlowerName} из букета");
        //                            myBouquet.RemoveAt(j);
        //                            j--;
        //                        }

        //                    }
        //                }
        //                else
        //                {
        //                    copyBouquet[copyBouquet.Count - 1].Count++;
        //                    Console.WriteLine($"Bouquet has {copyBouquet[copyBouquet.Count - 1].Count}" +
        //                    $" {copyBouquet[copyBouquet.Count - 1].FlowerName}s");
        //                    Console.WriteLine($"Удаляем i {myBouquet[i].FlowerName} из букета");
        //                    myBouquet.RemoveAt(i);

        //                    j = myBouquet.Count;
        //                    i--;
        //                }
        //            }
        //        }
        //    }
        //}

        //public class costList
        //{
        //    List<Flower> costList1 = new List<Flower>();
        //}

