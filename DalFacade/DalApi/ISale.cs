using DO;


namespace DalApi
{
    public  interface ISale:ICrud<Sale>
    {

        int Create(Sale s);
        Sale Read(int id);
        List<Sale> ReadAll();
        void Update(Sale s);
        void Delete(int id);
    }
}
