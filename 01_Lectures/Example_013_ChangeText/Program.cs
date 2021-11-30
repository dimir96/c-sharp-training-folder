Console.Clear();
string text = "У лукоморья дуб зелёный;"
            + "Златая цепь на дубе том:"
            + "И днём и ночью кот учёный"
            + "Всё ходит по цепи кругом;"
            + "Идёт направо — песнь завод";



string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == oldValue ) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
      
    }

    return result;
}

string newText = Replace (text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace (text, 'к', 'К');
Console.WriteLine(newText);