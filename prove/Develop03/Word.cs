public class Word
{
    private string _word;
    private bool _visible;

    public Word(string word)
    {
        _word = word;
        _visible = true;
    }

    public string GetWord()
    {
        return $"{_word}";
    }

    public bool IsVisible()
    {
        return _visible;
    }

    public void HideWord()
    {
        _visible = false;
    }
}