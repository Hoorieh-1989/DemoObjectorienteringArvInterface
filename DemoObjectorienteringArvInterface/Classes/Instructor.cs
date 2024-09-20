using DemoObjectorienteringArvInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObjectorienteringArvInterface.Classes
{


    //här kombinerar man Arv och Interface
    public class Instructor:Person , IMaintainable<Instructor>
    {

        public int InstructorNo { get; set; }

        //delete metod..
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Instructor obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor obj)
        {
            throw new NotImplementedException();
        }
    }
}
