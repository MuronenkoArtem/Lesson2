using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo anim = new Zoo(new Feed());
            TimerCallback tm = new TimerCallback(Count);
            Timer timer = new Timer(tm, anim, 0, 5000);
            do
            {                
                Console.WriteLine("Select an action\n1 - Add Animal\n2 - Feed Animal\n3 - Cure Annimal\n4 - Delete Animal\n5 - Show all animals\n6 - Clear console");
                string command = Console.ReadLine();
                Console.WriteLine(command);
                switch (command)
                {
                    case "1":
                        Console.WriteLine("Enter kind of animal\n1 - Lion\n2 - Tiger\n3 - Bear\n4 - Elefant\n5 - Wolf\n6 - Fox");
                        switch (Console.ReadLine())
                        {
                            case "1": anim.Create(Console.ReadLine(),KindAnim.Lion); break; ;
                            case "2": anim.Create(Console.ReadLine(), KindAnim.Tiger); break; ;
                            case "3": anim.Create(Console.ReadLine(), KindAnim.Bear); break; ;
                            case "4": anim.Create(Console.ReadLine(), KindAnim.Elefant); break; ;
                            case "5": anim.Create(Console.ReadLine(), KindAnim.Wolf); break; ;
                            case "6": anim.Create(Console.ReadLine(), KindAnim.Fox); break; ;
                            default:
                                break;
                        }break;                        
                    case "2": Console.WriteLine("Enter name animal: "); anim.Algorithm(Console.ReadLine()) ; break;
                    case "3": Console.WriteLine("Enter name animal: "); anim.Strategy = new Cure(); anim.Algorithm(Console.ReadLine()); break;
                    case "4": Console.WriteLine("Enter name animal: "); anim.Delete(Console.ReadLine());  break;
                    case "5": anim.ShowAll(); break;
                    case "6": Console.Clear(); break;
                    default:
                        break;
                }                    
            }
            while (anim.Exit());
            Console.ReadKey();
        }
        public static void Count(object obj)
        {
            Zoo anim = (Zoo)obj;
            anim.Update();
        }
    }
}
