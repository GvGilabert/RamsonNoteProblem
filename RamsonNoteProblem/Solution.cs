namespace RamsonNoteProblem
{
    public class Solution
    {
        public Dictionary<string, int> CreateWordCountDictionaryLinq(string[] wordsArray) =>
           wordsArray.GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count());

        public Dictionary<string, int> CreateWordCountDictionary(string[] wordsArray)
        {
            var wordsDict = new Dictionary<string, int>();
            foreach (var word in wordsArray)
            {
                if (wordsDict.TryGetValue(word, out int value))
                {
                    wordsDict[word] = ++value;
                }
                else
                {
                    wordsDict.Add(word, 1);
                }
            }
            return wordsDict;
        }

        public string CheckMagazineForWordsInNote(string[] magazine, string[] note)
        {
            var result = string.Empty;

            if (magazine.Length < note.Length)
                result = "No";

            var magDict = CreateWordCountDictionary(magazine);

            foreach (var word in note)
            {
                if (magDict.TryGetValue(word, out int value) && value >= 1)
                {
                    magDict[word] = --value;
                }
                else
                {
                    result = "No";
                    break;
                }
            }
            result = string.IsNullOrEmpty(result) ? "Yes" : result;
            return result;
        }
    }
}