namespace Ominous;

public class Utils {
    static Random rand = new Random();

    public static float RandomRangeFloat(float min, float max) {
        return (float)(rand.NextDouble() * (max - min) + min);
    }
}