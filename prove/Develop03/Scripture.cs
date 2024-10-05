public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddencount = 0;
        {
            int index = random.Next(_words.Count);
            
            if (!_words[index].isHidden())
            {
                _words[index].hide();
                hiddencount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool isCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }


}