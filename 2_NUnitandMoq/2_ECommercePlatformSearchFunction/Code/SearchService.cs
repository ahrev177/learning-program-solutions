using System;

namespace SearchFunction
{
    public static class SearchService
    {
        public static int LinearSearch(Product[] products, string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductName == name)
                    return i;
            }
            return -1;
        }

        public static int BinarySearch(Product[] products, string name)
        {
            int left = 0, right = products.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = products[mid].ProductName.CompareTo(name);
                if (comparison == 0) return mid;
                if (comparison < 0) left = mid + 1;
                else right = mid - 1;
            }
            return -1;
        }
    }
}