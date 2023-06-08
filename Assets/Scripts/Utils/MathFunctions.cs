using UnityEngine;

public class MathFunctions : MonoBehaviour
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new System.DivideByZeroException("You cannot divide by zero");
        }
        return a / b;
    }

    public static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Mathf.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static int Factorial(int number)
    {
        if (number < 0)
        {
            return -1;
        }

        if (number == 0)
        {
            return 1;
        }

        int result = 1;
        for (int i = 2; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }
}
