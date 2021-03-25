using Anagram.Application;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace Anagram.Tests
{
    public class AnagramTests
    {
        private IAnagram _wordTest;
        private ServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            _serviceProvider = new ServiceCollection()
                .AddSingleton<IAnagram, AnagramAppllication>()
                .BuildServiceProvider();

            _wordTest = _serviceProvider.GetService<IAnagram>();
        }

        [Test]
        public void TestReverse()
        {
            Assert.AreEqual("home", _wordTest.ReverseWord("emoh"));
            Assert.AreEqual("honey", _wordTest.ReverseWord("yenoh"));
            Assert.AreEqual("kj!nm*m", _wordTest.ReverseWord("mm!nj*k"));
        }

        [Test]
        public void TestSpase()
        {
            Assert.AreEqual(" ", _wordTest.ReverseWord(" "));
        }

        [Test]
        public void TestReverseWord()
        {
            Assert.AreEqual("pae!y gni?,og ek!!,il ta!ht", _wordTest.Reverse("yea!p goi?,ng li!!,ke th!at"));
            Assert.AreEqual("try!!ing n@!ot to di?e whi@l!e learning co??ding", _wordTest.Reverse("gni!!yrt t@!on ot ei?d eli@h!w gninrael gn??dioc"));
        }

        [Test]
        public void TestNull()
        {
            string word = null;
            Assert.AreEqual(word, _wordTest.ReverseWord(null));
        }
    }
}
