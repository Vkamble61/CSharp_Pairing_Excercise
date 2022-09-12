using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using PairingExcercise;
namespace PairingExcercise_Test;
using NUnit.Framework;
using FluentAssertions;
public class Tests
{

    //Given a string of words that are separated by a space, you need to return an array of the words, sorted alphabetically by the final character in each.
    //If two words have the same last letter, they returned array should show them in the order they appeared in the given string.
    //For example an input might be "how are you  "   ==> output are  you how 
    // input might be "how are you same "   ==> output are same you how 

    private SortedStringArray SortedStringArray;
    [SetUp]
    public void Setup()
    {
        SortedStringArray = new SortedStringArray();

    }

    [Test]
    public void String_should_return_final_characher_sorted_array()
    {
        //Assert.Pass();
        SortedStringArray.SortedStrings("how are you").Should().Be("are you how");


    }
}