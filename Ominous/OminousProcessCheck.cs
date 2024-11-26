using System.Diagnostics;

namespace Ominous;

public class OminousProcessCheck {
    private static string[] processExecutableName = new[] { "javaw" };
    private static int sleepTime = 5000;
    private static Random rand = new Random();
    private static int timesRan = 0;

    public static bool TryGetProcess(out Process? process) {
        var runningProcess = processExecutableName.SelectMany(name => Process.GetProcessesByName(name)).ToArray();

        if (!runningProcess.Any()) {
            process = null;
            return false;
        }

        else if (runningProcess.Length > 1) {
            Console.WriteLine("Found more than one process, still gonna run anyway");
        }

        process = runningProcess.First();
        return true;
    }

    public static void RunProcessCheck() {
        for (var i = 0;; i++) {
            if (i != 0) Thread.Sleep(sleepTime);
            bool prankTime = false;
            Process? process;
            bool success = TryGetProcess(out process);

            if (!success) {
                Console.WriteLine("Process not found yet");
                timesRan = 0; // set to 0 when mc isnt running or detected
                sleepTime = 5000; // make the method re-run every 5 seconds until the games detected
                continue;
            }

            if (success) {
                prankTime = true;
            }

            if (prankTime) {
                Console.WriteLine("hissssssssss");
                sleepTime = rand.Next(1800000, 2700000); // time between 30m and 45m
                timesRan++;
                if (timesRan > 1) { // j increments on first detection of minecraft so lets skip that.
                    OminousSound.Open();
                    OminousSound.Play();
                }
                Console.WriteLine("Sleep time: " + sleepTime);
            }
        }
    }
}