namespace ShooterDataObjects
{
    public static class AppData
    {
        public static string DataPath { get; set; }
        public const string DataFolder = "scorefolder";
        public static string[] songlist = {
            "BM.wav",
            "GameMusic2.wav",
            "Winsound.wav",
            "GameOverSound.wav"
        };
        public const string scoreList = "scores.csv";
    }
}