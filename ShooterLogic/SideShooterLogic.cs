using ShooterDataAccess;
using ShooterDataObjects;

namespace ShooterLogic
{
    public class SideShooterLogic
    {
        public bool EditScores(List<SavedScore> scoreList, int scorelist)
        {
            bool result = false;

            try
            {
                result = DataAccess.UpdateScore(scoreList,scorelist);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Data not saved.", ex);
            }
            return result;
        }

        public List<SavedScore> FetchScores()
        {
            List<SavedScore> scoreList = null;

            scoreList = DataAccess.RetrieveScoreList();
            /*
             try
            {
                scoreList = DataAccess.RetrieveScoreList();
                
            }
            catch (Exception ex)
            {
                // rewrap exception
                throw new ApplicationException("Your data could not be retrieved.", ex);
            }
            */


            return scoreList;
        }

        public bool RemoveScore(List<SavedScore> scoreList)
        {
            bool result = false;

            try
            {
                result = DataAccess.DeleteNpc(scoreList);
            }
            catch (Exception ex)
            {
                //throw new ApplicationException("Data not saved.", ex);
            }
            return result;
        }
    }
}