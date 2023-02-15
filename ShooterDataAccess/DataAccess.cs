using ShooterDataObjects;
namespace ShooterDataAccess
{
    public class DataAccess
    {

        public static bool UpdateScore(List<SavedScore> scoreList, int scorelist)
        {
            bool result = false;

            // we need two stream writers
            StreamWriter csvWriter = null;

            try
            {


                csvWriter = new StreamWriter(AppData.DataPath + "\\" + AppData.scoreList);
                foreach (SavedScore newNpc in scoreList)
                {
                    //0   ,1
                    //Name,Scores
                    csvWriter.WriteLine(newNpc.Name + "," +
                                        newNpc.Score);

                }
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                csvWriter.Close();
            }
            return result;
        }

        public static List<SavedScore> RetrieveScoreList()
        {
            
            List<SavedScore> scoreList = new List<SavedScore>();

            char[] separator = { ',' };
            
            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\" + AppData.scoreList);

                while (fileReader.EndOfStream == false)
                {
                    
                    string line = fileReader.ReadLine();
                    
                    string[] parts;
                    
                    if (line.Length > 1) 
                    {
                        parts = line.Split(separator);

                        if (parts.Count() == 2)
                        {
                            SavedScore newScore = new SavedScore();
                            newScore.Name = parts[0];
                            newScore.Score = parts[1];

                            scoreList.Add(newScore);
                        }

                    }
                }
                fileReader.Close();
            }
            catch (Exception up)
            {
                throw up;
            }
            return scoreList;
        }

        public static bool DeleteNpc(List<SavedScore> npcList)
        {
            bool result = false;

            // we need a stream writer
            StreamWriter csvWriter = null;

            try
            {
                csvWriter = new StreamWriter(AppData.DataPath + "\\" + AppData.scoreList);
                foreach (SavedScore oldNpc in npcList)
                {
                    csvWriter.WriteLine(oldNpc.Name + "," +
                                    oldNpc.Score);
                }

                System.IO.File.Delete(AppData.DataPath + "\\" + AppData.scoreList);

                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                csvWriter.Close();
            }

            return result;
        }



































    }
}