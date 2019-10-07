using System;

namespace LargeDatasetML
{
    class Program
    {
        static void Main(string[] args)
        {
            //ModelBuilder.CreateModel();
            //return;
            var items = ModelBuilder.GetSampleData(2);
            foreach(var item in items)
            {
                var hasil = ConsumeModel.Predict(item);
                Console.WriteLine($"Hasil: {hasil.Score.ToString("n2")}");
            }
            Console.ReadLine();
            
        }
    }
}
