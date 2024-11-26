using System.IO;
using System.Windows.Media;

namespace Ominous;

public class OminousSound {
    public static MediaPlayer mediaPlayer;
    public static Random rand = new Random();

    public static string RandomSound() {
        var soundFiles = new List<String> { "sound.wav", "sound2.wav", "sound3.wav", "sound4.wav", "sound5.wav" };

        int i = rand.Next(soundFiles.Count);
        var names = soundFiles[i];
        soundFiles.RemoveAt(i);

        return Environment.CurrentDirectory + @$"\{names}";
    }

    public static void Open() {
        mediaPlayer = new MediaPlayer();
        mediaPlayer.Open(new Uri(RandomSound()));
    }

    public static void Play() {
        // this is mean and evil and ive gotten several friends to point out how cruel it is but you see i think it adds to the ✨ immersion ✨
        float bal = Utils.RandomRangeFloat(-1.0f, 1.0f);
        float vol = Utils.RandomRangeFloat(0.40f, 1.0f);

        Console.WriteLine($"bal: {bal}, vol: {vol}");
        mediaPlayer.Balance = bal;
        mediaPlayer.Volume = vol;
        mediaPlayer.Play();
    }
}