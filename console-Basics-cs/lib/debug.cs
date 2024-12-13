namespace console_Basics_cs.lib;

public class Debug
{
    // Adopted from https://getacademy.moodlecloud.com/course/view.php?id=41
    public static void RunDebug()
    {
        var range = 250;
        var counts = new int[range];
        string text = "something";
        
        // Looping while 
        while (!string.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine(text);
            text = Console.ReadLine();
            foreach (var c in text ?? string.Empty)
            {
                counts[(int)c]++;
            }
            // Counting x characters in string
            for (var i = 0; i < range; i++)
            {
                // Ensure that counts is great than 10
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + counts[i]);
                }
            }
        }
    }
}