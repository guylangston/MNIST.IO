# MNIST.IO
"THE MNIST DATABASE of handwritten digits" DataReader http://yann.lecun.com/exdb/mnist/

If you want to play around with the MNIST dataset on C#, but don't want to distraction of writing the file parser, this package is for you...

```c#
using MNIST.IO;
var data = FileReaderMNIST.LoadImagesAndLables(
    "./data/train-labels-idx1-ubyte.gz",
    "./data/train-images-idx3-ubyte.gz");
```

After watching 3Blue1Brown's YouTube introduction series to neutral networks, I was inspired to play around, but wanted to code in C# rather than python. http://www.3blue1brown.com/videos/2017/10/9/neural-network