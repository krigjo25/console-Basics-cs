namespace console_Basics_cs.lib;

internal class Matte
{
    internal static float Procent(int arg, int[] array)
    {
        const int procentage = 100;

        int sum = 0;
        float prosent = arg;

        // sum the counts
        foreach (int n in array)
        {
            sum += n;
        }

        // Followed the solution https://www.nettavisen.no/prosenter/prosentregning/kvart-prosent/hvordan-regne-prosent-en-enkel-guide-til-prosentregning/s/5-95-1084570
        return prosent / sum * procentage;
    }
}