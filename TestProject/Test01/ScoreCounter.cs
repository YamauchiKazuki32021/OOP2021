using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _scores;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _scores = ReadScore(filePath);

        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(score);
            }
            
            return scores;

        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _scores) {
                if (dict.ContainsKey(score.Subject))
                    //すでにコレクションに教科が設定されている。
                    dict[score.Subject] += score.Score;
                else
                    //コレクションへ教科を登録
                    dict[score.Subject] = score.Score;
            }

            return dict;


        }
    }
}
