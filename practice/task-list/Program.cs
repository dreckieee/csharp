using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nWelcome, dreckieee!\n");

        var task1 = new Task("Push the new project to GitHub", false);
        var task2 = new Task("Finish the Program.cs", true);
        var task3 = new Task("Eat Dinner", true);
        var task4 = new Task("Accomplish a workout", false);
        var task5 = new Task("Feed the fishes", true);
        var task6 = new Task("Drink supplements", false);

        var tasks = new TaskList<Task>();
        Console.WriteLine("\nAdding tasks to task list...");
        tasks.Add(task1);
        Console.WriteLine($">> {task1.Title}");
        tasks.Add(task2);
        Console.WriteLine($">> {task2.Title}");
        tasks.Add(task3);
        Console.WriteLine($">> {task3.Title}");
        tasks.Add(task4);
        Console.WriteLine($">> {task4.Title}");
        tasks.Add(task5);
        Console.WriteLine($">> {task5.Title}");
        tasks.Add(task6);
        Console.WriteLine($">> {task6.Title}");
        Console.WriteLine("\nSuccessfully added tasks to task list!\n");

        Console.WriteLine("\nRemoving one task from task list...");
        Console.WriteLine($">> {task6.Title}");
        tasks.Remove(task6);
        Console.WriteLine("\nSucessfully removed one task from task list!\n");

        Console.WriteLine("\nFiltering tasks that are already done...");
        List<Task> findTaskDone = tasks.FindAll(x => x.IsDone == true);
        if(findTaskDone.Count == 0){Console.WriteLine("\nNo match found!\n");}
        else
        {
            for (int x = 0; x < findTaskDone.Count; x++)
            {
                    Console.WriteLine($"#{x+1} -- {findTaskDone[x].Title}");
            }            
        }


        Console.WriteLine("\nFiltering tasks that are not yet done...");
        List<Task> findTaskNotDone = tasks.FindAll(x => x.IsDone == false);
        if(findTaskNotDone.Count == 0){Console.WriteLine("\nNo match found!\n");}
        else
        {
            for (int x = 0; x < findTaskNotDone.Count; x++)
            {
                    Console.WriteLine($"#{x+1} -- {findTaskNotDone[x].Title}");
            }            
        }


    }//end of Main method
}//end of Program class