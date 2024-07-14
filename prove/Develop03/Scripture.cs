using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(t => new Word(t)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var wordsToHide = _words.Where(static w => !w.IsHidden()).OrderBy(w => new Random().Next()).Take(numberToHide);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(static w => w.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(static w => w.IsHidden());
    }
}
