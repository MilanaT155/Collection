class Words
{
    private string text;

    // »справлен конструктор - название класса Words, а конструктор был Word
    public Words(string t) => text = t;

    public int Length => text.Length;

    public bool IsPalindrome()
    {
        // ƒобавлена проверка на пустую строку
        if (string.IsNullOrEmpty(text))
            return true;

        for (int i = 0; i < text.Length / 2; i++)
            if (char.ToLower(text[i]) != char.ToLower(text[text.Length - 1 - i]))
                return false;
        return true;
    }

    // ƒобавлен метод дл€ реверса строки
    public string Reverse()
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // ƒобавлен метод дл€ проверки, содержит ли слово цифры
    public bool ContainsDigits()
    {
        foreach (char c in text)
            if (char.IsDigit(c))
                return true;
        return false;
    }

    public override string ToString() => text;

    // ƒобавлен метод дл€ получени€ текста в верхнем регистре
    public string ToUpper() => text.ToUpper();

    // ƒобавлен метод дл€ получени€ текста в нижнем регистре
    public string ToLower() => text.ToLower();
}
}
