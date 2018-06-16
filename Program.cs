using System;
using System.Linq;

namespace MNIST.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = FileReaderMNIST.LoadImagesAndLables(
                "./data/train-labels-idx1-ubyte.gz",
                "./data/train-images-idx3-ubyte.gz");

            Console.WriteLine(data.Count());
        }
    }

}
