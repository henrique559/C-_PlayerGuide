using System;

    namespace Universe
    {
        class InventoryItem
        {
            private double ItemWeight;
            private double ItemVolume;

            public InventoryItem(double ItemWeight, double ItemVolume)
            {
                this.ItemWeight = ItemWeight;
                this.ItemVolume = ItemVolume;
            }
        }

        class Rope : InventoryItem
        {
            public Rope() : base(1, 15)
            {

            }
        }

		class Arrow : InventoryItem
        {
            public Arrow() : base(0.1, 0.05)
            {

            }
        }
        

		class Bow : InventoryItem
        {
            public Bow() : base(1, 3)
            {

            }
        }    

        class Water : InventoryItem
        {
            public Water() : base(2, 3)
            {

            }
        }    

        class Food : InventoryItem 
        {
            public Food() : base(1, 0.5)
            {

            }
        }

        class Sword : InventoryItem
        {
            public Sword() : base(5, 3)
            {

            }
        }

        class Pack
        {
            private int TotalItems;
            private float MaxWeight;
            private float MaxVolume;
            private float Volume;
            private float Weight;
            private int Count;

            public Pack(int TotalItems, float MaxWeight,float MaxVolume)
            {
                this.TotalItems = TotalItems;
                this.MaxWeight = MaxWeight;
                this.MaxVolume = MaxVolume;
                Volume = 0;
                Weight = 0;
            }


            // Create arrays
            private InventoryItem[] Items = new InventoryItem[TotalItems];

            // Method to add items in Backpack
            //
            //
            public bool Add(InventoryItem item)
            {
                if((item.ItemWeight + Weight) > MaxWeight || (item.ItemVolume + Volume) > MaxVolume || count > TotalItems)
                {
                    return false;
                }
                else
                {
                    Weight += item.ItemWeight;
                    Volume += item.ItemVolume;

                    Items[count] = item;
                    count++;

                    return true;
                }

            }

            // Properties to check Item, weight and volume
            public int GetTotalItem
            {
                get => Count;
            }
            public float GetVolume
            {
                get => Volume;
            }
            public float GetWeight
            {
                get => Weight;
            }

        }


        class MyMain()
        {
            public static void Main(string[] args)
            {
                // Criar classe que instancia objetos
                Rope Corda = new Rope();
                Pack Mochila = new Mochila(10, 50, 50);

                // Criar menu
                if(!Mochila.Add(Corda))
                {
                    Console.WriteLine("A Mochila está cheia");
                }
                else
                {
                    Console.WriteLine("Item Adicionado com Sucesso");
                }




            }
        }
		
    }
