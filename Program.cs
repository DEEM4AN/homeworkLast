class Task { 
    public static void Main(string[] args) {
        string[] arrayString = ["hello", "run", "12313", "hi", "444", "jerry", "how", "228"];
        string buffString = "";
        char delimiterChar = '*';
        for (int i = 0; i < arrayString.Length; i++)
        {
            if(arrayString[i].Length <= 3) {
                buffString = (buffString + arrayString[i] + delimiterChar);
            }
        }
        string[] arrayWithThreeSymbols = buffString.Split(delimiterChar);
        foreach (string item in arrayWithThreeSymbols)
        {
            Console.WriteLine(item + " ");
        }
    }
}