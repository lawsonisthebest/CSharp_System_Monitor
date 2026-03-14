using System.Diagnostics;
using System.IO;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        PerformanceCounter cpuCounter;
        PerformanceCounter ramCounter;
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        string systemDriveLetter;
        DriveInfo drive;
        PowerStatus pwr = SystemInformation.PowerStatus;
        float percent;
        int remaining;
        BatteryChargeStatus status;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");

            cpuCounter.NextValue(); // initialize CPU counter
            ramCounter.NextValue(); // initialize RAM counter

            systemDriveLetter = Path.GetPathRoot(Environment.SystemDirectory)!;
            drive = new DriveInfo(systemDriveLetter);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpuUsage = cpuCounter.NextValue();
            float ramUsage = ramCounter.NextValue();

            long totalBytes = drive.TotalSize;
            long freeBytes = drive.AvailableFreeSpace;
            long usedBytes = totalBytes - freeBytes;
            int percentUsed = (int)((usedBytes * 100) / totalBytes);

            percent = pwr.BatteryLifePercent;
            // Seconds remaining
            remaining = pwr.BatteryLifeRemaining;
            // Charging, Critical, Low, High
            status = pwr.BatteryChargeStatus;

            CPU_Label.Text = $"CPU: {cpuUsage:F0}%";
            Memory_Label.Text = $"RAM Usage: {ramUsage:F0}%";
            Storage_Label.Text = $"Storage Usage: {percentUsed}%";
            Battery_Percent_Label.Text = $"Battery: {(percent * 100):F0}%";
            Battery_Health_Label.Text = $"Battery Health:\n{status}";

            CPU_Progress.Value = Math.Min(100, (int)cpuUsage);
            Memory_Progress.Value = Math.Min(100, (int)ramUsage);
            Storage_Progress.Value = Math.Min(100, percentUsed);
            Battery_Percent_Progress.Value = Math.Min(100, (int)(percent * 100));
        }
    }
}