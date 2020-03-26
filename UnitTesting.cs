using Xunit;
using System;
using Moq;

// --ASSERTION TESTS--
// new text
public class UnitTesting
{
    [Fact]
        public void EqualPassed()
        {
            Assert.Equal(8, Add(4, 4));
        }

    [Fact]
        public void SamePassed()
        {
            string a = "a";
            string b = a;

            Assert.Same(a, b);
        }
    
    [Fact]
        public void TruePassed()
        {
            Assert.True(2 > 0);      
        }
    
    [Fact]
        public void FalsePassed()
        {
            Assert.False(2 < 0);      
        }

    [Fact]
        public void NullPassed()
        {
            Assert.Null(null);      
        }    

    [Fact]
        public void EqualFailed()
        {
            Assert.Equal(13, Add(2, 2));
        }

    [Fact]
        public void SameFailed()
        {
            string a = "a";
            string b = "b";

            Assert.Same(a, b);
        }

        [Fact]
        public void TrueFailed()
        {
            Assert.True(2 < 0);      
        }

        [Fact]
        public void FalseFailed()
        {
            Assert.False(2 > 0);      
        }

        [Fact]
        public void NullFailed()
        {
            Assert.Null(" ");      
        }  

        int Add(int x, int y)
        {
            return x + y;
        }
}

// -- MOQ TEST-- 
/*
public class Human
{
    Sentence sentence;

    public string getSentence(Sentence sentence)
    {
        string words = sentence.talk();
        return words;
    }

    public class Sentence
    {
        public string talk()
        {
           return "I am human";
        }
    }

}

public class HumanTest
{
    Mock<Human.Sentence> mockTest = new Mock<Human.Sentence>();

    [Fact]
    public void talkTest()
    {
        Human h = new Human();
        
        string words = h.getSentence(mockTest.Object);
        
        // Passed Moq test
        Assert.Equal("I am human", words);
    }

    [Fact]
    public void talkTest2()
    {
        Human h = new Human();
        
        string words = h.getSentence(mockTest.Object);
    
        // Not passed Moq test
        Assert.Equal("I am NOT human", words);
    }
}

// --STUB TEST--
public class Stubby
{
    [Fact]
    public string IHaveLotsOfArguments(string firstArg, string secondArg, string thirdArg)
    {
        return "I don't care about your arguments";
    }
}

// --FAKE TEST--
public class Faker : Stubby
{
    public string DontWorryIGotThis()
    {
        return IHaveLotsOfArguments("Sit back", "and let me", "run");
    }
} */