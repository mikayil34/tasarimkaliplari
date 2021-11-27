using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Factory_Method_Design
{
    //not ikinci not oluşturlamadı
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_4_Factory_Method_Design");
            CostumerManager manager = new CostumerManager(new loggerFactory2());
            manager.Save();
            Console.ReadLine();

        }
    }
    public class loggerFactory : IloggerFactory
    {
        public ILogger CreateLogger()
        {
            return new EdLooger();

        }

    }

    public class loggerFactory2 : IloggerFactory
    {
        public ILogger CreateLogger()
        {
            return new LogForNetLooger();

        }

    }
    public class EdLooger : ILogger
    {
        public void Log()
        { 
           Console.WriteLine("logger write edlog");

        }

    }
    public class LogForNetLooger : ILogger
    {
        public void Log()
        {

            Console.WriteLine("logger write LogForNetLooger");

        }

    }
    public class CostumerManager
    {

        private IloggerFactory _loggerFactory;

        public CostumerManager(IloggerFactory loggerFactory)
        {
            _loggerFactory = new loggerFactory();
        }
        public void Save()
        { 
            Console.WriteLine("Saved!");
            ILogger logger = _loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
