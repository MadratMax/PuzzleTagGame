namespace PuzzleTag.UI
{
    class Update
    {
        public static PuzzleTag MainFormUI;

        public static void UpdateInfoLabel(string text)
        {
            if (MainFormUI != null)
            {
                //MainFormUI.InfoLabel.Text = text;
            }
        }

        public static void UpdateTotalScoreLabel(string text)
        {
            if (MainFormUI != null)
            {
                MainFormUI.TotalScoreLabel.Text = text;
            }
        }

        public static void ClearInfoLabel()
        {
            if (MainFormUI != null)
            {
                //MainFormUI.InfoLabel.Text = string.Empty;
            }
        }

        public static void ClearTotalScoreLabel()
        {
            if (MainFormUI != null)
            {
                MainFormUI.TotalScoreLabel.Text = string.Empty;
            }
        }
    }
}
