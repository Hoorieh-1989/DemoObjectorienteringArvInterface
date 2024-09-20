using DemoObjectorienteringArvInterface.Interface;


namespace DemoObjectorienteringArvInterface.Classes
{
    public class Member:Person , IMaintainable<Member>
    {
        public int MemberNo { get; set; }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Member obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
