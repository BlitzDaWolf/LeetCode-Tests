class FizzBuzzClass
{
    string check (int num)
    {
        if (num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
        if (num % 3 == 0) return "Fizz";
        if (num % 5 == 0) return "Buzz";
        return num.ToString();
    }
    
    public IList<string> FizzBuzz(int n)
    {
        return Enumerable.Range(1,n+1).Select(check).ToList();
    }
}