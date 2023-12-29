class Task { 
    public static void Main(string[] args) {
        string[] arrayInitial = ["hello", "run", "12313", "hi", "444", "jerry", "how", "228"];
        string bufferString = "";
        string delimiterString = "*<><>*";
        for (int i = 0; i < arrayInitial.Length; i++)
        {
            if(arrayInitial[i].Length <= 3) {
                bufferString = (bufferString + arrayInitial[i] + delimiterString);
            }
        }
        string[] threeLetterWordsArray = bufferString.Split(delimiterString);
        foreach (string item in threeLetterWordsArray)
        {
            Console.WriteLine(item + " ");
        }
    }
}