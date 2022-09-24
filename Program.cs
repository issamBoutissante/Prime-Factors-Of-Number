//Console.WriteLine("Prime Factors :");
//var primeFactors = (int n) =>
//{
//    // Print the number of 2s that divide n
//    while (n % 2 == 0)
//    {
//        Console.WriteLine("2 ");
//        n = n / 2;
//    }

//    // n must be odd at this point. So we can skip
//    // one element (Note i = i +2)
//    int nSqaure = (int)Math.Sqrt(n);
//    for (int i = 3; i <= nSqaure; i = i + 2)
//    {
//        // While i divides n, print i and divide n
//        while (n % i == 0)
//        {
//            Console.WriteLine($"{i} ");
//            n = n / i;
//        }
//    }

//    // This condition is to handle the case when n
//    // is a prime number greater than 2
//    if (n > 2)
//        Console.WriteLine($"{n} ");
//};


//int n = 123456789;
//primeFactors(n);














var largeNumber = 123456789;

// 1) first find a factor of 123456789 and is between 3 and square root of 123456789
int limit = (int)Math.Sqrt(largeNumber);
for (int i = 3; i <= limit; i++)
{
    while ((largeNumber % i) == 0)
    {
        // . Let the factor be m. Print out m (m is a prime factor)
        var m = i;
        Console.WriteLine(m);
        //find the factor of 123456789 / m and is between 3 and square root of  123456789 / m.
        largeNumber = largeNumber / m;
    }
}









