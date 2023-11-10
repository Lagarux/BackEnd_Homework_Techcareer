namespace Day4_BookProject.Consts;

public  class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {title.Length}";
    }

    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"girdiğiniz stok ve değer bilgisi negatif değerler olamaz. Stok :{stock}, Kitap değeri : {price}";
    }

    public static string AuthorNameExceptionMessage(string authorName)
    {
        return $"{authorName} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {authorName.Length}";
    }

}
