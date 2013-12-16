using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_2
{
    public sealed class EvaluationSingleton
    {
        private List<EvaluationList> _data = new List<EvaluationList>();

        static readonly EvaluationSingleton _instance = new EvaluationSingleton();

        public static EvaluationSingleton Instance
        {
            get
            {
                return _instance;
            }
        }

        private EvaluationSingleton()
        {
        }

        public void AddItems(string name, string surname, string evaluation)
        {
            _data.Add(new EvaluationList(name, surname, evaluation));
        }

        public List<EvaluationList> GetList()
        {
            return _data;
        }

        // Function calculates average value of evaluation
        public string AverageEvaluation()
        {
            double avarageEvaluation = 0;
            for (int i = 0; i < _data.Count(); i++)
            {
                avarageEvaluation += Convert.ToDouble(_data[i].Evaluation);
            }
            avarageEvaluation /= _data.Count();
            avarageEvaluation = Math.Round(avarageEvaluation, 2); //round number to two decimal places
            return Convert.ToString(avarageEvaluation); // convert to string because I put this value to textblock.text
        }
    }
}
