class Words
{
    private string text;

 answer
main
    public Words(string t) => text = t;

    public int Length => text.Length;

    public bool IsPalindrome()
    {
 answer
      
main
        if (string.IsNullOrEmpty(text))
            return true;

        for (int i = 0; i < text.Length / 2; i++)
            if (char.ToLower(text[i]) != char.ToLower(text[text.Length - 1 - i]))
                return false;
        return true;
    }

 answer

 main
    public string Reverse()
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

 answer
 
 main
    public bool ContainsDigits()
    {
        foreach (char c in text)
            if (char.IsDigit(c))
                return true;
        return false;
    }

    public override string ToString() => text;

 answer
  
    public string ToUpper() => text.ToUpper();

 
    public string ToLower() => text.ToLower();

    public string ToUpper() => text.ToUpper();


    public string ToLower() => text.ToLower();
}
 main
}
