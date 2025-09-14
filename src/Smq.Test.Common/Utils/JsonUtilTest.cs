namespace Smq.Test.Common.Utils
{
    [TestClass]
    public class JsonUtilTest
    {
        [TestMethod]
        public void Serialize_and_deserialize_ok()
        {
            var input = new JsonUtilTestClass { Name = "Test", Value = 123 };
            var json = Smq.Common.Utils.JsonUtil.AsJson(input);
            Assert.IsNotNull(json);

            var output = Smq.Common.Utils.JsonUtil.AsObject<JsonUtilTestClass>(json);
            Assert.AreEqual("Test", (string)output.Name);
            Assert.AreEqual(123, (int)output.Value);
        }
    }

    internal class JsonUtilTestClass
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
