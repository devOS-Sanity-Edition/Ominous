namespace Ominous;

public class OminousApplicationContext : ApplicationContext {
    private NotifyIcon trayIcon;

    public OminousApplicationContext() {
        trayIcon = new NotifyIcon();
        trayIcon.Visible = false;
    }
}