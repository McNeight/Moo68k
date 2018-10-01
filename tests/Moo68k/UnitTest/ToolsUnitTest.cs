using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moo68k.Tools;

namespace Moo86k.UnitTest
{
    [TestClass]
    public class ToolsUnitTest
    {
        [TestMethod]
        [TestCategory("Tools")]
        public void TestCompiler()
        {

        }

        [TestMethod]
        [TestCategory("Parser")]
        public void TestHexParser()
        {
            // Int

            Assert.AreEqual(0, "0".HexStringToInt());
            Assert.AreEqual(15, "0x_F".HexStringToInt());
            Assert.AreEqual(291, "0x123".HexStringToInt());
            Assert.AreEqual(32848, "8050".HexStringToInt());

            // Long

            Assert.AreEqual(uint.MaxValue, "0xFFFF_FFFF".HexStringToLong());
            Assert.AreEqual(-1, "0xFFFF_FFFF_FFFF_FFFF".HexStringToLong());

            // ULong

            Assert.AreEqual(uint.MaxValue, "0xFFFF_FFFF".HexStringToULong());
            Assert.AreEqual(ulong.MaxValue, "0xFFFF_FFFF_FFFF_FFFF".HexStringToULong());

            // Formatted hex strings longer than 16 characters are trimmed off.
            Assert.AreEqual(ulong.MaxValue, "0xFAC_FFFF_FFFF_FFFF_FFFFul".HexStringToULong());
        }
    }
}
