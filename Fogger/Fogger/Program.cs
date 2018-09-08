using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace Fogger
{

    class Program
    {
        const int WINDOW_HEIGHT = 40;
        const int WINDOW_WIDTH = 120;



        struct point
        {
            public int x;
            public int y;
        }
        struct Player
        {
            public point position;
            public int height;
            public int width;
            public char symbol;
            public ConsoleColor color;


            public void draw()
            {
                for (int i = (position.x - width / 2); i < (position.x + width / 2); i++)
                {
                    PrintCharacter(i, position.y, symbol, color);
                }

            }
        }

        class Obj
        {
            public point position;
            public int height;
            public int width;
            public char symbol;
            public ConsoleColor color;
            public point speed;

            public void move()
            {
                if (position.x == 7)
                {
                    position.x = WINDOW_WIDTH - 8;
                }

                position.x = position.x - speed.x;
                position.y = position.y;

            }

            public void moveback()
            {
                if (position.x == WINDOW_WIDTH - 5)
                {
                    position.x = 5;
                }
                position.x = position.x + speed.x;
                position.y = position.y;
            }

            public void draw()
            {
                for (int i = (position.x - width / 2); i < (position.x + width / 2) ; i++)
                {
                    PrintCharacter(i, position.y, symbol, color);
                }
                

            }
        }



        static void Main(string[] args)
        {
            // intitialize Game
            Console.Title = "FOGGER GAME";

            bool isGameOver = true;
            bool isGamePlay = true;
            int Point = 0;
            int upspeed = 0;

            Console.BufferHeight = Console.WindowHeight = WINDOW_HEIGHT;
            Console.BufferWidth = Console.WindowWidth = WINDOW_WIDTH;
            Console.Clear();

            // Inittialize Hero
            Player hero = new Player();
            hero.position.x = WINDOW_WIDTH / 2;
            hero.position.y = WINDOW_HEIGHT - 5;
            hero.color = ConsoleColor.Red;
            hero.symbol = 'I';
            hero.height = 1;
            hero.width = 6;

            // Inittialize Obj

            //Cars low 1
            Obj Obj = new Obj();
            Obj Obj1 = new Obj();
            Obj Obj2 = new Obj();
            Obj Obj3 = new Obj();
            Obj Obj4 = new Obj();

            FuncObj(Obj, WINDOW_WIDTH - WINDOW_WIDTH + 20, WINDOW_HEIGHT - 7, ConsoleColor.White, '#', 1, 6, 1);
            FuncObj(Obj1, WINDOW_WIDTH - WINDOW_WIDTH + 40, WINDOW_HEIGHT - 7, ConsoleColor.White, '#', 1, 6, 1);
            FuncObj(Obj2, WINDOW_WIDTH - WINDOW_WIDTH + 60, WINDOW_HEIGHT - 7, ConsoleColor.White, '#', 1, 6, 1);
            FuncObj(Obj3, WINDOW_WIDTH - WINDOW_WIDTH + 80, WINDOW_HEIGHT - 7, ConsoleColor.White, '#', 1, 6, 1);
            FuncObj(Obj4, WINDOW_WIDTH - WINDOW_WIDTH + 100, WINDOW_HEIGHT - 7, ConsoleColor.White, '#', 1, 6, 1);




            //Obj Obj = new Obj();
            //Obj.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 20;
            //Obj.position.y = WINDOW_HEIGHT - 7;
            //Obj.color = ConsoleColor.Green;
            //Obj.symbol = 'A';
            //Obj.height = 2;
            //Obj.width = 6;
            //Obj.speed.x = 1;

            //Obj Obj1 = new Obj();
            //Obj1.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 40;
            //Obj1.position.y = WINDOW_HEIGHT - 7;
            //Obj1.color = ConsoleColor.Green;
            //Obj1.symbol = 'B';
            //Obj1.height = 2;
            //Obj1.width = 6;
            //Obj1.speed.x = 1;

            //Obj Obj2 = new Obj();
            //Obj2.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 60;
            //Obj2.position.y = WINDOW_HEIGHT - 7;
            //Obj2.color = ConsoleColor.Green;
            //Obj2.symbol = 'C';
            //Obj2.height = 2;
            //Obj2.width = 6;
            //Obj2.speed.x = 1;

            //Obj Obj3 = new Obj();
            //Obj3.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 80;
            //Obj3.position.y = WINDOW_HEIGHT - 7;
            //Obj3.color = ConsoleColor.Green;
            //Obj3.symbol = 'D';
            //Obj3.height = 2;
            //Obj3.width = 6;
            //Obj3.speed.x = 1;

            //Obj Obj4 = new Obj();
            //Obj4.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 100;
            //Obj4.position.y = WINDOW_HEIGHT - 7;
            //Obj4.color = ConsoleColor.Green;
            //Obj4.symbol = 'F';
            //Obj4.height = 2;
            //Obj4.width = 6;
            //Obj4.speed.x = 1;

            // Cars row 2
            Obj Obj5 = new Obj();
            Obj Obj6 = new Obj();
            Obj Obj7 = new Obj();
            Obj Obj8 = new Obj();
            Obj Obj9 = new Obj();
            Obj Obj10 = new Obj();



            FuncObj(Obj5, WINDOW_WIDTH - WINDOW_WIDTH + 7, WINDOW_HEIGHT - 13, ConsoleColor.White, 'A', 1, 6, 1);
            FuncObj(Obj6, WINDOW_WIDTH - WINDOW_WIDTH + 25, WINDOW_HEIGHT - 13, ConsoleColor.White, 'B', 1, 6, 1);
            FuncObj(Obj7, WINDOW_WIDTH - WINDOW_WIDTH + 45, WINDOW_HEIGHT - 13, ConsoleColor.White, 'C', 1, 6, 1);
            FuncObj(Obj8, WINDOW_WIDTH - WINDOW_WIDTH + 65, WINDOW_HEIGHT - 13, ConsoleColor.White, 'D', 1, 6, 1);
            FuncObj(Obj9, WINDOW_WIDTH - WINDOW_WIDTH + 85, WINDOW_HEIGHT - 13, ConsoleColor.White, 'E', 1, 6, 1);
            FuncObj(Obj10, WINDOW_WIDTH - WINDOW_WIDTH + 100, WINDOW_HEIGHT - 13, ConsoleColor.White, 'F', 1, 6, 1);

            //Obj Obj5 = new Obj();
            //Obj5.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 20;
            //Obj5.position.y = WINDOW_HEIGHT -13 ;
            //Obj5.color = ConsoleColor.Green;
            //Obj5.symbol = 'A';
            //Obj5.height = 2;
            //Obj5.width = 7;
            //Obj5.speed.x = 1;

            //Obj Obj6 = new Obj();
            //Obj6.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 40;
            //Obj6.position.y = WINDOW_HEIGHT - 13;
            //Obj6.color = ConsoleColor.Green;
            //Obj6.symbol = 'B';
            //Obj6.height = 2;
            //Obj6.width = 7;
            //Obj6.speed.x = 1;

            //Obj Obj7 = new Obj();
            //Obj7.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 60;
            //Obj7.position.y = WINDOW_HEIGHT - 13;
            //Obj7.color = ConsoleColor.Green;
            //Obj7.symbol = 'C';
            //Obj7.height = 2;
            //Obj7.width = 7;
            //Obj7.speed.x = 1;

            //Obj Obj8 = new Obj();
            //Obj8.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 80;
            //Obj8.position.y = WINDOW_HEIGHT - 13;
            //Obj8.color = ConsoleColor.Green;
            //Obj8.symbol = 'D';
            //Obj8.height = 2;
            //Obj8.width = 7;
            //Obj8.speed.x = 1;

            //Obj Obj9 = new Obj();
            //Obj9.position.x = WINDOW_WIDTH - WINDOW_WIDTH + 100;
            //Obj9.position.y = WINDOW_HEIGHT - 13;
            //Obj9.color = ConsoleColor.Green;
            //Obj9.symbol = 'F';
            //Obj9.height = 2;
            //Obj9.width = 7;
            //Obj9.speed.x = 1;

            // Car row 2
            Obj Obj11 = new Obj();
            Obj Obj12 = new Obj();
            Obj Obj13 = new Obj();
            Obj Obj14 = new Obj();
            Obj Obj15 = new Obj();
            Obj Obj16 = new Obj();





            FuncObj(Obj11, WINDOW_WIDTH - WINDOW_WIDTH + 7, WINDOW_HEIGHT - 19, ConsoleColor.White, 'A', 1, 6, 1);
            FuncObj(Obj12, WINDOW_WIDTH - WINDOW_WIDTH + 25, WINDOW_HEIGHT - 19, ConsoleColor.White, 'B', 1, 6, 1);
            FuncObj(Obj13, WINDOW_WIDTH - WINDOW_WIDTH + 45, WINDOW_HEIGHT - 19, ConsoleColor.White, 'C', 1, 6, 1);
            FuncObj(Obj14, WINDOW_WIDTH - WINDOW_WIDTH + 65, WINDOW_HEIGHT - 19, ConsoleColor.White, 'D', 1, 6, 1);
            FuncObj(Obj15, WINDOW_WIDTH - WINDOW_WIDTH + 85, WINDOW_HEIGHT - 19, ConsoleColor.White, 'E', 1, 6, 1);
            FuncObj(Obj16, WINDOW_WIDTH - WINDOW_WIDTH + 100, WINDOW_HEIGHT - 19, ConsoleColor.White, 'F', 1, 6, 1);

            //items
            Obj item1 = new Obj();
            Obj item2 = new Obj();
            Obj item3 = new Obj();

            FuncObj(item1, WINDOW_WIDTH / 2, 9, ConsoleColor.Magenta, 'H', 1, 5, 1);
            FuncObj(item2, (WINDOW_WIDTH / 2) + 26, 9, ConsoleColor.Magenta, 'H', 1, 5, 1);
            FuncObj(item3, (WINDOW_WIDTH / 2) - 26, 9, ConsoleColor.Magenta, 'H', 1, 5, 1);




            while (isGamePlay)
            {
                // Input
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo keyPressed = Console.ReadKey(true); // true mean not show anything
                    while (Console.KeyAvailable) { Console.ReadKey(true); } // edit bug hero slow
                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        if (hero.position.x > 4)
                        {

                            hero.position.x -= 2;

                        }

                    }
                    if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        if (hero.position.x < WINDOW_WIDTH - 4)
                        {
                            hero.position.x += 2;

                        }
                    }


                    if (keyPressed.Key == ConsoleKey.UpArrow)
                    {
                        if (hero.position.y > 10)
                        {
                            hero.position.y -= 2;

                        }
                    }

                    if (keyPressed.Key == ConsoleKey.DownArrow)
                    {
                        if (hero.position.y < WINDOW_HEIGHT - 4)
                        {
                            hero.position.y += 2;

                        }
                    }


                }

                // Update logic

                List<Obj> theCarsList = new List<Obj>()
                {
                    Obj, Obj1, Obj2, Obj3, Obj4, Obj5, Obj6, Obj7, Obj8, Obj9, Obj10, Obj11, Obj12, Obj13, Obj14,
                    Obj15, Obj16,

                };


                // Check game over
                // hit cars
                for (int i = 0; i < theCarsList.Count; i++)
                {
                   
                    int a = hero.position.x;
                    int b = theCarsList[i].position.x;
                    int c = hero.position.y;
                    int d = theCarsList[i].position.y;


                    if ((a == b 
                        || a + 1 == b - 1 || a + 1 == b - 2 || a + 1 == b - 3 
                        || a + 2 == b - 1 || a + 2 == b - 2 || a + 2 == b - 3
                        || a + 3 == b - 1 || a + 3 == b - 2 || a + 3 == b - 3
                        || a - 1 == b + 1 || a - 1 == b + 2 || a - 1 == b + 3
                        || a - 2 == b + 1 || a - 2 == b + 2 || a - 2 == b + 3
                        || a - 3 == b + 1 || a - 3 == b + 2 || a - 2 == b + 3) && c == d)

                    {
                        isGameOver = false;
                    }

                }

                if (item1.position.x == hero.position.x && item1.position.y == hero.position.y)
                {
                    item1.position.x = 5;
                    item1.position.y = 5;
                    item1.color = ConsoleColor.Black;
                    hero.position.x = WINDOW_WIDTH / 2;
                    hero.position.y = WINDOW_HEIGHT - 3;
                    upspeed += 75;
                    Point++;

                }
                if (item2.position.x == hero.position.x && item2.position.y == hero.position.y)
                {
                    item2.position.x = 5;
                    item2.position.y = 5;
                    item2.color = ConsoleColor.Black;
                    hero.position.x = WINDOW_WIDTH / 2;
                    hero.position.y = WINDOW_HEIGHT - 3;
                    upspeed += 75;
                    Point++;
                }
                if (item3.position.x == hero.position.x && item3.position.y == hero.position.y)
                {
                    item3.position.x = 5;
                    item3.position.y = 5;
                    item3.color = ConsoleColor.Black;
                    hero.position.x = WINDOW_WIDTH / 2;
                    hero.position.y = WINDOW_HEIGHT - 3;
                    upspeed += 75;
                    Point++;
                }
              

                // Update Cars position

                Console.Clear();

                // Loop move cars
                //..................
                //Obj.move();
                //Obj1.move();
                //Obj2.move();
                //Obj3.move();
                //Obj4.move();
                //Obj5.moveback();
                //Obj6.moveback();
                //Obj7.moveback();
                //Obj8.moveback();
                //Obj9.moveback();
                //Obj10.moveback();
                //Obj11.move();
                //Obj12.move();
                //Obj13.move();
                //Obj14.move();
                //Obj15.move();
                //Obj16.move();
                for (int i = 0; i < theCarsList.Count; i++)
                {
                    if ((i < 5 && i >= 0) || (i >= 11 && i <= 16) || (i >= 17))
                    {
                        theCarsList[i].move();
                    }
                    else
                    {
                        theCarsList[i].moveback();
                    }
                }

                



                //Draw games 

                // draw cars
                //Obj.draw();
                //Obj1.draw();
                //Obj2.draw();
                //Obj3.draw();
                //Obj4.draw();
                //Obj5.draw();
                //Obj6.draw();
                //Obj7.draw();
                //Obj8.draw();
                //Obj9.draw();
                //Obj10.draw();
                //Obj11.draw();
                //Obj12.draw();
                //Obj13.draw();
                //Obj14.draw();
                //Obj15.draw();
                //Obj16.draw();
                for (int i = 0; i < theCarsList.Count; i++)
                {
                    theCarsList[i].draw();
                }


                

                item1.draw();
                item2.draw();
                item3.draw();

                hero.draw();


                PrintString(5, 5, "---------------------------------------------------------------------------------------------------------------", ConsoleColor.Blue);
                PrintString(WINDOW_WIDTH/2 - 4 -25, 3, "Point: "+ Point, ConsoleColor.Magenta);
                PrintString(WINDOW_WIDTH / 2 - 4 + 25, 3, "SPEED: " + upspeed, ConsoleColor.Yellow);


                if (Point == 3)
                {
                    PrintString(55, 20, "You WON", ConsoleColor.Green);
                    Point = 0;
                    Console.ReadKey();
                    upspeed = 0;
                    item1.position.x = WINDOW_WIDTH / 2;
                    item1.position.y = 9;
                    item2.position.x = (WINDOW_WIDTH / 2) + 26;
                    item2.position.y = 9;
                    item3.position.x = (WINDOW_WIDTH / 2) - 26;
                    item3.position.y = 9;
                    item1.color = ConsoleColor.Magenta;
                    item2.color = ConsoleColor.Magenta;
                    item3.color = ConsoleColor.Magenta;
                }




                if (isGameOver == false)

                {
                    PrintString(55, 20, "You are Fail", ConsoleColor.Red);
                    Console.ReadKey();
                    isGameOver = true;
                    hero.position.x = WINDOW_WIDTH / 2;
                    hero.position.y = WINDOW_HEIGHT - 3;
                    upspeed = 0;
                    Point = 0;
                    item1.position.x = WINDOW_WIDTH / 2;
                    item1.position.y = 9;
                    item2.position.x = (WINDOW_WIDTH / 2) + 26;
                    item2.position.y = 9;
                    item3.position.x = (WINDOW_WIDTH / 2) - 26;
                    item3.position.y = 9;
                    item1.color = ConsoleColor.Magenta;
                    item2.color = ConsoleColor.Magenta;
                    item3.color = ConsoleColor.Magenta;



                }




                Thread.Sleep(200 - upspeed);
            }


        }

        static void FuncObj(Obj name, int positionX, int positionY, ConsoleColor color, char symbol, int height, int width, int speed)
        {


            name.position.x = positionX;
            name.position.y = positionY;
            name.color = color;
            name.symbol = symbol;
            name.height = height;
            name.width = width;
            name.speed.x = speed;


        }


        static void PrintCharacter(int x, int y, char symbol, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(symbol);
        }

        static void PrintString(int x, int y, string text, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(text);

        }

    }

}
