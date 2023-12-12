// See https://aka.ms/new-console-template for more information



using System.Collections.ObjectModel;
using System.Linq.Expressions;

public class SomeItem<T>  where T : struct
{
    public int Id { get; set; }
    public string Item { get; set; }
    private Collection<T> Listitems = new Collection<T>();
    public void Create(T item)
    {
       //  IEnumerable <T>  = new T[];
            Listitems = new Collection<T> { item };
            Listitems.Add(item);
       

    }
    public T Get(T item)
    {
        T item = null;
        IQueryable<T> result = Listitems<T>();
        item = result
               .AsNoTracking() //Don't track any changes for the selected item
               .FirstOrDefault(where); //Apply where clause

        return item;

        
    }
  

    public Collection<T> GetSortedList( T SortColumn)
    {
        // Prepare The Dynamic Sort Expression

        return data = Listitems.OrderBy(x => x.GetType().GetProperty(SortColumn);
    }
    



    struct Items
    {
        public string name;
       
    }
}
