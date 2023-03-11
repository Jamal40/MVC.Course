
namespace LINQ_Examples;

public class Projections
{
    public static List<Product> GetProductList() => Product.GetProducts;

    public static int SelectSyntax()
    {
        #region select-syntax
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //return all the numbers multiplied by 10
        var result = numbers.Select(n => n * 10);
        PrintCollection(result);
        return 0;
        #endregion
    }

    public static int SelectProperty()
    {
        #region select-property
        List<Product> products = GetProductList();
        //Return the names of the products
        var result = products.Select(p => p.Name);
        PrintCollection(result);
        #endregion
        return 0;
    }

    public static int TransformWithSelect()
    {
        #region select-transform
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //Convert the numbers into corresponding strings
        var result = numbers.Select(n => strings[n]).ToList();

        PrintCollection(result);

        #endregion
        return 0;
    }

    public static int SelectAnonymousConstructions()
    {
        #region select-case-anonymous
        string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

        // Convert each word in the array into anonymous type like this
        // [{upper:"APPLE", lower:"apple"}, {upper:"BLUEBERRY", lower:"blueberry"}]

        var result = words.Select(word => new
        {
            Upper = word.ToUpper(),
            Lower = word.ToLower()
        });

        PrintCollection(result);

        #endregion
        return 0;
    }

    public static int SelectAnonymousConstructionsAgain()
    {
        #region select-new-type-tuple
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //Convert the numbers into strings in this format
        //{"One is odd", "two is even", "three is odd"}
        var result = numbers.Select(n => new
        {
            NumberString = strings[n],
            Status = n % 2 == 0 ? "even" : "odd"
        }).Select(o => $"{o.NumberString} is {o.Status}");

        PrintCollection(result);
        #endregion
        return 0;
    }

    public int SelectPropertySubset()
    {
        #region select-subset-properties
        List<Product> products = GetProductList();

        //Convert the List Of Prudcts into another List of another class that only contains
        //Name, Price

        #endregion
        return 0;
    }

    public int SelectWithIndex()
    {
        #region select-with-index
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //Print Each number with its position in the array
        // Your output should look like something like this:
        /*
          [{number:5, position:0}, {number:4, position:1}]
         */
        #endregion
        return 0;
    }

    public int SelectWithWhere()
    {
        #region select-with-where
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //Show the numbers that are less than 5 in a string format

        #endregion
        return 0;
    }

    public static int HeavySelect()
    {
        var productIds = new Guid[] 
        {
            new Guid("89dbabcd-ca2a-44b5-8c3b-ba50655baaed"),
            new Guid("fb3fb8db-e281-4f6a-9f9b-6c5f76992255"),
            new Guid("bce60455-583a-4b2e-bf8e-f0aad92b0c7c"),
        };
        var products = GetProductList();
        var result = from id in productIds
                      join product in products on id equals product.Id
                      select product;

        var result2 = products.Where(p => productIds.Contains(p.Id));

        PrintCollection(result2);

        return default;
    }

    private static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (T item in collection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------");
    }
}