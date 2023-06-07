using UnityEngine;

    public class SampleScript : MonoBehaviour
    {
        private int score;

        public int Score
        {
            get { return score; }
            set { score = Mathf.Max(value, 0); }
        }

        public void IncreaseScore(int amount)
        {
            Score += amount;
        }
    }
