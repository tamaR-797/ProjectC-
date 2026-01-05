

using DO;

namespace DalApi
{
   public  interface ICrud<T>
    {
        int Create(T t);
        T? Read(int id);
        List<T?> ReadAll();
        void Update(T t);
        void Delete(int id);
    }
}
