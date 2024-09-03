using Legacy_Printer_Adapter;
using System.Reflection;
namespace Printer_test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_if_works()
        {
            {
                LegacyPrinter legacyprinter = new LegacyPrinter();
                Adapter adapter = new Adapter(legacyprinter);

                //assert
                string ret_mes = adapter.send_message("hello");
                Assert.AreEqual("hello", ret_mes);

            }
        }
    }
}