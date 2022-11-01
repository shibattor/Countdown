bool DivisibleBy(int number, int divident) {
    return number % divident == 0;
}

void Countdown() {
    for (int i = 100; i > 0; i--)
    {
        //Console.WriteLine($"Debug info: current number: {i}");

        var divisibleBy3 = DivisibleBy(i, 3);
        var divisibleBy5 = DivisibleBy(i, 5);

        if (divisibleBy3 && divisibleBy5)
        {
            Console.WriteLine($"Testing");            
        } 
        else
        {
            if (divisibleBy3)
            {
                Console.WriteLine($"Software");      
                continue;  
            }
            if (divisibleBy5)
            {
                Console.WriteLine($"Agile");   
                continue;  
            }
            
            Console.WriteLine($"{i}");            
        }
    }
}

Countdown();