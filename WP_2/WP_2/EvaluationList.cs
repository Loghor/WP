using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_2
{
    class EvaluationList
    {
        private string _name;
        private string _surname;
        private string _evaluation;

        public EvaluationList(string name, string surname, string evaluation)
        {
            _name = name;
            _surname = surname;
            _evaluation = evaluation;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public string Evaluation
        {
            get
            {
                return _evaluation;
            }
            set
            {
                _evaluation = value;
            }
        }
    }
}
