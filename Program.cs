namespace ArraysTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var numberTasks = new NumberTask();
            //int[] mass = numberTasks.EnterArrays();
            //int[] sqrtMass = numberTasks.GetSqrtElements(mass);
            //numberTasks.Print(sqrtMass);
            var numbersTasks = new NumbersTask();
            int number = numbersTasks.Enternumbers();

            int reversed=numbersTasks.GetReverseNumber(number);
            Console.WriteLine(reversed);

        }
    }
}