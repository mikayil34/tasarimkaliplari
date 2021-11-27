using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Abstract_Factory_Design
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_5_Abstract_Factory_Design");
            ProductManager _productManager = new ProductManager(new Factory2());
            _productManager.GetAll();
        }
    }

    public class log4NetLogger : Logging
    {
        public override void log(string message)
        {
            Console.WriteLine("logger with log4NetLogger" + message);
        }
    }

    public class NLogger : Logging
    {
        public override void log(string message)
        {
            Console.WriteLine("logger with NLogger" + message);
        }
    }

    public class MemChac : Caching
    {
        public override void Cach(string message)
        {
            Console.WriteLine("Caching with MemChac" + message);
        }
    }

    public class RedisChac : Caching
    {
        public override void Cach(string message)
        {
            Console.WriteLine("Caching with RedisChac: " + message);
        }
    }
    public class Factory1 : CrossCuttingConcernsFactory
    {
        public override Caching CreatiCaching()
        {
            return new RedisChac();
        }

        public override Logging CreatiLogger()
        {
            return new log4NetLogger();
        }
    }

    public class Factory2 : CrossCuttingConcernsFactory
    {
        public override Caching CreatiCaching()
        {
            return new MemChac();
        }

        public override Logging CreatiLogger()
        {
            return new NLogger();
        }
    }

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
