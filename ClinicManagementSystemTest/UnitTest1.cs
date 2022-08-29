using NUnit.Framework;
using ClinicManagementSystemLibrary;

namespace ClinicManagementSystemTest
{
    public class Tests
    {
        public ICMSRepo Iobj;
        
        [SetUp]
        public void Setup()
        {
            Iobj = new CMSRepo();
        }

        [Test]
        public void LoginTestSuccess()
        {
           
            int actres = Iobj.Login("AB101", "Sri1930217@");
            int expres = 1;
            Assert.AreEqual(expres, actres);
        }

        [Test]
        public void LoginTestFail()
        {

            int actres = Iobj.Login("ab101", "sri1930217@");
            int expres = 0;
            Assert.AreEqual(expres, actres);
        }

        
        

        [Test]
        public void AddPatientTest()
        {
            
            try
            {
                Iobj.AddPatient("Arun", "A", "M", 20,DateTime.Parse("20/05/2002").Date);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        
    }
}