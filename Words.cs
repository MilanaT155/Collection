class Words
{
    private string text;
    
    public Word(string t) => text = t;
    
    public int Length => text.Length;
    
    public bool IsPalindrome()
    {
        for (int i = 0; i < text.Length / 2; i++)
            if (char.ToLower(text[i]) != char.ToLower(text[text.Length - 1 - i]))
                return false;
        return true;
    }
    
    public override string ToString() => text;
}
