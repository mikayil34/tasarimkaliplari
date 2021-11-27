using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace _5_Abstract_Factory_Design
{
    public class ProductManager : IProductManager
    {
        CrossCuttingConcernsFactory _crossCuttingConcernsFactory;
        private Logging _logging;
        private Caching _caching;


        public ProductManager(CrossCuttingConcernsFactory crossCuttingConcernsFactory)
        {
            _crossCuttingConcernsFactory = crossCuttingConcernsFactory;
            _logging = _crossCuttingConcernsFactory.CreatiLogger();
            _caching = _crossCuttingConcernsFactory.CreatiCaching();
        }

        public void GetAll()
        {
            _logging.log("_logging");
            _caching.Cach("_caching");

            Console.WriteLine("Produckt Listed");

        }

    }
}
