using EzSign.BusinessLogic.Interfaces;
namespace EzSign.BusinessLogic.Services
{
    public class Sample : ISampleScoped, ISampleSingleton, ISampleTransient
    {
        private static int _counter;
        private int _id;

        public Sample(){
            _id = _counter++;
        }

        public int id(){
            return _id;
        }
    }
}