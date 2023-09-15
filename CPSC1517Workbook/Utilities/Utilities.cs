using System;
namespace Utils
{
    public static class Utilities
    {
        public static bool IsZeroOrNegative(int value)
            {
        //simple technique -> return expression
        //return value <=0; // true||false

        //explicit technique -> declare all parts
        //bool result;

        //if (value <= 0)
        //{
        //    result = true;
        //}
        //else
        //{
        //    result = false;
        //}
        //return result;


        //simple but explicit -> conditional/ternary operator
        return value <= 0 ? true : false;
            //     if(       )    a else b

        }
        public static bool IsPositive(int value) => value > 0 ? true : false;
        public static bool IsinTheFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
    }
}