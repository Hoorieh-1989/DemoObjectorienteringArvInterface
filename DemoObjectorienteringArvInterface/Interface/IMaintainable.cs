using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjectorienteringArvInterface.Interface
{

    //Ett generiskt interface är mer flexibelt och kn användas 
    //för flera olika klasser 
    public interface IMaintainable<T>
    {

        public List<T> GetAll();

        public void Save (T obj);   
        public void Delete (int id ); 
        public void Update (T obj);


    }
}
