using System.Dynamic;

namespace Lektion25GenericsAsync.Classes;

public class AnimalList<T> : List<T> where T : class
{
    /*public bool Lambda<T>(T value) where T : class
    {
        if (value == null) return false;
        if(value.Race == "Corgi") return true;
    }*/
    
    public List<T> Get(Func<T, bool>? lambda = null)
    {
        return lambda is null ? this : this.Where(lambda).ToList();

        //if (lambda == null) return this;
        //return this.Where(lambda).ToList();
    }
}
