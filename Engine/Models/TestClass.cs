using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class TestClass : BaseNotificationClass
    {
        private string test = "test";

        public string Test
        {
            get { return test; }
            set
            {
                test = value;
                OnPropertyChanged(nameof(Test));
            }
        }
    }
}
