using operations;

namespace CubeInterface
{
    public interface ICubeInterface
    {
        public dynamic CubeInterface(dynamic a);
    }

    public class Cubing : ICubeInterface

    {
        public dynamic result;

        public dynamic CubeInterface(dynamic a)
        {
            result = Cube.Cubed(a);
            return result;
        }
    }
}