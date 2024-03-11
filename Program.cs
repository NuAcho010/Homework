
class Program{
    static void Main(){
        string[] inputArray = {"ghsg", "fff", "hrsdijghd", "af", "jdfhbbejn"};
        string[] newArray = new string[inputArray.Length];
        int index = 0;
        foreach (string str in inputArray){
            if (str.Length <= 3){
                newArray[index] = str;
                index++;
            }
        }
    for (int i = 0; i < index; i++) {
        Console.WriteLine(newArray[i]);
    }
    }
}