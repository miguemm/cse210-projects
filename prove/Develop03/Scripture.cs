using System.Text;
public class Scripture
{
    private Reference _reference;
    private List<Word> _text;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _text = BuildText(text);
    }

    public string GetFormattedScripture(){
        return $"{_reference.GetReference()} {GetText()}";
    }

    public void HideWord()
    {
        Word randomWord;
        
        do
        {
            int randomIndex = new Random().Next(_text.Count);
            randomWord = _text[randomIndex];
            
        } while (!randomWord.IsVisible());

        randomWord.HideWord();
    }

    public bool AreVisibleWords()
    {
        foreach (var word in _text)
        {
            if (word.IsVisible())
            {
                return true;
            }
        }
        return false;
    }
    
    private string GetText(){
        StringBuilder stringTextBuilder = new StringBuilder();

        foreach (var word in _text)
        {
            if (word.IsVisible())
            {
                stringTextBuilder.Append(word.GetWord());
            }
            else
            {           
                StringBuilder stringWordBuilder = new StringBuilder();

                foreach (char letter in word.GetWord())
                {
                    stringWordBuilder.Append('_');
                }

                stringTextBuilder.Append(stringWordBuilder);
            }
            
            stringTextBuilder.Append(' ');
        }

        return stringTextBuilder.ToString();
    }

    private List<Word> BuildText(string text)
    {
        List<Word> words = new List<Word>();

        string[] wordArray = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (var word in wordArray)
        {
            words.Add(new Word(word));
        }

        return words;
    }

}