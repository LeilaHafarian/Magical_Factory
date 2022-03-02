using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Factory
{
    class Factory
    {
        // Recepie:
        //0= steel, 1=wood 2=plastic  3=bluepaint

        int[] wheel = { 50, 0, 100, 0 };
        int[] box = { 0, 0, 1000, 10 };
        int[] handel = { 100, 50, 0, 0 };
     
        int[] ProduktAmount = { 0, 0, 0, 0 };
        public static int[] MaterialRemain = { 0, 0, 0, 0 };
        public static int[] MaterialConsume = { 0, 0, 0, 0 };
 public Factory()
        {
            Matching();
            Warehouse warehouse =new Warehouse();
            

        }
        public void Matching()
        {
            int steel = Warehouse.steel;
            int wood = Warehouse.wood;
            int plastic = Warehouse.plastic;
            int bluePaint = Warehouse.bluePaint;
            

            int[] InputMaterial = { steel, wood, plastic, bluePaint };
            string ProduktSelected;
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Material have sent to factory");
            Console.WriteLine(InputMaterial[0]);
            Console.WriteLine(InputMaterial[1]);
            Console.WriteLine(InputMaterial[2]);
            Console.WriteLine(InputMaterial[3]);
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            bool condition0 = InputMaterial[0] > 0;
            bool condition1 = InputMaterial[1] > 0;
            bool condition2 = InputMaterial[2] > 0;
            bool condition3 = InputMaterial[3] > 0;
            int min = 0;

            if (condition0 & condition2)
            {
                ProduktSelected = "wheel";
                ProduktAmount[0] = InputMaterial[0] / wheel[0];
                ProduktAmount[1] = InputMaterial[2] / wheel[2];
                ProduktAmount[2] = 0;
                ProduktAmount[3] = 0;

                min = ProduktAmount.Max();
                for (int i = 0; i < 4; i++)
                {
                    if (ProduktAmount[i] != 0)
                    {
                        if (ProduktAmount[i] < min)
                        {
                            min = ProduktAmount[i];
                        }
                    }
                }

                for (int i = 0; i < 4; i++)
                    MaterialConsume[i] = min * wheel[i];

                //Console.WriteLine(MaterialConsume[0]);
                //Console.WriteLine(MaterialConsume[1]);
                //Console.WriteLine(MaterialConsume[2]);
                //Console.WriteLine(MaterialConsume[3]);

                for (int i = 0; i < 4; i++)
                    MaterialRemain[i] = InputMaterial[i] - MaterialConsume[i];
                //Console.WriteLine(MaterialRemain[0]);
                //Console.WriteLine(MaterialRemain[1]);
                //Console.WriteLine(MaterialRemain[2]);
                //Console.WriteLine(MaterialRemain[3]);
                Console.WriteLine("Produced product:  " + ProduktSelected);
                Console.WriteLine("amount of product:        " + min);
                Console.WriteLine(ProduktSelected + " recipe:             " + wheel[0] + ", " + wheel[1] + ", " + wheel[2] + ", " + wheel[3]);
                //Console.WriteLine(ProduktSelected + " material consumed:  " + MaterialConsume[0] + ", " + MaterialConsume[1] + ", " + MaterialConsume[2] + ", " + MaterialConsume[3]);
                //Console.WriteLine(ProduktSelected + " material return:    " + MaterialRemain[0] + ", " + MaterialRemain[1] + ", " + MaterialRemain[2] + ", " + MaterialRemain[3]);
            }



            else if (condition2 & condition3)
            {
                ProduktSelected = "box";
                ProduktAmount[2] = InputMaterial[2] / box[2];
                ProduktAmount[3] = InputMaterial[3] / box[3];
                ProduktAmount[0] = 0;
                ProduktAmount[1] = 0;

                min = ProduktAmount.Max();
                for (int i = 0; i < 4; i++)
                {
                    if (ProduktAmount[i] != 0)
                    {
                        if (ProduktAmount[i] < min)
                        {
                            min = ProduktAmount[i];
                        }
                    }
                }
                Console.WriteLine(min);
                for (int i = 0; i < 4; i++)
                    MaterialConsume[i] = min * box[i];


                for (int i = 0; i < 4; i++)
                    MaterialRemain[i] = InputMaterial[i] - MaterialConsume[i];

                Console.WriteLine("Produced product:  " + ProduktSelected);
                Console.WriteLine("amount of product:        " + min);
                Console.WriteLine(ProduktSelected + " recipe:             " + box[0] + ", " + box[1] + ", " + box[2] + ", " + box[3]);
                //Console.WriteLine(ProduktSelected + " material consumed:  " + MaterialConsume[0] + ", " + MaterialConsume[1] + ", " + MaterialConsume[2] + ", " + MaterialConsume[3]);
                //Console.WriteLine(ProduktSelected + " material return:    " + MaterialRemain[0] + ", " + MaterialRemain[1] + ", " + MaterialRemain[2] + ", " + MaterialRemain[3]);

            }


            else if (condition0 & condition1)
            {
                ProduktSelected = "handel";
                ProduktAmount[0] = InputMaterial[0] / handel[0];
                ProduktAmount[1] = InputMaterial[1] / handel[1];
                ProduktAmount[2] = 0;
                ProduktAmount[3] = 0;

                min = ProduktAmount.Max();
                for (int i = 0; i < 4; i++)
                {
                    if (ProduktAmount[i] != 0)
                    {
                        if (ProduktAmount[i] < min)
                        {
                            min = ProduktAmount[i];
                        }
                    }
                }

                for (int i = 0; i < 4; i++)
                    MaterialConsume[i] = min * handel[i];


                //Console.WriteLine(MaterialConsume[0]);
                //Console.WriteLine(MaterialConsume[1]);
                //Console.WriteLine(MaterialConsume[2]);
                //Console.WriteLine(MaterialConsume[3]);

                for (int i = 0; i < 4; i++)
                    MaterialRemain[i] = InputMaterial[i] - MaterialConsume[i];

                Console.WriteLine("Produced product:  " + ProduktSelected);
                Console.WriteLine("amount of product:        " + min);
                Console.WriteLine(ProduktSelected + " recipe:             " + handel[0] + ", " + handel[1] + ", " + handel[2] + ", " + handel[3]);
                //Console.WriteLine(ProduktSelected + " material consumed:  " + MaterialConsume[0] + ", " + MaterialConsume[1] + ", " + MaterialConsume[2] + ", " + MaterialConsume[3]);
               // Console.WriteLine(ProduktSelected + " material return:    " + MaterialRemain[0] + ", " + MaterialRemain[1] + ", " + MaterialRemain[2] + ", " + MaterialRemain[3]);

                //Console.WriteLine(MaterialRemain[0]);
                //Console.WriteLine(MaterialRemain[1]);
                //Console.WriteLine(MaterialRemain[2]);
                //Console.WriteLine(MaterialRemain[3]);

            }
            else
            {
                ProduktSelected = "no output";
                for (int i = 0; i < 4; i++)
                    MaterialConsume[i] = 0 * handel[i];
                for (int i = 0; i < 4; i++)
                    MaterialRemain[i] = InputMaterial[i] - MaterialConsume[i];
                Console.WriteLine("Produced product:  " + ProduktSelected);
                Console.WriteLine("amount of product:        " + min);
                //Console.WriteLine(ProduktSelected + " recipe:             " + wheel[0] + ", " + wheel[1] + ", " + wheel[2] + ", " + wheel[3]);
                //Console.WriteLine(ProduktSelected + " material consumed:  " + MaterialConsume[0] + ", " + MaterialConsume[1] + ", " + MaterialConsume[2] + ", " + MaterialConsume[3]);
                //Console.WriteLine(ProduktSelected + " material return:    " + MaterialRemain[0] + ", " + MaterialRemain[1] + ", " + MaterialRemain[2] + ", " + MaterialRemain[3]);
            }


            Console.WriteLine(ProduktSelected + " material consumed:  " + MaterialConsume[0] + ", " + MaterialConsume[1] + ", " + MaterialConsume[2] + ", " + MaterialConsume[3]);
            Console.WriteLine(ProduktSelected + " material return:    " + MaterialRemain[0] + ", " + MaterialRemain[1] + ", " + MaterialRemain[2] + ", " + MaterialRemain[3]);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Continue with new selection  " );
            


        }
        

    }
}
