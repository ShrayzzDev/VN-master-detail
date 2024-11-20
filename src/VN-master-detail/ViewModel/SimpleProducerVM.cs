using Model.Producer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class SimpleProducerVM
    {
        internal SimpleProducer _producer = new();

        public string Name
        {
            get => _producer.name;
        }
    }
}
