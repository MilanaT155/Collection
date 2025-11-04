class Words
{
    private string text;

    public Words(string t) => text = t;

    public int Length => text.Length;

    public bool IsPalindrome()
    {
      
        if (string.IsNullOrEmpty(text))
            return true;

        for (int i = 0; i < text.Length / 2; i++)
            if (char.ToLower(text[i]) != char.ToLower(text[text.Length - 1 - i]))
                return false;
        return true;
    }


    public string Reverse()
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

 
    public bool ContainsDigits()
    {
        foreach (char c in text)
            if (char.IsDigit(c))
                return true;
        return false;
    }

    public override string ToString() => text;

  
    public string ToUpper() => text.ToUpper();

 
    public string ToLower() => text.ToLower();
}
