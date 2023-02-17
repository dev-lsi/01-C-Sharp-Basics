using System;

namespace _06._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetHeight = int.Parse(Console.ReadLine());
            int currentTargetHeight = targetHeight - 30;
            int jumpCounter = 0;
            bool isSuccesful = true;




            while (targetHeight >= currentTargetHeight)
            {
                if (!isSuccesful)
                {
                    break;
                }
                    int currentJumpHeight = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= 3; i++)
                    {
                    
                        
                        jumpCounter++;
                        if (currentJumpHeight > currentTargetHeight)
                        {
                            currentTargetHeight += 5;

                            if(currentTargetHeight > targetHeight)
                            {
                            isSuccesful = true;
                            break;
                            }
                            else
                            {
                            currentJumpHeight = int.Parse(Console.ReadLine());
                            i = 0;
                            continue;
                            }

                        }
                        else if (currentJumpHeight <= currentTargetHeight)
                        {
                            if (i < 3)
                            {
                                currentJumpHeight = int.Parse(Console.ReadLine());
                                continue;
                            }
                            else if (i == 3)
                            {
                                Console.WriteLine($"Tihomir failed at {currentTargetHeight}cm after {jumpCounter} jumps.");
                                isSuccesful = false;
                                break;
                            }
                        }
                    }
                if (isSuccesful)
                {
                    Console.WriteLine($"Tihomir succeeded, he jumped over {currentTargetHeight-5}cm after { jumpCounter} jumps.");
                    break;
                }
                
               
            }


        }
    }
}
